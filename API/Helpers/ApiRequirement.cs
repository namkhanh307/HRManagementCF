using Microsoft.AspNetCore.Authorization;

namespace API.Helpers
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
