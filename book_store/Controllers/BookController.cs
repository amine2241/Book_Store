using book_store.Data;
using book_store.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace book_store.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private readonly BookdbContext _context; 
        public BookController(BookdbContext context)
        {
            _context =context;
        }
        public async Task <IActionResult> Index(string categorySlug = "", int p= 1)
        {
            int pageSize = 3; 
            ViewBag.PageSize =p;
            ViewBag.PageRange = pageSize;
            ViewBag.CategorySlug =categorySlug;
            if(categorySlug == "")
            {
                ViewBag.TotalPages = (int)Math.Ceiling((decimal)_context.Books.Count() / pageSize);
                return View(await _context.Books.OrderByDescending(p => p.Id).Skip((p - 1) * pageSize).Take(pageSize).ToListAsync());
            }
            Category category = await _context.Categories.Where(c => c.Name == categorySlug).FirstOrDefaultAsync();
            if (category == null) return RedirectToAction("Index");

            var productsByCategory = _context.Books.Where(p => p.Id == category.Id);
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)productsByCategory.Count() / pageSize);

            return View(await productsByCategory.OrderByDescending(p => p.Id).Skip((p - 1) * pageSize).Take(pageSize).ToListAsync());
        }
    }
}
