using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallet.Infra.Data.Migrations
{
    public partial class addTrDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransactionDate",
                table: "BalanceLog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionDate",
                table: "BalanceLog");
        }
    }
}
