using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace book_store.Data.Components
{
    public class CategoriesViewComponent:ViewComponent
    {
        private readonly BookdbContext _context; 
        public CategoriesViewComponent(BookdbContext context)
        {
            _context = context; 
        }
        public async Task<IViewComponentResult> InvokeAsync() => View(await _context.Categories.ToListAsync());
    }
}
