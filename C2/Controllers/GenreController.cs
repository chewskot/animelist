using C2.Data;
using C2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace C2.Controllers
{
    public class GenreController : Controller
    {
        private readonly LiteDbContext _context;

        public GenreController(LiteDbContext context)
        {
            _context = context;
        }

        // Zobrazí seznam žánrů
        public IActionResult Index()
        {
            var genres = _context.Genres.FindAll().ToList();
            return View(genres);
        }

        // Formulář pro vytvoření nového žánru
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                _context.Genres.Insert(genre);
                Console.WriteLine("New Genre Added:");
                Console.WriteLine($"ID: {genre.Id}, Name: {genre.Name}, Description: {genre.Description}");
                return RedirectToAction(nameof(Index));
            }
            else
            {
                Console.WriteLine("ModelState is not valid.");
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            return View(genre);
        }


        // Formulář pro úpravu existujícího žánru
        public IActionResult Edit(int id)
        {
            var genre = _context.Genres.FindById(id);
            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        [HttpPost]
        public IActionResult Edit(int id, Genre genre)
        {
            if (ModelState.IsValid)
            {
                _context.Genres.Update(genre);
                return RedirectToAction(nameof(Index));
            }
            return View(genre);
        }

        // Potvrzení smazání
        public IActionResult Delete(int id)
        {
            var genre = _context.Genres.FindById(id);
            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _context.Genres.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
