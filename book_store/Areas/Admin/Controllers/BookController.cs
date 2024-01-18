﻿using book_store.Data;
using book_store.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace book_store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly BookdbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BookController(BookdbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index(int p = 1)
        {
            int pageSize = 3;
            ViewBag.PageNumber = p;
            ViewBag.PageRange = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)_context.Books.Count() / pageSize);

            return View(await _context.Books.OrderByDescending(p => p.Id)
                                                                            .Include(p => p.Category)
                                                                            .Skip((p - 1) * pageSize)
                                                                            .Take(pageSize)
                                                                            .ToListAsync());
        }
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name", book.CategoryId);

            if (ModelState.IsValid)
            {
                book.Name = book.Name.ToLower().Replace(" ", "-");

                var slug = await _context.Books.FirstOrDefaultAsync(p => p.Name == book.Name);
                Console.WriteLine("slug is " + slug);
                if (slug != null)
                {
                    ModelState.AddModelError("", "The book already exists.");
                    return View(book);
                }

                if (book.ImageUpload != null)
                {
                    string uploadsDir = Path.Combine(_webHostEnvironment.WebRootPath, "media/Books");
                    string imageName = Guid.NewGuid().ToString() + "_" + book.ImageUpload.FileName;

                    string filePath = Path.Combine(uploadsDir, imageName);

                    FileStream fs = new FileStream(filePath, FileMode.Create);
                    await book.ImageUpload.CopyToAsync(fs);
                    fs.Close();

                    book.ImageUrl = imageName;
                }

                _context.Add(book);
                await _context.SaveChangesAsync();

                TempData["Success"] = "The book has been created!";

                return RedirectToAction("Index");
            }

            return View(book);
        }


    }
}
