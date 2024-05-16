using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class updat5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b7194cb-e9f2-4796-a65e-d2629d82d709");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "732fe160-6fad-412c-8f25-6fb953e6fea3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a63b57e-426c-4c25-ba34-fd7cadd2af36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaca5db7-b82e-448d-bb30-49bd3ade6057");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac7db71b-5cfe-4b72-b108-7de3facde477");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae5de405-db80-498b-a07d-0e63a678a7f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3ba2d5a-169f-4e1a-9beb-5edeb517e86f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7540faf-07f4-442d-ba30-721bfb57a723");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2b7194cb-e9f2-4796-a65e-d2629d82d709", "84cf86b2-3c8d-4dc1-bd1d-e88c6c2681f4", "Human Resource", "HUMAN RESOURCE" },
                    { "732fe160-6fad-412c-8f25-6fb953e6fea3", "10f46a9c-b540-4d3f-b18c-839173c571c3", "Warehouse staff", "WAREHOUSE STAFF" },
                    { "9a63b57e-426c-4c25-ba34-fd7cadd2af36", "791ecc27-d744-4204-adfb-8ef16cca6d8f", "Data Analyst", "DATA ANALYST" },
                    { "aaca5db7-b82e-448d-bb30-49bd3ade6057", "b2a66268-bcde-4e36-992b-68437d593c93", "Accountant", "ACCOUNTANT" },
                    { "ac7db71b-5cfe-4b72-b108-7de3facde477", "3d6be155-bd31-4036-a378-dacf6c331abe", "Administrator", "ADMINISTRATOR" },
                    { "ae5de405-db80-498b-a07d-0e63a678a7f7", "3a967ed9-39b2-4d11-8a2a-6b6641c18a5c", "Business Manager", "BUSINESS MANAGER" },
                    { "e3ba2d5a-169f-4e1a-9beb-5edeb517e86f", "7f3b1354-7de1-4672-9b13-4691d046a21b", "Employee", "EMPLOYEE" },
                    { "f7540faf-07f4-442d-ba30-721bfb57a723", "e0c28da5-e20b-4691-bda8-7c436e38247f", "Manager", "MANAGER" }
                });
        }
    }
}
