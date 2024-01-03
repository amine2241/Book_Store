using Microsoft.AspNetCore.Mvc;

namespace book_store.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
