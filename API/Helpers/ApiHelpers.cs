namespace API.Helpers
{
    public static class ApiHelper
    {
        public static List<string> GetApiNames()
        {
            return new List<string>
        {
            ApiNames.AddRole,
            ApiNames.DeleteUser,
            // Add more API names as needed
        };
        }
    }

}
