using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace book_store.Migrations
{
    /// <inheritdoc />
    public partial class removetitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Genre", "ImageUrl", "Name", "Price", "Title", "YearPublished" },
                values: new object[,]
                {
                    { 1, "Wharton, Edith", null, "Ethan Frome works his unproductive farm and struggles to maintain a bearable existence with his difficult, suspicious and hypochondriac wife, Zeena. But when Zeena's vivacious cousin enters their hous", "Horror Fiction", "https://jackets.dmmserver.com/media/356/97801413/9780141389400.jpg#images.titelive.com", "ETHAN FROME", 12m, "", 1998 },
                    { 2, "Wharton, Edith", null, "Ethan Frome works his unproductive farm and struggles to maintain a bearable existence with his difficult, suspicious and hypochondriac wife, Zeena. But when Zeena's vivacious cousin enters their hous", "Horror Fiction", "https://jackets.dmmserver.com/media/356/97801413/9780141389400.jpg#images.titelive.com", "ETHAN FROMEe", 12m, "", 1998 }
                });
        }
    }
}
