using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseContext.Migrations
{
    public partial class for_load : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverImageUrl",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SpEmployeeInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Salarywithbonus = table.Column<decimal>(nullable: false),
                    JoinDate = table.Column<DateTime>(nullable: false),
                    IsBonusAdded = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpEmployeeInfo");

            migrationBuilder.DropColumn(
                name: "CoverImageUrl",
                table: "Customers");
        }
    }
}
