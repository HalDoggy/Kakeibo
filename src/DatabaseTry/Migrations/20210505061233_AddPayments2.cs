using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseTry.Migrations
{
    public partial class AddPayments2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sha256OfThis",
                table: "Payments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sha256OfThis",
                table: "Payments");
        }
    }
}
