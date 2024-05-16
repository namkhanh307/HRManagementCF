﻿using Microsoft.AspNetCore.Authorization;

namespace API.Helpers
{
    public class ApiAuthorizationHandler : AuthorizationHandler<ApiRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ApiRequirement requirement)
        {
            // Check if the user has the required claim
            if (context.User.HasClaim(c => c.Type == "api" && c.Value == requirement.ApiName))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
