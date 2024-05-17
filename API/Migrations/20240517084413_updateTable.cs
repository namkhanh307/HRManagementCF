using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class updateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0de3d1d8-a096-43a5-85ce-398c3086c792");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "183dbae6-98f8-4229-8131-2c5a6c2b5b17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3844899d-e684-44ea-91cd-7d31f22cbca5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392483a7-a43f-487d-8e60-8a943763c955");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "416b664c-c28d-4b8e-ae04-4f56067f0816");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62c12858-c816-4b4c-96a4-767dc4c95696");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83434f1e-0b52-409b-a1da-7653d25e1aa7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95a36479-8141-4504-bf5a-1200e761bbdc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca0b5829-c6fd-4adb-907e-732228192990");

            migrationBuilder.CreateTable(
                name: "FormType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FixedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salary_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormTypeId = table.Column<int>(type: "int", nullable: false),
                    CustomUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Form_AspNetUsers_CustomUserId",
                        column: x => x.CustomUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Form_FormType_FormTypeId",
                        column: x => x.FormTypeId,
                        principalTable: "FormType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Form_CustomUserId",
                table: "Form",
                column: "CustomUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Form_FormTypeId",
                table: "Form",
                column: "FormTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_UserId",
                table: "Salary",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Form");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "FormType");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0de3d1d8-a096-43a5-85ce-398c3086c792", "28fd69ac-bc5b-47b7-9be1-a01e170fd26d", "D E", "D E" },
                    { "183dbae6-98f8-4229-8131-2c5a6c2b5b17", "56257fcc-edb5-4b41-9b15-36c24305067d", "Business Manager", "BUSINESS MANAGER" },
                    { "3844899d-e684-44ea-91cd-7d31f22cbca5", "e2149212-8d1e-420b-a8d6-83c76aeff3a1", "Manager", "MANAGER" },
                    { "392483a7-a43f-487d-8e60-8a943763c955", "9aab6b70-cfe6-406e-8638-8bd6b286e9c3", "Data Analyst", "DATA ANALYST" },
                    { "416b664c-c28d-4b8e-ae04-4f56067f0816", "cd291273-6f62-4710-80a5-63b788111941", "Warehouse staff", "WAREHOUSE STAFF" },
                    { "62c12858-c816-4b4c-96a4-767dc4c95696", "3ccbd39f-4f7e-4f17-9aa3-64f86dda351b", "Accountant", "ACCOUNTANT" },
                    { "83434f1e-0b52-409b-a1da-7653d25e1aa7", "353defb1-0d1d-4645-b3d6-0d270dc2254c", "Employee", "EMPLOYEE" },
                    { "95a36479-8141-4504-bf5a-1200e761bbdc", "0ba7c8a5-71e8-4d29-833a-b983524aea0d", "Human Resource", "HUMAN RESOURCE" },
                    { "ca0b5829-c6fd-4adb-907e-732228192990", "dd12a0c6-458a-4122-9820-9179034dbcb1", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
