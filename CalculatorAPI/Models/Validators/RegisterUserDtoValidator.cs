using CalculatorAPI.Entity;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace CalculatorAPI.Models.Validators
{
    public class RegisterUserDtoValidator : AbstractValidator<User>
    {
        public RegisterUserDtoValidator(CalculatorDbContext dbContext) {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).MinimumLength(8);
            RuleFor(x => x.ConfirePassword).Equal(e => e.Password);
            RuleFor(x => x.Email).Custom((value, context) =>
            {
               var emailInUse =  dbContext.Users.Any(u => u.Email == value);
                if(emailInUse)
                {
                    context.AddFailure("Email", "Ten email jest już zajęty.");
                }
            });
        }
    }
}
