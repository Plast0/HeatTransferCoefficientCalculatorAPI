using AutoMapper;
using CalculatorAPI.Entity;
using CalculatorAPI.Exceptions;
using CalculatorAPI.Migrations;
using CalculatorAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CalculatorAPI.Services
{
    public interface IAccountService
    {
        string GenerateJwt(LoginDto dto);
        void RegisterUser(User user);
        IEnumerable<User> GetAll();
        List<Envelope> GetUserEnvelops(string email);
        List<EnvelopeDto> GetEnvelops(int userID);
        UserDto GetUserName(string email);
        int AddEnvelop(int userID, CreateEnvelopeDto envelope);
        int AddMaterial(int envelopeId, CreateMaterialDto material);
        MaterialDto GetById(int envelopeId, int materialId);
        List<MaterialDto> GetAll(int envelopeId);
    }                       
    public class AccountService : IAccountService
    {
        private CalculatorDbContext _context;
        private IMapper _mapper;
        private IPasswordHasher<User> _passwordHusher;
        private AuthenticationSettings _authenticationSettings;

        public AccountService(CalculatorDbContext context, IMapper mapper, IPasswordHasher<User> passwordHasher, AuthenticationSettings authenticationSettings) {
            _context = context;
            _mapper = mapper;
            _passwordHusher = passwordHasher;
            _authenticationSettings = authenticationSettings;
        }
        public void RegisterUser(User user)
        {
            var newUser = new User()
            {
                Email = user.Email,
                UserName = user.UserName,
                ConfirePassword = user.ConfirePassword,
                FirstName = user.FirstName,
                LastName = user.LastName,
            };
            var hashedPassword = _passwordHusher.HashPassword(newUser, user.Password);

            newUser.Password = hashedPassword;
            _context.Users.Add(newUser);
            _context.SaveChanges();
        }
        public string GenerateJwt(LoginDto dto)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == dto.Email);
            if (user is null)
            {
                throw new BadRequestException("Invalid username or password");
            }

           var result = _passwordHusher.VerifyHashedPassword(user, user.Password, dto.Password);
            if(result == PasswordVerificationResult.Failed)
            {
                throw new BadRequestException("Invalid username or password");
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
            };

            var key = Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey);

            if (key.Length < 32)
            {
                throw new InvalidOperationException("Klucz JWT musi mieć co najmniej 32 bajty długości.");
            }

            var signingKey = new SymmetricSecurityKey(key);

            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
            var credentails = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature);
            var expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays);

            var token = new JwtSecurityToken(_authenticationSettings.JwtIssuer,
                _authenticationSettings.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: credentails);

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }
        public IEnumerable<User> GetAll()
        {
            var users = _context.Users.ToList();
            return users;
        }
        public List<Envelope> GetUserEnvelops(string email)
        {
            var user = _context.Users.FirstOrDefault(e => e.Email == email);
            var userEnvelops = _context.Envelopes.Where(m => m.UserID == user.Id).Include(m => m.Materials).ToList();
            
            if (userEnvelops == null)  return null; 

            return userEnvelops;
        }
        public List<EnvelopeDto> GetEnvelops(int userID)
        {            
            var user = _context
                .Users
                .Include(u => u.Envelope)
                .ThenInclude(e => e.Materials)
                .FirstOrDefault(u => u.Id == userID);
            if (user is null) throw new NotFoundException("user not found");
            var envelopesDto = _mapper.Map<List<EnvelopeDto>>(user.Envelope);

            return envelopesDto;
        }
        public UserDto GetUserName(string email)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);

            if (user == null) throw new NotFoundException("user not found");

            var newUser = _mapper.Map<UserDto>(user);
            return newUser;

        }
        public int AddEnvelop(int userID, CreateEnvelopeDto envelope)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userID);
            if (user is null) throw new NotFoundException("User not found");


            var newEnvelope = _mapper.Map<Envelope>(envelope);
            newEnvelope.UserID = userID;

            _context.Envelopes.Add(newEnvelope);
            _context.SaveChanges();
            return newEnvelope.Id;
        }
        public int AddMaterial(int envelopeId, CreateMaterialDto material)
        {
            var envelope = _context.Envelopes.FirstOrDefault(e => e.Id == envelopeId);
            if (envelope is null) throw new NotFoundException("envelope not found");


            var newMaterial = _mapper.Map<Material>(material);

            newMaterial.EnvelopeId = envelopeId;

            _context.Materials.Add(newMaterial);
            _context.SaveChanges();
            return newMaterial.Id;
        }
        public MaterialDto GetById(int envelopeId, int materialId)
        {
            var envelope = _context.Envelopes.FirstOrDefault(e => e.Id == envelopeId);
            if (envelope is null) throw new NotFoundException("envelope not found");

            var material = _context.Materials.FirstOrDefault(m => m.Id == materialId);
            if (material is null || material.EnvelopeId != envelopeId)
            {
                throw new NotFoundException("material not found");
            }
            var materialDto = _mapper.Map<MaterialDto>(material);
            return materialDto;
        }
        public List<MaterialDto> GetAll(int envelopeId)
        {
            var envelope = _context
                .Envelopes
                .Include(e => e.Materials)
                .FirstOrDefault(e => e.Id == envelopeId);
            if (envelope is null) throw new NotFoundException("envelope not found");

            var materialDto = _mapper.Map<List<MaterialDto>>(envelope.Materials);

            return materialDto;
        }

    }
}
