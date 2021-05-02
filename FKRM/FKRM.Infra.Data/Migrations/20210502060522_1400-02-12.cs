using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class _14000212 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SubsidiaryId",
                table: "Schools",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schools_SubsidiaryId",
                table: "Schools",
                column: "SubsidiaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Schools_SubsidiaryId",
                table: "Schools",
                column: "SubsidiaryId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Schools_SubsidiaryId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_SubsidiaryId",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "SubsidiaryId",
                table: "Schools");
        }
    }
}
