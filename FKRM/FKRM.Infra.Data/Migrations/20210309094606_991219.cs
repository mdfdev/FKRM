using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class _991219 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Majors_MajorId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Majors_Groups_GroupId",
                table: "Majors");

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupId",
                table: "Majors",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MajorId",
                table: "Courses",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Majors_MajorId",
                table: "Courses",
                column: "MajorId",
                principalTable: "Majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Majors_Groups_GroupId",
                table: "Majors",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Majors_MajorId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Majors_Groups_GroupId",
                table: "Majors");

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupId",
                table: "Majors",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "MajorId",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Majors_MajorId",
                table: "Courses",
                column: "MajorId",
                principalTable: "Majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Majors_Groups_GroupId",
                table: "Majors",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
