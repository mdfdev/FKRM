using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class BaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "UnitTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "UnitTypes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "UnitTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Staffs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Staffs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Schools",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Schools",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Schools",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Schedules",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Schedules",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Schedules",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Rooms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Rooms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "OUTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "OUTypes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "OUTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "MarkingTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "MarkingTypes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "MarkingTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Majors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Majors",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Majors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Groups",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Groups",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Groups",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Grades",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Grades",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Grades",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Genders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Genders",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Genders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Enrollments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Enrollments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Enrollments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Branches",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Branches",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Branches",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Areas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Areas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Areas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "AcademicCalendars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "AcademicCalendars",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "AcademicCalendars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_SchoolId",
                table: "Rooms",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Schools_SchoolId",
                table: "Rooms",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Schools_SchoolId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_SchoolId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "UnitTypes");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "UnitTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "UnitTypes");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "OUTypes");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "OUTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "OUTypes");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "MarkingTypes");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "MarkingTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MarkingTypes");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Majors");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Majors");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Majors");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "AcademicCalendars");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "AcademicCalendars");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AcademicCalendars");
        }
    }
}
