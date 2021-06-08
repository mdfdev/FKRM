using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Mvc.Migrations
{
    public partial class _14011 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                schema: "Identity",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                schema: "Identity",
                table: "User");
        }
    }
}
