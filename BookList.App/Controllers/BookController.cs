namespace BookList.App.Controllers
{
    using BookList.App.Data;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDbContext context;

        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = this.context.Book.ToList() });
        }
    }
}
