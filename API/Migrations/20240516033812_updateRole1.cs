using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class updateRole1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "05afb19a-65a1-4810-b4ee-369500c910ba", "1a664564-9bd1-4a89-9d17-18b21dc2bfa4", "Administrator", "ADMINISTRATOR" },
                    { "0f112743-dbcf-41da-8652-954646a23444", "25b5348d-a731-46be-aa06-6f8774e36e2f", "Manager", "MANAGER" },
                    { "1dc1e618-a945-41dd-99ec-eac422fc7c8d", "7abb3ef1-e047-44e6-ac0c-d6c122462b78", "Business Manager", "BUSINESS MANAGER" },
                    { "52607727-924c-4c33-92c7-811c1e68dbee", "7ec42de1-53c9-4150-afeb-0dd28c7c87fe", "Employee", "EMPLOYEE" },
                    { "835d7fec-dbe5-4fde-bd6c-d8bdc318ae31", "0b5fb501-0e74-4372-a356-46c217a8de04", "Khanh", "KHANH" },
                    { "dfc7a3f0-612a-40b8-b1a4-8c075bace5a3", "141f6807-be5e-4bad-a02a-942da145f4d3", "Human Resource", "HUMAN RESOURCE" },
                    { "ea3f2379-dac1-4ad3-9efb-258f743b0471", "9e6e602d-bc8f-4ec3-80f2-bf2a7ccfd707", "Accountant", "ACCOUNTANT" },
                    { "f536e147-78b7-4744-83b6-8fb54926622a", "a974e298-cdf3-47f1-82b2-712c573e879a", "Warehouse staff", "WAREHOUSE STAFF" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05afb19a-65a1-4810-b4ee-369500c910ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f112743-dbcf-41da-8652-954646a23444");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dc1e618-a945-41dd-99ec-eac422fc7c8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52607727-924c-4c33-92c7-811c1e68dbee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835d7fec-dbe5-4fde-bd6c-d8bdc318ae31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfc7a3f0-612a-40b8-b1a4-8c075bace5a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3f2379-dac1-4ad3-9efb-258f743b0471");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f536e147-78b7-4744-83b6-8fb54926622a");

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
    }
}
