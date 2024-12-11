using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using C2.Data;
using C2.Models;

namespace C2.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly LiteDbContext _context;

        public StatisticsController(LiteDbContext context)
        {
            _context = context;
        }

        // Akce pro statistiky
        public IActionResult Index()
        {
            var animes = _context.Animes.FindAll().ToList();
            var episodes = _context.Episodes.FindAll().ToList(); // Explicitně načteme všechny epizody

            // Počet anime
            int totalAnime = animes.Count;

            // Počet epizod
            int totalEpisodes = episodes.Count;

            // Celkový čas sledování
            int totalMinutes = episodes.Sum(e => e.Duration);
            int days = totalMinutes / 1440;
            int hours = (totalMinutes % 1440) / 60;
            int minutes = totalMinutes % 60;

            // Nejoblíbenější žánry
            var genreCounts = animes
                .SelectMany(a => a.Genres)
                .GroupBy(g => g.Name)
                .Select(g => new { Genre = g.Key, Count = g.Count() })
                .OrderByDescending(g => g.Count)
                .Take(5)
                .ToList();

            // Přiřazení výsledků do ViewBag.TopGenres jako List<dynamic>
            var topGenres = new List<dynamic>();
            if (genreCounts.Any())
            {
                topGenres.AddRange(genreCounts);
            }
            ViewBag.TopGenres = topGenres;

            // Předání dalších statistik do ViewBag
            ViewBag.TotalAnime = totalAnime;
            ViewBag.TotalEpisodes = totalEpisodes;
            ViewBag.TotalDays = days;
            ViewBag.TotalHours = hours;
            ViewBag.TotalMinutes = minutes;

            return View();
        }
    }
}
