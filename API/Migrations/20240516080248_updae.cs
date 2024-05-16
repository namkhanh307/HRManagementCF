using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class updae : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
