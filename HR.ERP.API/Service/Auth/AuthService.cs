using HR.ERP.API.Data;
using HR.ERP.API.Dtos;
using HR.ERP.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HR.ERP.API.Service.Auth
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthService(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }


        public async Task<AuthResponseDto> Login(LoginDto loginDto)
        {
            var employee = await _context.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == loginDto.Email.ToLower());

            if (employee == null)
                return null;

            if (employee.PasswordHash == loginDto.Password)
                return null;

            var token = GenerateJWTToken(employee);

            return new AuthResponseDto
            {
                Token = token,
                Email = employee.Email,
                Expiration = DateTime.UtcNow.AddHours(3)
            };
        }

        private string GenerateJWTToken(Employee employee)
        {
            var key = Encoding.ASCII.GetBytes(_configuration["JWT:Key"]);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,employee.Id.ToString()),
                new Claim(ClaimTypes.Email, employee.Email),
                new Claim(ClaimTypes.Role, employee.Role)
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
