using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class update17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Form_AspNetUsers_UserId",
                table: "Form");

            migrationBuilder.DropForeignKey(
                name: "FK_Form_FormType_FormTypeId",
                table: "Form");

            migrationBuilder.DropForeignKey(
                name: "FK_Salary_AspNetUsers_UserId",
                table: "Salary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salary",
                table: "Salary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormType",
                table: "FormType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Form",
                table: "Form");

            migrationBuilder.RenameTable(
                name: "Salary",
                newName: "Salaries");

            migrationBuilder.RenameTable(
                name: "FormType",
                newName: "FormTypes");

            migrationBuilder.RenameTable(
                name: "Form",
                newName: "Forms");

            migrationBuilder.RenameIndex(
                name: "IX_Salary_UserId",
                table: "Salaries",
                newName: "IX_Salaries_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Form_UserId",
                table: "Forms",
                newName: "IX_Forms_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Form_FormTypeId",
                table: "Forms",
                newName: "IX_Forms_FormTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormTypes",
                table: "FormTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forms",
                table: "Forms",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_AspNetUsers_UserId",
                table: "Forms",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_FormTypes_FormTypeId",
                table: "Forms",
                column: "FormTypeId",
                principalTable: "FormTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_AspNetUsers_UserId",
                table: "Salaries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_AspNetUsers_UserId",
                table: "Forms");

            migrationBuilder.DropForeignKey(
                name: "FK_Forms_FormTypes_FormTypeId",
                table: "Forms");

            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_AspNetUsers_UserId",
                table: "Salaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormTypes",
                table: "FormTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Forms",
                table: "Forms");

            migrationBuilder.RenameTable(
                name: "Salaries",
                newName: "Salary");

            migrationBuilder.RenameTable(
                name: "FormTypes",
                newName: "FormType");

            migrationBuilder.RenameTable(
                name: "Forms",
                newName: "Form");

            migrationBuilder.RenameIndex(
                name: "IX_Salaries_UserId",
                table: "Salary",
                newName: "IX_Salary_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Forms_UserId",
                table: "Form",
                newName: "IX_Form_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Forms_FormTypeId",
                table: "Form",
                newName: "IX_Form_FormTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salary",
                table: "Salary",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormType",
                table: "FormType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Form",
                table: "Form",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Form_AspNetUsers_UserId",
                table: "Form",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Form_FormType_FormTypeId",
                table: "Form",
                column: "FormTypeId",
                principalTable: "FormType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Salary_AspNetUsers_UserId",
                table: "Salary",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
