using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class _14000222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicCalendars",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    AcademicYear = table.Column<string>(nullable: false),
                    AcademicQuarter = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicCalendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcademicDegrees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicDegrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcademicMajors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicMajors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkingTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OUTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OUTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    BranchId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Areas_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PersonalCode = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    HiringDate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    JobTitleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    GenderId = table.Column<Guid>(nullable: false),
                    FeatureId = table.Column<Guid>(nullable: false),
                    OUTypeId = table.Column<Guid>(nullable: false),
                    UnitTypeId = table.Column<Guid>(nullable: false),
                    DistrictId = table.Column<Guid>(nullable: false),
                    SubsidiaryId = table.Column<Guid>(nullable: true),
                    BranchId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schools_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_OUTypes_OUTypeId",
                        column: x => x.OUTypeId,
                        principalTable: "OUTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_Schools_SubsidiaryId",
                        column: x => x.SubsidiaryId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_UnitTypes_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    AreaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaffEducationalBackgrounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    AcademicDegreeId = table.Column<Guid>(nullable: false),
                    AcademicMajorId = table.Column<Guid>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffEducationalBackgrounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffEducationalBackgrounds_AcademicDegrees_AcademicDegreeId",
                        column: x => x.AcademicDegreeId,
                        principalTable: "AcademicDegrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffEducationalBackgrounds_AcademicMajors_AcademicMajorId",
                        column: x => x.AcademicMajorId,
                        principalTable: "AcademicMajors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffEducationalBackgrounds_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    ComputerCode = table.Column<string>(nullable: true),
                    RequiredCredit = table.Column<int>(nullable: false),
                    OptionalElectiveCredit = table.Column<int>(nullable: false),
                    GraduationCredits = table.Column<int>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Majors_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Credits = table.Column<int>(nullable: false),
                    PassMark = table.Column<int>(nullable: false),
                    PracticalWeeklyHours = table.Column<int>(nullable: false),
                    TheoreticalWeeklyHours = table.Column<int>(nullable: false),
                    MajorId = table.Column<Guid>(nullable: false),
                    MarkingTypeId = table.Column<Guid>(nullable: false),
                    GradeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_Majors_MajorId",
                        column: x => x.MajorId,
                        principalTable: "Majors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_MarkingTypes_MarkingTypeId",
                        column: x => x.MarkingTypeId,
                        principalTable: "MarkingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    CourseId = table.Column<Guid>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    DayOfTheWeek = table.Column<int>(nullable: false),
                    StartTime = table.Column<int>(nullable: false),
                    During = table.Column<int>(nullable: false),
                    WorkedForId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollments_WorkedFors_WorkedForId",
                        column: x => x.WorkedForId,
                        principalTable: "WorkedFors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_BranchId",
                table: "Areas",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_GradeId",
                table: "Courses",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_MajorId",
                table: "Courses",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_MarkingTypeId",
                table: "Courses",
                column: "MarkingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseId",
                table: "Enrollments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_WorkedForId",
                table: "Enrollments",
                column: "WorkedForId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_AreaId",
                table: "Groups",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Majors_GroupId",
                table: "Majors",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_BranchId",
                table: "Schools",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_DistrictId",
                table: "Schools",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_FeatureId",
                table: "Schools",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_GenderId",
                table: "Schools",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_OUTypeId",
                table: "Schools",
                column: "OUTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_SubsidiaryId",
                table: "Schools",
                column: "SubsidiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_UnitTypeId",
                table: "Schools",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffEducationalBackgrounds_AcademicDegreeId",
                table: "StaffEducationalBackgrounds",
                column: "AcademicDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffEducationalBackgrounds_AcademicMajorId",
                table: "StaffEducationalBackgrounds",
                column: "AcademicMajorId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffEducationalBackgrounds_StaffId",
                table: "StaffEducationalBackgrounds",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_JobTitleId",
                table: "Staffs",
                column: "JobTitleId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "StaffEducationalBackgrounds");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "WorkedFors");

            migrationBuilder.DropTable(
                name: "AcademicDegrees");

            migrationBuilder.DropTable(
                name: "AcademicMajors");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Majors");

            migrationBuilder.DropTable(
                name: "MarkingTypes");

            migrationBuilder.DropTable(
                name: "AcademicCalendars");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "OUTypes");

            migrationBuilder.DropTable(
                name: "UnitTypes");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
