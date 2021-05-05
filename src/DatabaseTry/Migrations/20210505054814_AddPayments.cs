using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseTry.Migrations
{
    public partial class AddPayments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateEditoble = table.Column<bool>(type: "INTEGER", nullable: false),
                    Store = table.Column<string>(type: "TEXT", nullable: true),
                    StoreEditoble = table.Column<bool>(type: "INTEGER", nullable: false),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false),
                    AmountEditoble = table.Column<bool>(type: "INTEGER", nullable: false),
                    Category = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryEditoble = table.Column<bool>(type: "INTEGER", nullable: false),
                    RowNumOfStatement = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
