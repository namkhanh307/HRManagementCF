﻿using API.DTO;
using API.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = LocalRoles.Admin)]
    public class ClaimControlller : ControllerBase
    {
        private readonly UserManager<CustomUser> _userManager;
        public ClaimControlller(UserManager<CustomUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("getAllClaims")]
        [Authorize(Policy = "ApiAccess:getAllClaims")]
        public async Task<IActionResult> GetAllClaims(string username, string claimType)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(claimType))
            {
                return BadRequest("Username and claimType are required");
            }
            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                return null;
            }

            var claims = await _userManager.GetClaimsAsync(user);
            var filteredClaims = claims.Where(c => c.Type == claimType).ToList();

            if (claims == null)
            {
                return NotFound("User not found");
            }

            return Ok(filteredClaims);
        }


        [HttpPost("addClaim")]
        [Authorize(Policy = "ApiAccess:addClaim")]
        public async Task<IActionResult> AddClaim(ClaimDTO claimDTO)
        {
            var user = await _userManager.FindByIdAsync(claimDTO.UserId);
            if (user == null)
            {
                return NotFound("User not found");  
            }

            var claim = new System.Security.Claims.Claim(claimDTO.ClaimType, claimDTO.ClaimValue);
            var result = await _userManager.AddClaimAsync(user, claim);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok("Claim added successfully");
        }

        [HttpPut("updateClaim")]
        [Authorize(Policy = "ApiAccess:updateClaim")]
        public async Task<IActionResult> UpdateClaim(ClaimDTO claimDTO)
        {
            var user = await _userManager.FindByIdAsync(claimDTO.UserId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            var existingClaims = await _userManager.GetClaimsAsync(user);
            var existingClaim = existingClaims.FirstOrDefault(c => c.Type == claimDTO.ClaimType);
            if (existingClaim == null)
            {
                return NotFound("Claim not found");
            }

            var result = await _userManager.ReplaceClaimAsync(user, existingClaim, new System.Security.Claims.Claim(claimDTO.ClaimType, claimDTO.ClaimValue));
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok("Claim modified successfully");
        }

        [HttpDelete("deleteClaim")]
        [Authorize(Policy = "ApiAccess:deleteClaim")]
        public async Task<IActionResult> DeleteClaim(ClaimDTO claimDTO)
        {
            var user = await _userManager.FindByIdAsync(claimDTO.UserId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            var claim = new System.Security.Claims.Claim(claimDTO.ClaimType, claimDTO.ClaimValue);
            var result = await _userManager.RemoveClaimAsync(user, claim);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok("Claim deleted successfully");
        }
    }
}
