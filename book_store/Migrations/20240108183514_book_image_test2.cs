using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_store.Migrations
{
    /// <inheritdoc />
    public partial class book_image_test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Genre", "ImageUrl", "Name", "Price", "Title", "YearPublished" },
                values: new object[] { 2, "Wharton, Edith", "Ethan Frome works his unproductive farm and struggles to maintain a bearable existence with his difficult, suspicious and hypochondriac wife, Zeena. But when Zeena's vivacious cousin enters their hous", "Horror Fiction", "https://jackets.dmmserver.com/media/356/97801413/9780141389400.jpg#images.titelive.com", "ETHAN FROMEe", 12m, "", 1998 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
