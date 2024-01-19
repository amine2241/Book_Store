using Microsoft.AspNetCore.Identity;

namespace book_store.Models
{
    public class AppUser:IdentityUser
    {
        public string Occupation { get; set; }
    }
}
