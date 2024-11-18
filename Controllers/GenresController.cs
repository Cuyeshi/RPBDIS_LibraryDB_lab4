using Microsoft.AspNetCore.Mvc;
using RPBDIS_lab4.Models;

namespace RPBDIS_lab4.Controllers
{
    public class GenresController : Controller
    {
        private readonly LibraryDbContext _context;

        public GenresController(LibraryDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var genres = _context.Genres.ToList();
            return View(genres);
        }
    }

}
