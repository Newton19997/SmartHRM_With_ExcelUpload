using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseContext.Migrations
{
    public partial class poheaderdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PoDetail_Customers_CustomerId",
                table: "PoDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PoDetail_PoHeaders_PoId",
                table: "PoDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PoDetail",
                table: "PoDetail");

            migrationBuilder.RenameTable(
                name: "PoDetail",
                newName: "PoDetails");

            migrationBuilder.RenameIndex(
                name: "IX_PoDetail_PoId",
                table: "PoDetails",
                newName: "IX_PoDetails_PoId");

            migrationBuilder.RenameIndex(
                name: "IX_PoDetail_CustomerId",
                table: "PoDetails",
                newName: "IX_PoDetails_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PoDetails",
                table: "PoDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PoDetails_Customers_CustomerId",
                table: "PoDetails",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PoDetails_PoHeaders_PoId",
                table: "PoDetails",
                column: "PoId",
                principalTable: "PoHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PoDetails_Customers_CustomerId",
                table: "PoDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PoDetails_PoHeaders_PoId",
                table: "PoDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PoDetails",
                table: "PoDetails");

            migrationBuilder.RenameTable(
                name: "PoDetails",
                newName: "PoDetail");

            migrationBuilder.RenameIndex(
                name: "IX_PoDetails_PoId",
                table: "PoDetail",
                newName: "IX_PoDetail_PoId");

            migrationBuilder.RenameIndex(
                name: "IX_PoDetails_CustomerId",
                table: "PoDetail",
                newName: "IX_PoDetail_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PoDetail",
                table: "PoDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PoDetail_Customers_CustomerId",
                table: "PoDetail",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PoDetail_PoHeaders_PoId",
                table: "PoDetail",
                column: "PoId",
                principalTable: "PoHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
