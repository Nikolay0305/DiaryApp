using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class FIxedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DairyEntries",
                columns: new[] { "Id", "Content", "CreationDate", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Joe!", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Went Hiking" },
                    { 2, "Went shopping with Joe!", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Went Shoping" },
                    { 3, "Went diving with Joe!", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Went Diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
