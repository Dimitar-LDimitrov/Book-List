namespace BookList.App.Pages.BookList
{
    using global::BookList.App.Data;
    using global::BookList.App.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.Threading.Tasks;

    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public CreateModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await this.context.Book.AddAsync(Book);
                await this.context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
