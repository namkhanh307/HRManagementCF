using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class update9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07878695-a7c5-4552-8537-b171d38e9e27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a3041c8-95a6-4dc4-9750-878f77cee330");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2119d1c1-d4ea-4259-8b35-f1449e5378f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c7982dd-f43c-4052-9626-54a4b314c390");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99ece520-c03b-44c3-8582-2bd5f86077b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9df256c3-2865-41d0-80e2-8865d4b77e62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d332a88b-0e24-42ec-8381-b2baad72711f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed623b08-59a0-4576-8016-d02d5ad205dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f91e8084-874d-4ac1-ac4c-e3e1313adced");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04809625-bdf4-4cdf-b86e-acf641637272", "d10bb31b-66f9-423c-8594-fcd286926cdd", "Data Analyst", "DATA ANALYST" },
                    { "699d7a14-8f74-4b56-b2c1-7f53afb0bdd1", "512f59b8-b515-4ad0-8017-325427944b74", "Business Manager", "BUSINESS MANAGER" },
                    { "7771033a-f540-4d67-926e-448bd5cc9253", "17c0813f-ef86-4c37-9cca-5f99fa968426", "Employee", "EMPLOYEE" },
                    { "8d6686cc-8ab4-437f-9902-76b4bd78d64e", "694b9cae-8654-4321-adfc-c1dda6f898e2", "Manager", "MANAGER" },
                    { "96547622-aeea-49cb-b4c8-cb50d3b20166", "7ee296ed-5494-436b-83d4-04cba8ae2234", "Warehouse staff", "WAREHOUSE STAFF" },
                    { "96f3e100-3d6e-46a2-8568-5d4a22f49541", "78962ec9-9796-4b90-a7cc-a42ee5d206df", "Human Resource", "HUMAN RESOURCE" },
                    { "a4936f25-7f4f-4e49-a01c-453c8c69dfeb", "65e97024-e5b3-4b82-b8fc-cb10ef4f15a6", "Administrator", "ADMINISTRATOR" },
                    { "a55c52e0-2bbe-4bab-9115-8fec6691af30", "14b398bb-c3c1-41ac-8bfb-9204b1962b52", "Accountant", "ACCOUNTANT" },
                    { "c83a61a0-af35-4021-90dd-8380f4f4a87c", "1e642819-aaf3-462b-bbf9-0276481f5ec8", "D E", "D E" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04809625-bdf4-4cdf-b86e-acf641637272");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "699d7a14-8f74-4b56-b2c1-7f53afb0bdd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7771033a-f540-4d67-926e-448bd5cc9253");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d6686cc-8ab4-437f-9902-76b4bd78d64e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96547622-aeea-49cb-b4c8-cb50d3b20166");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96f3e100-3d6e-46a2-8568-5d4a22f49541");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4936f25-7f4f-4e49-a01c-453c8c69dfeb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a55c52e0-2bbe-4bab-9115-8fec6691af30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c83a61a0-af35-4021-90dd-8380f4f4a87c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07878695-a7c5-4552-8537-b171d38e9e27", "3c3d3c9a-48d5-42a6-9b28-47130b573495", "Khanhdepzai", "KHANHDEPZAI" },
                    { "1a3041c8-95a6-4dc4-9750-878f77cee330", "c554e7eb-00f4-4a5a-b057-d3361941fd66", "Employee", "EMPLOYEE" },
                    { "2119d1c1-d4ea-4259-8b35-f1449e5378f6", "0e40e5d8-7589-4d39-8ebe-a12073f44fea", "Data Analyst", "DATA ANALYST" },
                    { "2c7982dd-f43c-4052-9626-54a4b314c390", "0fbf2f17-9c04-4137-971c-f8c3f0e4de98", "Human Resource", "HUMAN RESOURCE" },
                    { "99ece520-c03b-44c3-8582-2bd5f86077b1", "589c6007-6b9e-4b0f-af8d-af8225ff6963", "Accountant", "ACCOUNTANT" },
                    { "9df256c3-2865-41d0-80e2-8865d4b77e62", "99c4c3bf-98a9-4fc3-8fe0-2266931854d1", "Business Manager", "BUSINESS MANAGER" },
                    { "d332a88b-0e24-42ec-8381-b2baad72711f", "19e3fc0b-b8b2-4fa0-a80a-332f53e79b52", "Manager", "MANAGER" },
                    { "ed623b08-59a0-4576-8016-d02d5ad205dc", "7be8c96c-a0a0-440e-806c-cb62e869c3c1", "Warehouse staff", "WAREHOUSE STAFF" },
                    { "f91e8084-874d-4ac1-ac4c-e3e1313adced", "bf6808c5-a9c6-414b-86d2-e463ba832648", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
