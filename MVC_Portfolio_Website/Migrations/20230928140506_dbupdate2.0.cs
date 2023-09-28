using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Portfolio_Website.Migrations
{
    /// <inheritdoc />
    public partial class dbupdate20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsToggled",
                table: "Estates",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsToggled",
                table: "Estates");
        }
    }
}
