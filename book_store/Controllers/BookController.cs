using book_store.Data;
using book_store.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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
            ViewBag.PageNumber =p;
            ViewBag.PageRange= pageSize;
            ViewBag.CategorySlug =categorySlug;
            if(categorySlug == "")
            {
                ViewBag.TotalPages = (int)Math.Ceiling((decimal)_context.Books.Count() / pageSize);
                return View(await _context.Books.OrderByDescending(p => p.Id).Skip((p - 1) * pageSize).Take(pageSize).ToListAsync());
            }
            Category category = await _context.Categories.Where(c => c.Name == categorySlug).FirstOrDefaultAsync();
            Console.WriteLine("category is" + category.Name);
            if (category == null) return RedirectToAction("Index");
            Console.WriteLine("passed this check ");

            var booksByCategory = _context.Books.Where(p => p.Category.Id == category.Id);
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)booksByCategory.Count() / pageSize);

            return View(await booksByCategory.OrderByDescending(p => p.Id).Skip((p - 1) * pageSize).Take(pageSize).ToListAsync());
        }
    }
}
