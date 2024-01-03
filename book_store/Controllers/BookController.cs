using book_store.Data;
using book_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace book_store.Controllers
{
    public class BookController : Controller
    {
        private readonly BookdbContext _db; 
        public BookController(BookdbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Book> objCategoryList = _db.Books.ToList();

            return View(objCategoryList);
        }
    }
}
