using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class RoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
