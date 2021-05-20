using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class _1400022 : Migration
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

            migrationBuilder.InsertData(
                table: "AcademicCalendars",
                columns: new[] { "Id", "AcademicQuarter", "AcademicYear", "AddedDate", "IPAddress", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("8e023969-c12e-490d-8fe0-8a2e808ae136"), "ضمن سال", "99-1400", new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(6300), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4bca8e79-e904-4560-a8e4-51cc655417fb"), "ضمن سال", "1400-99", new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(7229), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AcademicDegrees",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("2dac1281-ec3f-40da-bd2f-64b340af17f5"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(3325), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زیر دیپلم" },
                    { new Guid("08e61b73-17ea-4e9c-a929-ba20480d7ff7"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(3826), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دیپلم" },
                    { new Guid("c2fc79cd-7c54-48b2-b4e8-dc8e82a3fadd"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(3853), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کاردانی" },
                    { new Guid("ba46d1f5-a720-4759-a631-3855a0cd3583"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(3867), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کارشناسی" },
                    { new Guid("37ae7e84-fbdc-47ee-a737-67f3cfa92291"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(3900), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کارشناسی ارشد" },
                    { new Guid("d28c1064-c003-4e72-943e-7099893fd7c6"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(3914), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دکترا" }
                });

            migrationBuilder.InsertData(
                table: "AcademicMajors",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("b7b60c4d-a4c6-40d8-9903-6ff51f1310c7"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5393), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی معماری" },
                    { new Guid("89f93d2e-55c0-47ec-b3a7-89b81b0630c0"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5406), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "معماری" },
                    { new Guid("c0a41281-b4b1-4e3d-a739-bc1ee3521534"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5419), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "معماری داخلی" },
                    { new Guid("838f907f-fabe-4cb1-a2e9-c45dde98f6a9"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5431), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "فناوری نانو" },
                    { new Guid("8b1f1fbc-9e68-43fc-8e24-b66e9d6c2346"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5444), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی برق" },
                    { new Guid("04a9fd03-a373-4235-84e8-d9b5e8bcc7f7"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5470), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی پزشکی" },
                    { new Guid("2601589d-a36b-4f96-9953-ddf8468f1255"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5522), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی متالورژی و مواد" },
                    { new Guid("d256c9b2-b7ee-4891-9091-c9567f9f21d1"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5496), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی عمران" },
                    { new Guid("8ed810b2-0194-4317-9779-11eef926c6f7"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5510), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی مواد" },
                    { new Guid("ab8e6929-fa3a-487f-bf8e-0d26ada4e8d8"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5381), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدیریت بازرگانی" },
                    { new Guid("c61454c5-6dc7-45e7-a529-97852ee854cf"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5535), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عکاسی" },
                    { new Guid("c7fd5e7b-bb15-433d-8a2a-f15b0ea9d29c"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5548), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "هنرهای تجسمی" },
                    { new Guid("06d94a44-1bb7-43a2-8304-3216ef0a8de5"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5561), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نقاشی" },
                    { new Guid("d41f615d-c01e-43ad-ba1e-c2616b14fb63"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5483), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی فناوری اطلاعات" },
                    { new Guid("896b2d25-1490-4572-aada-824d68966f77"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5368), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدیریت آموزشی" },
                    { new Guid("c7535d97-60dc-456b-9e43-4b3e23b2ce48"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5301), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نانوشیمی" },
                    { new Guid("723b7fc6-0316-45dc-8148-74c7bc12d5e0"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5328), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدیریت دولتی" },
                    { new Guid("e74c9549-a0c9-4cc3-8185-a46b6c9980db"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5314), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کارآفرینی" },
                    { new Guid("a466ffa5-fe97-4790-8a32-c6b29bf7f8b5"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5587), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ارتباط تصویری" },
                    { new Guid("290392c8-41a4-48d8-800b-511c20311a17"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5287), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زیست‌فناوری" },
                    { new Guid("e2cb3c48-04c9-4c6b-83f0-29443aabdc43"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5273), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "بیوتکنولوژی" },
                    { new Guid("e9d53532-3cc0-4199-b02b-7ef2ad7b25bf"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5260), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی مکانیک" },
                    { new Guid("abe390a6-2565-45fe-a169-561d77025236"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5246), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی صنایع" },
                    { new Guid("9ce02389-83a3-49d2-80c1-b76e1f59e5fd"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5232), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی شیمی" },
                    { new Guid("2299186c-7b23-4447-b01d-98183c5649ee"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5201), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی نفت" },
                    { new Guid("08947126-1b12-44f5-9ded-0f222ef67464"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5188), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زبان و ادبیات فارسی" },
                    { new Guid("c1efa639-04e8-490c-8807-8bd164b2ad36"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5174), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "حسابداری" },
                    { new Guid("ff6cac6a-3dc6-40c4-8daf-2d7b038d6f4f"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5160), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی معماری" },
                    { new Guid("bb1722d8-709d-4ab7-b773-98e5186cc08f"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5130), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "علوم كامپیوتر" },
                    { new Guid("12cf44ee-218f-40b3-95c1-0974912cb7fc"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(4633), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی شهرسازی" },
                    { new Guid("02a1b97a-ed00-4ebf-82d9-88cf626098ce"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(5355), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدیریت فناوری اطلاعات" }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("63348c4c-5f4a-42ed-99a3-3dde1345fb85"), new DateTime(2021, 5, 19, 13, 41, 15, 193, DateTimeKind.Local).AddTicks(8506), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نظری" },
                    { new Guid("9d44a511-4591-4c85-885e-4908bf79f550"), new DateTime(2021, 5, 19, 13, 41, 15, 193, DateTimeKind.Local).AddTicks(8443), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کاردانش" },
                    { new Guid("e360b088-509c-4cfe-b2b2-4e702e037942"), new DateTime(2021, 5, 19, 13, 41, 15, 190, DateTimeKind.Local).AddTicks(4773), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "فنی و حرفه ای" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("bbe3a395-c4fe-4991-81c6-6d45b9eb6c13"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4686), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "فراهان" },
                    { new Guid("02eb9329-8813-41f5-95f1-fbf472786c06"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4673), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ساوه" },
                    { new Guid("9317c6c1-eb53-4513-b434-2130aa2e3381"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4660), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زرندیه" },
                    { new Guid("0eec2fb5-fa09-4298-a4fc-119bfdb529d9"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4647), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نوبران" },
                    { new Guid("37594e6c-7f8a-4695-8635-c07d0ba2e696"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4634), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "شازند" },
                    { new Guid("346dde6a-f131-4749-8323-84ac9aa666f2"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4594), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دلیجان" },
                    { new Guid("29c29d38-578b-4b88-81f3-c7acd1051ca3"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4581), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کمیجان" },
                    { new Guid("89b049e0-20e7-42fd-8297-a04f50b0c1d9"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4607), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "محلات" },
                    { new Guid("48c9ad45-c315-4b53-ae0d-741a704e9403"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4554), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "خنداب" },
                    { new Guid("5a9591c1-c40f-4bc8-bca8-c715fa72e502"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4541), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "خمین" },
                    { new Guid("8efd621b-4f92-4880-be94-cbfec4b0ac84"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4527), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تفرش" },
                    { new Guid("aaa36b5b-a27b-4e39-898c-1a96ddf876b8"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4512), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "آشتیان" },
                    { new Guid("333ab799-531b-4df3-be73-a5bb1d7b93cf"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4444), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ناحیه 2" },
                    { new Guid("e3f1a4fc-f1bd-451f-8c6c-43fadefad80b"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(3702), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ناحیه 1" },
                    { new Guid("4c94d093-ed06-40e2-8d2b-e2bd3531d288"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(4567), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "سربند" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("e4091bed-8a79-46b4-b054-3be9b170cc71"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(678), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "هیأت امنایی" },
                    { new Guid("dda9eedb-3c37-4cd4-86d1-369959295e70"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(1183), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "شبانه روزی" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("a628cd1f-1360-411f-94b5-ea8d1af3a7c3"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(2891), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مرد" },
                    { new Guid("42232a37-3dbd-49f3-9572-f149d8ebbfba"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(2264), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زن" }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("3113f870-91dc-49fa-84f0-f30161176061"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(7330), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دوازدهم" },
                    { new Guid("f09cca12-76eb-4766-a144-d7a0eee02a5e"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(6771), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دهم" },
                    { new Guid("8c73ebab-ae10-4262-969b-028427680a38"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(7300), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "یازدهم" }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { new Guid("77bb823c-9d69-4be7-8799-17599838ac53"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(8044), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "هنرآموز" },
                    { new Guid("bfc13661-2958-4813-9666-17152e621273"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(8565), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "استادکار" },
                    { new Guid("8dbcdd47-7112-4d7b-8081-e219562a0730"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(8595), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدیر" },
                    { new Guid("153cc9bc-ed8c-483d-975d-fca2fc387eb8"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(8609), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "معاون فنی" },
                    { new Guid("0441dcaa-9038-49e4-a920-90b03430ea72"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(8622), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "معاون آموزشی" },
                    { new Guid("2ad5496a-d1c6-4ccb-8236-a419880295fe"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(8654), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انباردار" },
                    { new Guid("01977506-c9f1-4bcc-bdc9-8db6349f267e"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(8669), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "سرپرست بخش" }
                });

            migrationBuilder.InsertData(
                table: "MarkingTypes",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ca8182b7-96c2-4852-8f1e-2a0b04aa4fee"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(6004), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دو نمره ای" },
                    { new Guid("54de46ca-9a1e-4521-a38b-076c8521cc82"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(6032), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "چهار نمره ای" },
                    { new Guid("15ef34be-fac5-469a-9a48-cf09ae8626ec"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(5460), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "یک نمره ای" }
                });

            migrationBuilder.InsertData(
                table: "OUTypes",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("196b3413-dcd2-45e4-b68e-474303f758f3"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(9378), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "استعدادهای درخشان" },
                    { new Guid("007ee8af-87df-4446-b023-79fb6a50dae6"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(9885), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "شاهد" },
                    { new Guid("12a67618-6c3e-448c-9b8c-4cd1a2c1fb4f"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(9914), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عادی" },
                    { new Guid("4edee1a3-28ae-41d5-b170-9abd234605d8"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(9930), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عام المنفعه" },
                    { new Guid("15d49346-84ae-467d-8df3-d5f69697b9bc"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(9943), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نمونه دولتی" },
                    { new Guid("280b6159-60d1-439c-b52c-a499a57e7e9f"), new DateTime(2021, 5, 19, 13, 41, 15, 195, DateTimeKind.Local).AddTicks(9957), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "وابسته" }
                });

            migrationBuilder.InsertData(
                table: "UnitTypes",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("faecb50b-5ff9-402d-b62b-fa2275397690"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(2019), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دولتی" },
                    { new Guid("eca49ac3-ad3f-422e-beba-94b84867a7ce"), new DateTime(2021, 5, 19, 13, 41, 15, 196, DateTimeKind.Local).AddTicks(2533), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "غیردولتی" }
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
