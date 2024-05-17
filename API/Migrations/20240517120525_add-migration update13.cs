using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationupdate13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            IF EXISTS (SELECT 1 
                       FROM sys.foreign_keys 
                       WHERE name = 'FK_Form_AspNetUsers_CustomUserId')
            BEGIN
                ALTER TABLE [Form] DROP CONSTRAINT [FK_Form_AspNetUsers_CustomUserId];
            END
        ");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
