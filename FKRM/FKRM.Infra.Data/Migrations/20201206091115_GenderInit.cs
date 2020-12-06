using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class GenderInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "schools",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_schools_GenderId",
                table: "schools",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_schools_genders_GenderId",
                table: "schools",
                column: "GenderId",
                principalTable: "genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schools_genders_GenderId",
                table: "schools");

            migrationBuilder.DropTable(
                name: "genders");

            migrationBuilder.DropIndex(
                name: "IX_schools_GenderId",
                table: "schools");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "schools");
        }
    }
}
