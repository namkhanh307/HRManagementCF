using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class updatRole3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "219ef981-24c4-46f3-8af3-4f02a60c24ce", "f2f88ea9-b6f8-45e5-baf3-4bb046511d6e", "Human Resource", "HUMAN RESOURCE" },
                    { "cd00d9a7-1b4e-4fbf-9994-0d09ad3d8c7c", "7414bcfb-c386-4de1-8c1a-9f0539f60441", "Employee", "EMPLOYEE" },
                    { "cd81b725-2df5-4071-aab5-ff5c8458743d", "62c00438-ea52-4e52-9cba-160e9dfa3254", "Manager", "MANAGER" },
                    { "d0cec660-571f-4bb7-8f43-fba8a2ad53cd", "3ded83d1-f740-4c8d-8d13-4ea825ab1afe", "Warehouse staff", "WAREHOUSE STAFF" },
                    { "d21be099-17b3-42f7-bf19-45260fc84341", "79b1a364-b79e-4b64-944f-140b1f73aafe", "Accountant", "ACCOUNTANT" },
                    { "db3cfd05-2286-4f4e-9ed3-ee0c968b5aaa", "cea6a124-e023-4b22-9c4e-df19d4a6b1e2", "Administrator", "ADMINISTRATOR" },
                    { "f8db2e1a-6a85-40ff-b35b-5297f2f08de3", "33c82e2d-6df7-4caa-8945-ae9e647231e2", "Business Manager", "BUSINESS MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "219ef981-24c4-46f3-8af3-4f02a60c24ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd00d9a7-1b4e-4fbf-9994-0d09ad3d8c7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd81b725-2df5-4071-aab5-ff5c8458743d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cec660-571f-4bb7-8f43-fba8a2ad53cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d21be099-17b3-42f7-bf19-45260fc84341");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db3cfd05-2286-4f4e-9ed3-ee0c968b5aaa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8db2e1a-6a85-40ff-b35b-5297f2f08de3");

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
    }
}
