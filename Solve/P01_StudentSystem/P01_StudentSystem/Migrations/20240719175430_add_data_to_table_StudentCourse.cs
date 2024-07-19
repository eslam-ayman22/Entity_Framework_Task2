using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P01_StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class add_data_to_table_StudentCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "StudentCourseId", "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 2, 2 },
                    { 2, 3, 4 },
                    { 3, 1, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumn: "StudentCourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumn: "StudentCourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumn: "StudentCourseId",
                keyValue: 3);
        }
    }
}
