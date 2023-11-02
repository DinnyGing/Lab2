using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class AddNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Masters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Clients",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Masters");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Clients");
        }
    }
}
