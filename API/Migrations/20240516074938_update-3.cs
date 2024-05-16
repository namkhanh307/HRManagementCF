using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
