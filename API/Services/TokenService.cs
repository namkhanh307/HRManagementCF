using API.DTO;
using API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace API.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private const int SaltSize = 128 / 8;
        private const int KeySize = 256 / 8;
        private const int Iteration = 10000;
        private static readonly HashAlgorithmName _hashAlgorithm = HashAlgorithmName.SHA256;
        private static char Delimiter = ';';

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Hash(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(SaltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iteration, _hashAlgorithm, KeySize);
            return string.Join(Delimiter, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
        }

        public bool Verify(string hashPassword, string inputPassword)
        {
            var element = hashPassword.Split(Delimiter);
            var salt = Convert.FromBase64String(element[0]);
            var hash = Convert.FromBase64String(element[1]);
            var hashInput = Rfc2898DeriveBytes.Pbkdf2(inputPassword, salt, Iteration, _hashAlgorithm, KeySize);
            return CryptographicOperations.FixedTimeEquals(hash, hashInput);
        }

        public string GenerateJwtToken(CustomUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["JWT:SecretKey"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email)
            // Add role claim
            // new Claim(ClaimTypes.Role, role.RoleName)
        }),
                Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["JWT:Expiration"])),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSignIn = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSignIn, SecurityAlgorithms.HmacSha256Signature)
                );
            return token;   
        }
    }
}
