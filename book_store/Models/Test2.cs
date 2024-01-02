using System.ComponentModel.DataAnnotations;

namespace book_store.Models
{
    public class Test2
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string displayorder { get; set; }
    }
}
