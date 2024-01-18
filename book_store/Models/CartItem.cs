using System.ComponentModel.DataAnnotations;

namespace book_store.Models
{
    public class CartItem
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total
        {
            get { return Quantity * Price; }
        }
        public string Image { get; set; }

        public CartItem()
        {
        }

        public CartItem(Book book)
        {
            BookId = book.Id;
            BookName = book.Name;
            Price = book.Price;
            Quantity = 1;
            Image = book.ImageUrl;
        }
    }
}
