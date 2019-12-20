using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class AgainM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_Statuses_StausId",
                table: "LibraryAssets");

            migrationBuilder.DropIndex(
                name: "IX_LibraryAssets_StausId",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "StausId",
                table: "LibraryAssets");

            migrationBuilder.RenameColumn(
                name: "CheckOut",
                table: "CheckoutHistories",
                newName: "CheckedOut");

            migrationBuilder.RenameColumn(
                name: "CheckIn",
                table: "CheckoutHistories",
                newName: "CheckedIn");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Statuses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Statuses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "LibraryAssets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAssets_StatusId",
                table: "LibraryAssets",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_Statuses_StatusId",
                table: "LibraryAssets",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_Statuses_StatusId",
                table: "LibraryAssets");

            migrationBuilder.DropIndex(
                name: "IX_LibraryAssets_StatusId",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "LibraryAssets");

            migrationBuilder.RenameColumn(
                name: "CheckedOut",
                table: "CheckoutHistories",
                newName: "CheckOut");

            migrationBuilder.RenameColumn(
                name: "CheckedIn",
                table: "CheckoutHistories",
                newName: "CheckIn");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Statuses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Statuses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StausId",
                table: "LibraryAssets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAssets_StausId",
                table: "LibraryAssets",
                column: "StausId");

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_Statuses_StausId",
                table: "LibraryAssets",
                column: "StausId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
