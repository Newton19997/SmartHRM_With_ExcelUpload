using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseContext.Migrations
{
    public partial class poheader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PoHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoNumber = table.Column<string>(maxLength: 15, nullable: false),
                    PoDate = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoHeaders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PoDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 35, nullable: false),
                    price = table.Column<decimal>(type: "smallmoney", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoDetail_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PoDetail_PoHeaders_PoId",
                        column: x => x.PoId,
                        principalTable: "PoHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PoDetail_CustomerId",
                table: "PoDetail",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PoDetail_PoId",
                table: "PoDetail",
                column: "PoId");

            migrationBuilder.CreateIndex(
                name: "IX_PoHeaders_EmployeeId",
                table: "PoHeaders",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PoDetail");

            migrationBuilder.DropTable(
                name: "PoHeaders");
        }
    }
}
