using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class Addnewmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GraduationCredits",
                table: "Majors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarkingTypeId",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AcademicCalendars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicYear = table.Column<string>(nullable: true),
                    AcademicQuarter = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicCalendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfTheWeek = table.Column<int>(nullable: false),
                    StartTime = table.Column<int>(nullable: false),
                    EndTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(nullable: true),
                    CourseId = table.Column<int>(nullable: true),
                    RoomId = table.Column<int>(nullable: true),
                    Capacity = table.Column<int>(nullable: false),
                    AcademicCalendarId = table.Column<int>(nullable: true),
                    ScheduleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollments_AcademicCalendars_AcademicCalendarId",
                        column: x => x.AcademicCalendarId,
                        principalTable: "AcademicCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollments_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollments_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollments_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_GradeId",
                table: "Courses",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_MarkingTypeId",
                table: "Courses",
                column: "MarkingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_AcademicCalendarId",
                table: "Enrollments",
                column: "AcademicCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseId",
                table: "Enrollments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_RoomId",
                table: "Enrollments",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_ScheduleId",
                table: "Enrollments",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StaffId",
                table: "Enrollments",
                column: "StaffId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Grades_GradeId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_MarkingTypes_MarkingTypeId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "MarkingTypes");

            migrationBuilder.DropTable(
                name: "AcademicCalendars");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Courses_GradeId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_MarkingTypeId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "GraduationCredits",
                table: "Majors");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "MarkingTypeId",
                table: "Courses");
        }
    }
}
