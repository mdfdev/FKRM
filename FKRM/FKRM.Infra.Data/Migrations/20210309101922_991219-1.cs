using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class _9912191 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Grades_GradeId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_MarkingTypes_MarkingTypeId",
                table: "Courses");

            migrationBuilder.AlterColumn<Guid>(
                name: "MarkingTypeId",
                table: "Courses",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GradeId",
                table: "Courses",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Grades_GradeId",
                table: "Courses",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_MarkingTypes_MarkingTypeId",
                table: "Courses",
                column: "MarkingTypeId",
                principalTable: "MarkingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Grades_GradeId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_MarkingTypes_MarkingTypeId",
                table: "Courses");

            migrationBuilder.AlterColumn<Guid>(
                name: "MarkingTypeId",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "GradeId",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Grades_GradeId",
                table: "Courses",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_MarkingTypes_MarkingTypeId",
                table: "Courses",
                column: "MarkingTypeId",
                principalTable: "MarkingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
