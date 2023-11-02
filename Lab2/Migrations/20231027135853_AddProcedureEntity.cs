using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class AddProcedureEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Clients",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    ProcedureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.ProcedureId);
                    table.ForeignKey(
                        name: "FK_Procedures_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CategoryId",
                table: "Clients",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_CategoryId",
                table: "Procedures",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Categories_CategoryId",
                table: "Clients",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Categories_CategoryId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropIndex(
                name: "IX_Clients_CategoryId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Clients");
        }
    }
}
