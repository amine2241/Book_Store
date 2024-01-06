namespace book_store.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Description { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public int YearPublished { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
    }
}
