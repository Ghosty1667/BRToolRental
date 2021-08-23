using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BRToolRentalAPI.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerEmail", "CustomerName", "CustomerPhone" },
                values: new object[] { 1, "Steve@email.com", "Steve", "1234" });

            migrationBuilder.InsertData(
                table: "Tools",
                columns: new[] { "ToolId", "Available", "ToolBrand", "ToolCondition", "ToolName" },
                values: new object[] { 1, false, "Makita", "New", "Hammer" });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "RentalID", "CustomerId", "Notes", "Rented", "Returned", "ToolId" },
                values: new object[] { 1, 1, null, new DateTime(2021, 8, 9, 12, 46, 7, 623, DateTimeKind.Local).AddTicks(2308), null, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "RentalID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tools",
                keyColumn: "ToolId",
                keyValue: 1);
        }
    }
}
