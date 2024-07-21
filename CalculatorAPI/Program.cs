using CalculatorAPI.Entity;
using CalculatorAPI.Middleware;
using CalculatorAPI.Models.Validators;
using CalculatorAPI.Services;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using NLog.Web;
using System.Reflection;
using System.Text;

namespace CalculatorAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var authenticationSettings = new AuthenticationSettings();

            //Setup NLog
            builder.Logging.ClearProviders();
            builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
            builder.Host.UseNLog(); 

            builder.Services.AddSingleton(authenticationSettings);

            builder.Configuration.GetSection("Authentication").Bind(authenticationSettings);
            builder.Services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = "Bearer";
                option.DefaultScheme = "Bearer";
                option.DefaultChallengeScheme = "Bearer";
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = authenticationSettings.JwtIssuer,
                    ValidAudience = authenticationSettings.JwtIssuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationSettings.JwtKey)),
                };
            });
            builder.Services.AddControllers();
            builder.Services.AddDbContext<CalculatorDbContext>();
            builder.Services.AddScoped<CalculatorSeeder>();
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
            builder.Services.AddScoped<IValidator<User>, RegisterUserDtoValidator>();
            builder.Services.AddScoped<ErrorHandlingMiddleware>();
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("FrontEndClient", builder =>
                    {
                        builder.AllowAnyHeader()
                        //.AllowAnyOrigin()
                        .WithOrigins("http://localhost:5173")
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .AllowAnyHeader();
                    }
               );
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            var scope = app.Services.CreateScope();
            var seeder = scope.ServiceProvider.GetRequiredService<CalculatorSeeder>();

            seeder.Seed();
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMiddleware<ErrorHandlingMiddleware>();
            app.UseAuthentication();
            app.UseHttpsRedirection(); 

            app.UseCors("FrontEndClient");

            app.UseAuthorization();
            

            app.MapControllers();

            app.Run();
        }
    }
}