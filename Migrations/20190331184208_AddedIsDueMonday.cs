using Microsoft.EntityFrameworkCore.Migrations;

namespace twolistapi.Migrations
{
    public partial class AddedIsDueMonday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDueToday",
                table: "Lists",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDueToday",
                table: "Lists");
        }
    }
}
