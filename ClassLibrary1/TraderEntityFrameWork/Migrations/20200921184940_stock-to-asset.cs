using Microsoft.EntityFrameworkCore.Migrations;

namespace TraderEntityFrameWork.Migrations
{
    public partial class stocktoasset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_AccountHolderId",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AssetTransactions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Stock_Symbol",
                table: "AssetTransactions",
                newName: "Asset_Symbol");

            migrationBuilder.RenameColumn(
                name: "Stock_PricePerSharper",
                table: "AssetTransactions",
                newName: "Asset_PricePerSharper");

            migrationBuilder.RenameColumn(
                name: "AccountHolderId",
                table: "Accounts",
                newName: "AccountHolderid");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_AccountHolderId",
                table: "Accounts",
                newName: "IX_Accounts_AccountHolderid");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_AccountHolderid",
                table: "Accounts",
                column: "AccountHolderid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_AccountHolderid",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AssetTransactions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Asset_Symbol",
                table: "AssetTransactions",
                newName: "Stock_Symbol");

            migrationBuilder.RenameColumn(
                name: "Asset_PricePerSharper",
                table: "AssetTransactions",
                newName: "Stock_PricePerSharper");

            migrationBuilder.RenameColumn(
                name: "AccountHolderid",
                table: "Accounts",
                newName: "AccountHolderId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_AccountHolderid",
                table: "Accounts",
                newName: "IX_Accounts_AccountHolderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_AccountHolderId",
                table: "Accounts",
                column: "AccountHolderId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
