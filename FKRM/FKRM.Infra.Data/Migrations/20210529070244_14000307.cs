using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class _14000307 : Migration
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
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    ParentNotificationId = table.Column<Guid>(nullable: true),
                    ExpiryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Notifications_ParentNotificationId",
                        column: x => x.ParentNotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "NotificationRecipients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    RecipientId = table.Column<Guid>(nullable: false),
                    RecipientGroupId = table.Column<Guid>(nullable: false),
                    NotificationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationRecipients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationRecipients_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
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
                    { new Guid("af6c38d9-b502-47a1-ab9a-26d872b1fa51"), "ضمن سال", "99-1400", new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(4400), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e90b7e2-ddfc-46e8-98c2-92ea5bb63bb4"), "ضمن سال", "1400-99", new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(5471), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AcademicDegrees",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("24ff36db-16cb-4ced-b896-2440e4e5b3bc"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(1341), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زیر دیپلم" },
                    { new Guid("a545012d-a63c-4cc7-b02d-8d2a0830a86b"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(1847), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دیپلم" },
                    { new Guid("0b39b879-b4de-4494-a96b-5d0b90c60797"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(1877), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کاردانی" },
                    { new Guid("2210e675-cba5-4c18-b328-6d3cd380ee33"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(1891), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کارشناسی" },
                    { new Guid("6adca930-06d0-4c77-be73-26fcfc9a4161"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(1904), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کارشناسی ارشد" },
                    { new Guid("c4026b08-2fc8-4815-a3b6-032a72b29815"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(1917), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دکترا" }
                });

            migrationBuilder.InsertData(
                table: "AcademicMajors",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("676b9ae9-f16c-4732-abca-897522faef7c"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3342), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی معماری" },
                    { new Guid("6ca57202-a95a-46e4-93d7-fac424f1e0b7"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3486), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "معماری" },
                    { new Guid("4d6cb932-5642-4fa6-94f3-16b1d4dd6478"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3515), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "معماری داخلی" },
                    { new Guid("b1cff67c-2100-4e93-be03-064a3c492508"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3528), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "فناوری نانو" },
                    { new Guid("d34df692-18ac-4de6-9903-0bd9b1de2a49"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3541), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی برق" },
                    { new Guid("2d2cb090-bb08-4bf6-b02e-55a4f2a4fe4f"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3553), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی پزشکی" },
                    { new Guid("7cb0e290-4d98-44ce-8782-755fcef2134e"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3605), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی متالورژی و مواد" },
                    { new Guid("415641a8-062d-41d7-9302-8e3fa9448eae"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3579), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی عمران" },
                    { new Guid("9318b539-8f2a-419f-ba68-325f6ca0e5f8"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3592), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی مواد" },
                    { new Guid("defd340e-4126-4384-9586-4acbef8fd16b"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3330), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدیریت بازرگانی" },
                    { new Guid("50eebb6c-bf78-4299-a943-9d849bfa37d8"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3631), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عکاسی" },
                    { new Guid("6631f747-1493-4794-80a4-f47a7230ac7a"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3644), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "هنرهای تجسمی" },
                    { new Guid("5a3ed057-fc12-42e1-b811-25fb573e99ee"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3657), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نقاشی" },
                    { new Guid("5ac8c69b-de7c-4457-b48b-178eecc549a9"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3566), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی فناوری اطلاعات" },
                    { new Guid("9e2065bf-d974-4712-a927-e509ee72c5e0"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3317), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدیریت آموزشی" },
                    { new Guid("d8dc5a91-3607-4dab-b1f3-91c004d2b9f4"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3265), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نانوشیمی" },
                    { new Guid("edac3087-37fe-4012-94a8-57f5cb43d50c"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3291), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدیریت دولتی" },
                    { new Guid("dd5f8a55-18b5-4574-b31b-0ec6b8449bf6"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3278), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کارآفرینی" },
                    { new Guid("4129d304-83e5-439f-9f4c-8eefe0eab484"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3670), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ارتباط تصویری" },
                    { new Guid("4cb47565-2b49-408a-a8db-bb56dd2f4381"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3238), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زیست‌فناوری" },
                    { new Guid("8aa73822-b100-4b1c-a263-5e9379c90c00"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3225), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "بیوتکنولوژی" },
                    { new Guid("f56722b1-77fe-4b21-9ae4-37898932bd9f"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3212), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی مکانیک" },
                    { new Guid("0482655b-335d-49c7-8f7c-70809931c899"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3199), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی صنایع" },
                    { new Guid("e94f842f-d10c-46c0-bd6d-63952b5de5b8"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3185), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی شیمی" },
                    { new Guid("cbeca3f2-04cb-4340-91c1-210dc163f028"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3172), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی نفت" },
                    { new Guid("9d3a0faf-8a76-4c97-992c-a25f7f916e7f"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3160), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زبان و ادبیات فارسی" },
                    { new Guid("b71acc43-1a6f-4aad-a1a5-f39c6604ba12"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3146), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "حسابداری" },
                    { new Guid("1ccb8411-afe5-420a-82a8-a5c79ff2dcd9"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3113), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی معماری" },
                    { new Guid("559ebfcb-cee9-4cb6-8a1a-e7e52a1f234c"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3085), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "علوم كامپیوتر" },
                    { new Guid("b842e627-7f7b-49b5-a4d5-af7cf983fdc6"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(2602), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مهندسی شهرسازی" },
                    { new Guid("1d1a70d2-3b14-44dd-907b-e7e37bf33170"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(3304), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدیریت فناوری اطلاعات" }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("513fda9d-777f-43c3-98aa-093ca948aebc"), new DateTime(2021, 5, 29, 11, 32, 43, 590, DateTimeKind.Local).AddTicks(5509), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نظری" },
                    { new Guid("ebe814c8-de30-4d72-9956-c1d9f0ace80a"), new DateTime(2021, 5, 29, 11, 32, 43, 590, DateTimeKind.Local).AddTicks(5435), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کاردانش" },
                    { new Guid("b80e44f7-bb97-4501-b64e-45c793d835df"), new DateTime(2021, 5, 29, 11, 32, 43, 586, DateTimeKind.Local).AddTicks(2499), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "فنی و حرفه ای" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("391ac1cc-2eec-4997-bd54-1d0caa0af449"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2954), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "فراهان" },
                    { new Guid("4b0ee5f3-8695-4eaa-ae48-6e159772b442"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2941), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ساوه" },
                    { new Guid("0ca80af5-321c-49b3-8a4a-2d1508b6450d"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2927), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زرندیه" },
                    { new Guid("455bcd80-e1a5-4a58-a7ec-c3cbf1475ea1"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2914), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نوبران" },
                    { new Guid("b45fcd9e-71e1-4c3b-8800-3f36fba41182"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2902), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "شازند" },
                    { new Guid("fe6ac661-a823-40fa-87dd-ac3ff3c9cce0"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2877), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دلیجان" },
                    { new Guid("c1d22f95-b7c6-40e2-bdae-2f7ff7b87686"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2863), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کمیجان" },
                    { new Guid("72b96635-697d-4567-b285-f19b104fc093"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2889), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "محلات" },
                    { new Guid("2d0d7cd7-e6c5-4bb0-abbb-7352d076eb42"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2810), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "خنداب" },
                    { new Guid("5c3670e1-8d23-4586-a1c6-f9444f7124c1"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2797), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "خمین" },
                    { new Guid("9ea8af71-c2e8-4f22-a350-aa79b50b28cb"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2782), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تفرش" },
                    { new Guid("e4d3f774-b6f6-4210-b9f5-3af804a57d09"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2765), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "آشتیان" },
                    { new Guid("4ecb374b-04d3-468e-a206-d8534379daa1"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2733), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ناحیه 2" },
                    { new Guid("2f08ecba-d38a-44df-9f37-a19629779767"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2166), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ناحیه 1" },
                    { new Guid("a058f0d0-b97c-449f-8a85-757b788b58cf"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(2825), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "سربند" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("2c3753c4-e760-4765-aa4f-660b19484db9"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(8948), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "هیأت امنایی" },
                    { new Guid("0fcd68f9-b954-4f4b-9107-2926c731bde0"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(9441), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "شبانه روزی" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("c859a9c7-58ab-437b-8fba-074a03898a51"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(1275), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مرد" },
                    { new Guid("dd225706-a1df-441f-aa00-9d44245d0ffc"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(584), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زن" }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("37bf8064-0633-4615-8cc7-b05607e1c582"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(5648), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دوازدهم" },
                    { new Guid("cfd885ce-f99f-4bcc-b38a-c4ed46be94c9"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(5098), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دهم" },
                    { new Guid("086086bd-cd4b-4342-a132-f85c9c12452d"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(5618), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "یازدهم" }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { new Guid("e3e7f46c-0e43-407c-b4fd-62b756541d05"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(6367), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "هنرآموز" },
                    { new Guid("89839636-f103-4d02-8284-fd0f45013411"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(6874), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "استادکار" },
                    { new Guid("8b8b8289-e394-4b52-a510-8a95dfc00cc8"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(6926), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدیر" },
                    { new Guid("2d712107-227c-421d-8e13-bd51090f15d8"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(6940), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "معاون فنی" },
                    { new Guid("f64a56eb-9aa2-47cb-9771-9b5b68bd1a59"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(6953), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "معاون آموزشی" },
                    { new Guid("ef5bc123-8e37-401e-809f-bb0062c0fb65"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(6967), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انباردار" },
                    { new Guid("1bf7bdfb-282d-4504-af7b-725887ae1cc3"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(6979), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "سرپرست بخش" }
                });

            migrationBuilder.InsertData(
                table: "MarkingTypes",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("f99ff077-b94b-4ac4-b402-1d7ad12f44b0"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(4316), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دو نمره ای" },
                    { new Guid("913e7b73-8e2a-4b38-9865-0064df9395f1"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(4348), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "چهار نمره ای" },
                    { new Guid("984f2425-a533-4c14-93bb-3d4098acb9ff"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(3781), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "یک نمره ای" }
                });

            migrationBuilder.InsertData(
                table: "OUTypes",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("734c5f57-8320-4a48-920b-e850fd171461"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(7676), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "استعدادهای درخشان" },
                    { new Guid("a2e3a593-436f-4156-9d89-9263e9776ed6"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(8174), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "شاهد" },
                    { new Guid("5cb8c761-c59e-4f18-9e33-84df2f23f62e"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(8202), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عادی" },
                    { new Guid("c763f792-8c3a-4dec-afa8-68a946c4dd34"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(8235), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عام المنفعه" },
                    { new Guid("4e70b4b8-6e06-417b-9df9-e4eb6dc5176b"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(8249), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نمونه دولتی" },
                    { new Guid("b3f69cf9-c15b-4a9b-8068-0791d3aad0fe"), new DateTime(2021, 5, 29, 11, 32, 43, 592, DateTimeKind.Local).AddTicks(8261), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "وابسته" }
                });

            migrationBuilder.InsertData(
                table: "UnitTypes",
                columns: new[] { "Id", "AddedDate", "IPAddress", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("2eb04e8f-5c1b-4cb8-b752-2349b830f507"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(158), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دولتی" },
                    { new Guid("18000912-941d-4af7-812f-a6e59304c2ac"), new DateTime(2021, 5, 29, 11, 32, 43, 593, DateTimeKind.Local).AddTicks(654), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "غیردولتی" }
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
                name: "IX_NotificationRecipients_NotificationId",
                table: "NotificationRecipients",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ParentNotificationId",
                table: "Notifications",
                column: "ParentNotificationId");

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
                name: "NotificationRecipients");

            migrationBuilder.DropTable(
                name: "StaffEducationalBackgrounds");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "WorkedFors");

            migrationBuilder.DropTable(
                name: "Notifications");

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
