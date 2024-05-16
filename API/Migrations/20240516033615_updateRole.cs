using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class updateRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10e6d842-921e-4315-a7a4-ceea6302da16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0057aa7-7fed-4b2c-99a5-e0cf22130a52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecb945a9-bce2-4130-8f4e-13c7517a2dd1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ede734f-3d1c-40c6-9dc3-293a70d139a1", "aafa273f-afc1-4774-9d8f-78560851efea", "Khanh", "KHANH" },
                    { "286f7c12-4b50-4883-9eef-f3de6451a5e3", "7ff34e11-db65-4850-a489-df2de1cf70ce", "Human Resource", "HUMAN RESOURCE" },
                    { "2f7b46e2-2538-4a78-8b62-2680ff40e342", "157512a1-5f81-4e2c-8b59-461243bd6f42", "Accountant", "ACCOUNTANT" },
                    { "8e3e2de7-97d5-4a6d-9416-3536926bb684", "4292ffbf-35d6-4fb5-ab26-3e858542941c", "Employee", "EMPLOYEE" },
                    { "b91147c9-2a8f-4c12-aaf6-6de98fc6bf86", "8c6a29e2-4ff8-452c-94cd-53103285cf52", "Warehouse staff", "WAREHOUSE STAFF" },
                    { "dd3229dc-824e-4df9-96a4-ac4f750039f8", "df6ef1ff-6365-4ce2-aa2f-f70ef144120e", "Administrator", "ADMINISTRATOR" },
                    { "fdd7f0cf-83ea-4352-8b67-97e489418346", "b0df0c10-9152-4e75-8943-59d9662aad5e", "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ede734f-3d1c-40c6-9dc3-293a70d139a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "286f7c12-4b50-4883-9eef-f3de6451a5e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f7b46e2-2538-4a78-8b62-2680ff40e342");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e3e2de7-97d5-4a6d-9416-3536926bb684");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b91147c9-2a8f-4c12-aaf6-6de98fc6bf86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd3229dc-824e-4df9-96a4-ac4f750039f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdd7f0cf-83ea-4352-8b67-97e489418346");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10e6d842-921e-4315-a7a4-ceea6302da16", "1", "Admin", "Admin" },
                    { "b0057aa7-7fed-4b2c-99a5-e0cf22130a52", "3", "HR", "HR" },
                    { "ecb945a9-bce2-4130-8f4e-13c7517a2dd1", "2", "User", "User" }
                });
        }
    }
}
