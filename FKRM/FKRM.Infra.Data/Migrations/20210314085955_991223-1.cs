using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FKRM.Infra.Data.Migrations
{
    public partial class _9912231 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "UnitTypeId",
                table: "Schools",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "OUTypeId",
                table: "Schools",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GenderId",
                table: "Schools",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FeatureId",
                table: "Schools",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Features_FeatureId",
                table: "Schools",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Genders_GenderId",
                table: "Schools",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_OUTypes_OUTypeId",
                table: "Schools",
                column: "OUTypeId",
                principalTable: "OUTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_UnitTypes_UnitTypeId",
                table: "Schools",
                column: "UnitTypeId",
                principalTable: "UnitTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.AlterColumn<Guid>(
                name: "UnitTypeId",
                table: "Schools",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "OUTypeId",
                table: "Schools",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "GenderId",
                table: "Schools",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "FeatureId",
                table: "Schools",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

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
    }
}
