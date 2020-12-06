using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class AddSchoolDependantEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeatureId",
                table: "schools",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OUTypeID",
                table: "schools",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitTypeId",
                table: "schools",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "features",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "oUTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oUTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "unitTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unitTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_schools_FeatureId",
                table: "schools",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_schools_OUTypeID",
                table: "schools",
                column: "OUTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_schools_UnitTypeId",
                table: "schools",
                column: "UnitTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_schools_features_FeatureId",
                table: "schools",
                column: "FeatureId",
                principalTable: "features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_schools_oUTypes_OUTypeID",
                table: "schools",
                column: "OUTypeID",
                principalTable: "oUTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_schools_unitTypes_UnitTypeId",
                table: "schools",
                column: "UnitTypeId",
                principalTable: "unitTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schools_features_FeatureId",
                table: "schools");

            migrationBuilder.DropForeignKey(
                name: "FK_schools_oUTypes_OUTypeID",
                table: "schools");

            migrationBuilder.DropForeignKey(
                name: "FK_schools_unitTypes_UnitTypeId",
                table: "schools");

            migrationBuilder.DropTable(
                name: "features");

            migrationBuilder.DropTable(
                name: "oUTypes");

            migrationBuilder.DropTable(
                name: "unitTypes");

            migrationBuilder.DropIndex(
                name: "IX_schools_FeatureId",
                table: "schools");

            migrationBuilder.DropIndex(
                name: "IX_schools_OUTypeID",
                table: "schools");

            migrationBuilder.DropIndex(
                name: "IX_schools_UnitTypeId",
                table: "schools");

            migrationBuilder.DropColumn(
                name: "FeatureId",
                table: "schools");

            migrationBuilder.DropColumn(
                name: "OUTypeID",
                table: "schools");

            migrationBuilder.DropColumn(
                name: "UnitTypeId",
                table: "schools");
        }
    }
}
