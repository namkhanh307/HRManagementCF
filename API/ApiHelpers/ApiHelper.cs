
namespace API.ApiHelpers
{
    public static class ApiHelper
    {
        public static List<string> GetApiNames()
        {
            return new List<string>
            {
                //claimController
                "getAllClaims",
                "addClaim",
                "updateClaim",
                "deleteClaim",
                //formController
                "getUserForms",
                "submitForm",
                //registrationController
                "signInAuth",
                //roleController
                "getAllRoles",
                "addRole",
                "updateRole",
                //salaryController
                "getAllSalaries",
                "getSalaryByUserId",
                "addSalary",
                "updateSalary",
                "deleteSalary",
                //userController
                "getAllUsers",
                "getUserByUserName",
                "addUser",
                "updateUser",
                "deleteUser",
            };
        }
    }

}
