using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Date", "Entry", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 6, 1, 58, 19, 106, DateTimeKind.Local).AddTicks(1137), "I went snowboarding today and it was awesome!", "Went snowboarding" },
                    { 2, new DateTime(2024, 10, 6, 1, 58, 19, 106, DateTimeKind.Local).AddTicks(1181), "I went to the beach today and it was awesome!", "Went to the beach" },
                    { 3, new DateTime(2024, 10, 6, 1, 58, 19, 106, DateTimeKind.Local).AddTicks(1183), "I went to the movies today and it was awesome!", "Went to the movies" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
