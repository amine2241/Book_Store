using System.ComponentModel.DataAnnotations;

namespace book_store.Models
{
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int BookId { get; set; }

        public virtual Book book { get; set; }
    }
}
