using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChistoDB.Migrations
{
    /// <inheritdoc />
    public partial class IsMechFieldInRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMech",
                table: "Roles",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMech",
                table: "Roles");
        }
    }
}
