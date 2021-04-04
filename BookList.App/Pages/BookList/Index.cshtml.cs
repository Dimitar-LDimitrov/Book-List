namespace BookList.App.Pages.BookList
{
    using global::BookList.App.Data;
    using global::BookList.App.Models;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            this.Books = await this.context.Book.ToListAsync();
        }

        //public IEnumerable<Book> GetAllBooks()
        //{
        //    return this.context.
        //}
    }
}
