using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBookWeb.Migrations
{
    public partial class AddCategoriesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "DisplayOrder", "Name", "createDateTime" },
                values: new object[] { 1, 2, "Category 1", new DateTime(2022, 8, 9, 9, 26, 57, 146, DateTimeKind.Local).AddTicks(8650) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
