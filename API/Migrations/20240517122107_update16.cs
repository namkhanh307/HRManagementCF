using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class update16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Form_AspNetUsers_CustomUserId",
                table: "Form");

            migrationBuilder.RenameColumn(
                name: "DayQuatity",
                table: "FormType",
                newName: "DayQuantity");

            migrationBuilder.RenameColumn(
                name: "CustomUserId",
                table: "Form",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Form_CustomUserId",
                table: "Form",
                newName: "IX_Form_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Form_AspNetUsers_UserId",
                table: "Form",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Form_AspNetUsers_UserId",
                table: "Form");

            migrationBuilder.RenameColumn(
                name: "DayQuantity",
                table: "FormType",
                newName: "DayQuatity");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Form",
                newName: "CustomUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Form_UserId",
                table: "Form",
                newName: "IX_Form_CustomUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Form_AspNetUsers_CustomUserId",
                table: "Form",
                column: "CustomUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
