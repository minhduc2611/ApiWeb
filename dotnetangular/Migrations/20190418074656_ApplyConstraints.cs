using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetangular.Migrations
{
    public partial class ApplyConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemoModel_Makes_MakeId",
                table: "DemoModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DemoModel",
                table: "DemoModel");

            migrationBuilder.RenameTable(
                name: "DemoModel",
                newName: "Models");

            migrationBuilder.RenameIndex(
                name: "IX_DemoModel_MakeId",
                table: "Models",
                newName: "IX_Models_MakeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "DemoModel");

            migrationBuilder.RenameIndex(
                name: "IX_Models_MakeId",
                table: "DemoModel",
                newName: "IX_DemoModel_MakeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DemoModel",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 225);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DemoModel",
                table: "DemoModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DemoModel_Makes_MakeId",
                table: "DemoModel",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
