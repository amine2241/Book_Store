using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_store.Migrations
{
    /// <inheritdoc />
    public partial class book_image_test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "Genre", "ImageUrl", "Name", "Title" },
                values: new object[] { "Wharton, Edith", "Ethan Frome works his unproductive farm and struggles to maintain a bearable existence with his difficult, suspicious and hypochondriac wife, Zeena. But when Zeena's vivacious cousin enters their hous", "Horror Fiction", "https://jackets.dmmserver.com/media/356/97801413/9780141389400.jpg#images.titelive.com", "ETHAN FROME", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "Genre", "ImageUrl", "Name", "Title" },
                values: new object[] { "Stephen King", "Horror book", "Horror", null, "It", "test" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Genre", "ImageUrl", "Name", "Price", "Title", "YearPublished" },
                values: new object[] { 2, "dumb", "Horror book", "Horror", null, "It", 12m, "test", 1998 });
        }
    }
}
