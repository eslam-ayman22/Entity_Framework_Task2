using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P01_StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class add_data_to_studentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Birthday", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[,]
                {
                    { 1, 2001, "Eslam", "1149043904", new DateTime(2015, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2000, "Ali", "114908874", new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2003, "Mahmoud", "1028867657", new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2004, "Karem", "1025469875", new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2005, "yousef", "1097057214", new DateTime(2014, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);
        }
    }
}
