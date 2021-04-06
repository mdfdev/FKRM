using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class _140001171 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_AcademicCalendars_AcademicCalendarId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Staffs_StaffId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_AcademicCalendarId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StaffId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "AcademicCalendarId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Enrollments");

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "Enrollments",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkedForId",
                table: "Enrollments",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "WorkedFors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    AcademicCalendarId = table.Column<Guid>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    SchoolId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkedFors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkedFors_AcademicCalendars_AcademicCalendarId",
                        column: x => x.AcademicCalendarId,
                        principalTable: "AcademicCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkedFors_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkedFors_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_WorkedForId",
                table: "Enrollments",
                column: "WorkedForId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkedFors_AcademicCalendarId",
                table: "WorkedFors",
                column: "AcademicCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkedFors_SchoolId",
                table: "WorkedFors",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkedFors_StaffId",
                table: "WorkedFors",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseId",
                table: "Enrollments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_WorkedFors_WorkedForId",
                table: "Enrollments",
                column: "WorkedForId",
                principalTable: "WorkedFors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_WorkedFors_WorkedForId",
                table: "Enrollments");

            migrationBuilder.DropTable(
                name: "WorkedFors");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_WorkedForId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "WorkedForId",
                table: "Enrollments");

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "Enrollments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "AcademicCalendarId",
                table: "Enrollments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StaffId",
                table: "Enrollments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_AcademicCalendarId",
                table: "Enrollments",
                column: "AcademicCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StaffId",
                table: "Enrollments",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_AcademicCalendars_AcademicCalendarId",
                table: "Enrollments",
                column: "AcademicCalendarId",
                principalTable: "AcademicCalendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseId",
                table: "Enrollments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Staffs_StaffId",
                table: "Enrollments",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
