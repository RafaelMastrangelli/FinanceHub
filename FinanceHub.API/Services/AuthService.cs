using FinanceHub.API.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FinanceHub.API.Services
{
    public class AuthService
    {
        // Em produção, use um repositório de usuários e hash de senha
        private readonly List<User> _users = new() {
            new User { Id = 1, Username = "admin", Password = "admin" }
        };
        private readonly string _jwtKey;
        public AuthService(IConfiguration config)
        {
            _jwtKey = config["Jwt:Key"] ?? "super_secret_key";
        }
        public string? Authenticate(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null) return null;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, user.Username) }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
} 