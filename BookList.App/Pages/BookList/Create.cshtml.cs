namespace BookList.App.Pages.BookList
{
    using global::BookList.App.Data;
    using global::BookList.App.Models;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public CreateModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Book Book { get; set; }

        public void OnGet()
        {
        }
    }
}
