using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace book_store.Migrations
{
    /// <inheritdoc />
    public partial class book_dummy_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Genre", "Name", "Price", "Title", "YearPublished" },
                values: new object[,]
                {
                    { 1, "Stephen King", "Horror book", "Horror", "It", 12m, "test", 1998 },
                    { 2, "dumb", "Horror book", "Horror", "It", 12m, "test", 1998 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
