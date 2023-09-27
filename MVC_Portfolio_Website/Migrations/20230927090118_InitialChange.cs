using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Portfolio_Website.Migrations
{
    /// <inheritdoc />
    public partial class InitialChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Estates",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Estates");
        }
    }
}
