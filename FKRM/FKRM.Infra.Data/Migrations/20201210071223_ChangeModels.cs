using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class ChangeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schools_features_FeatureId",
                table: "schools");

            migrationBuilder.DropForeignKey(
                name: "FK_schools_genders_GenderId",
                table: "schools");

            migrationBuilder.DropForeignKey(
                name: "FK_schools_oUTypes_OUTypeID",
                table: "schools");

            migrationBuilder.DropForeignKey(
                name: "FK_schools_unitTypes_UnitTypeId",
                table: "schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_unitTypes",
                table: "unitTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_schools",
                table: "schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_oUTypes",
                table: "oUTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genders",
                table: "genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_features",
                table: "features");

            migrationBuilder.RenameTable(
                name: "unitTypes",
                newName: "UnitTypes");

            migrationBuilder.RenameTable(
                name: "schools",
                newName: "Schools");

            migrationBuilder.RenameTable(
                name: "oUTypes",
                newName: "OUTypes");

            migrationBuilder.RenameTable(
                name: "genders",
                newName: "Genders");

            migrationBuilder.RenameTable(
                name: "features",
                newName: "Features");

            migrationBuilder.RenameColumn(
                name: "OUTypeID",
                table: "Schools",
                newName: "OUTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_schools_UnitTypeId",
                table: "Schools",
                newName: "IX_Schools_UnitTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_schools_OUTypeID",
                table: "Schools",
                newName: "IX_Schools_OUTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_schools_GenderId",
                table: "Schools",
                newName: "IX_Schools_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_schools_FeatureId",
                table: "Schools",
                newName: "IX_Schools_FeatureId");

            migrationBuilder.AlterColumn<int>(
                name: "UnitTypeId",
                table: "Schools",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OUTypeId",
                table: "Schools",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Schools",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FeatureId",
                table: "Schools",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genders",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitTypes",
                table: "UnitTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schools",
                table: "Schools",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OUTypes",
                table: "OUTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Features",
                table: "Features",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Features_FeatureId",
                table: "Schools",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Genders_GenderId",
                table: "Schools",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_OUTypes_OUTypeId",
                table: "Schools",
                column: "OUTypeId",
                principalTable: "OUTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_UnitTypes_UnitTypeId",
                table: "Schools",
                column: "UnitTypeId",
                principalTable: "UnitTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Features_FeatureId",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Genders_GenderId",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_OUTypes_OUTypeId",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_UnitTypes_UnitTypeId",
                table: "Schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitTypes",
                table: "UnitTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schools",
                table: "Schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OUTypes",
                table: "OUTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Features",
                table: "Features");

            migrationBuilder.RenameTable(
                name: "UnitTypes",
                newName: "unitTypes");

            migrationBuilder.RenameTable(
                name: "Schools",
                newName: "schools");

            migrationBuilder.RenameTable(
                name: "OUTypes",
                newName: "oUTypes");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "genders");

            migrationBuilder.RenameTable(
                name: "Features",
                newName: "features");

            migrationBuilder.RenameColumn(
                name: "OUTypeId",
                table: "schools",
                newName: "OUTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Schools_UnitTypeId",
                table: "schools",
                newName: "IX_schools_UnitTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Schools_OUTypeId",
                table: "schools",
                newName: "IX_schools_OUTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Schools_GenderId",
                table: "schools",
                newName: "IX_schools_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Schools_FeatureId",
                table: "schools",
                newName: "IX_schools_FeatureId");

            migrationBuilder.AlterColumn<int>(
                name: "UnitTypeId",
                table: "schools",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OUTypeID",
                table: "schools",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "schools",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FeatureId",
                table: "schools",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "genders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 5);

            migrationBuilder.AddPrimaryKey(
                name: "PK_unitTypes",
                table: "unitTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_schools",
                table: "schools",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_oUTypes",
                table: "oUTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genders",
                table: "genders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_features",
                table: "features",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_schools_features_FeatureId",
                table: "schools",
                column: "FeatureId",
                principalTable: "features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_schools_genders_GenderId",
                table: "schools",
                column: "GenderId",
                principalTable: "genders",
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
    }
}
