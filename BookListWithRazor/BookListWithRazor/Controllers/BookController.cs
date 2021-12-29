using BookListWithRazor.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BookListWithRazor.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Json(new { data = _db.Book.ToList() });
        }
    }
}
