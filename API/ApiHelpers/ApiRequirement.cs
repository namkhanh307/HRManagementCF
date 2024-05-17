using Microsoft.AspNetCore.Authorization;

namespace API.ApiHelpers
{
    public class ApiRequirement : IAuthorizationRequirement
    {
        public string ApiName { get; }

        public ApiRequirement(string apiName)
        {
            ApiName = apiName;
        }
    }
}
