using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HoldsSimpleWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderHold",
                columns: table => new
                {
                    OrderHoldID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    OrderHoldCode = table.Column<string>(nullable: true),
                    OrderHoldDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHold", x => x.OrderHoldID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderHold");
        }
    }
}
