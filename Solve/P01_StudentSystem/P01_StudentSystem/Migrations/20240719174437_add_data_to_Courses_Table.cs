using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P01_StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class add_data_to_Courses_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Description", "Endtime", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1, "course 1", new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Javascript", 5000, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "course 2", new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Puthon", 4500, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "course 3", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C++", 6500, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);
        }
    }
}
