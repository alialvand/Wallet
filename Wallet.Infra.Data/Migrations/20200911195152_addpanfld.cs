using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallet.Infra.Data.Migrations
{
    public partial class addpanfld : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Pan",
                table: "BalanceLog",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pan",
                table: "BalanceLog");
        }
    }
}
