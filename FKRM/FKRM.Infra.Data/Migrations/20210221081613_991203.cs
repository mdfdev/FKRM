using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class _991203 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Staffs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Staffs");
        }
    }
}
