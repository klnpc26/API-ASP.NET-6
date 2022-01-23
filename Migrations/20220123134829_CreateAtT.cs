using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TESTEAPI.Migrations
{
    public partial class CreateAtT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    idCustomer = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    dsName = table.Column<string>(type: "TEXT", nullable: false),
                    dsCPFCNPJ = table.Column<string>(type: "TEXT", nullable: false),
                    dsEmail = table.Column<string>(type: "TEXT", nullable: false),
                    dtBirthDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.idCustomer);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
