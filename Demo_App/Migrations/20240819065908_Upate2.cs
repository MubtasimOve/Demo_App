using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_App.Migrations
{
    /// <inheritdoc />
    public partial class Upate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Category_Id",
                keyValue: 2,
                column: "Name",
                value: "Method");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Category_Id",
                keyValue: 3,
                column: "Name",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Category_Id",
                keyValue: 4,
                column: "Name",
                value: "Migration");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Category_Id", "DisplayOrder", "Name" },
                values: new object[] { 5, 5, "Update" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Category_Id",
                keyValue: 2,
                column: "Name",
                value: "Action");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Category_Id",
                keyValue: 3,
                column: "Name",
                value: "Action");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Category_Id",
                keyValue: 4,
                column: "Name",
                value: "Action");
        }
    }
}
