using API.DTO;
using API.Models;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace API.Services
{
    public interface ITokenService
    {
        string Hash(string password);

        bool Verify(string hassPassword, string inputPassword);

        string GenerateJwtToken(CustomUser user);

        JwtSecurityToken GetToken(List<Claim> authClaims);
    }
}
