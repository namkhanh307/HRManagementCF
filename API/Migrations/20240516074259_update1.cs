using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f127732-555a-446c-a987-dad47b20a26e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ee1a18c-3122-4515-b9b2-6c160d1b2e97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68ea6053-8c24-4460-abd4-23e4c8443422");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69f49931-afe1-4570-9bb6-06710da124d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "765ea604-510a-4c8e-bc20-d64b36abc240");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8340c7cb-fde0-4ae2-907e-2a019593fc04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86814055-2258-4d41-a45a-7a9a3f1f4fe0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cedcfe36-7024-4225-a0fe-f857385cc2ec");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f127732-555a-446c-a987-dad47b20a26e", "ef9440fb-0fb1-4e6d-8f37-44baa0616c54", "Human Resource", "HUMAN RESOURCE" },
                    { "4ee1a18c-3122-4515-b9b2-6c160d1b2e97", "40d0b6c3-719f-4e1e-84a0-d0a2cd930679", "Accountant", "ACCOUNTANT" },
                    { "68ea6053-8c24-4460-abd4-23e4c8443422", "6b12a3b6-1e82-44e2-8d98-421c4099863b", "Data Analyst", "DATA ANALYST" },
                    { "69f49931-afe1-4570-9bb6-06710da124d7", "19badff8-193a-4374-8745-39f701834195", "Employee", "EMPLOYEE" },
                    { "765ea604-510a-4c8e-bc20-d64b36abc240", "e3d0fbdb-27da-4b9d-9e9c-7fd9567042c9", "Manager", "MANAGER" },
                    { "8340c7cb-fde0-4ae2-907e-2a019593fc04", "be23560d-7bc3-455d-a903-85c45a6f816d", "Administrator", "ADMINISTRATOR" },
                    { "86814055-2258-4d41-a45a-7a9a3f1f4fe0", "bb3ff227-1b52-457c-9942-0f4dcd02d4e8", "Warehouse staff", "WAREHOUSE STAFF" },
                    { "cedcfe36-7024-4225-a0fe-f857385cc2ec", "4d8c0da5-9ee5-466a-955f-964d8fa331b1", "Business Manager", "BUSINESS MANAGER" }
                });
        }
    }
}
