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
            var episodes = _context.Episodes.FindAll().ToList();
            var genres = _context.Genres.FindAll().ToList();

            // Počet anime
            int totalAnime = animes.Count;

            // Počet epizod
            int totalEpisodes = episodes.Count;

            // Celkový čas sledování
            int totalMinutes = episodes.Sum(e => e.Duration);
            int days = totalMinutes / 1440;
            int hours = (totalMinutes % 1440) / 60;
            int minutes = totalMinutes % 60;

            // Průměrné hodnocení všech anime
            double averageRating = totalAnime > 0
                ? animes.Average(a => a.Rating)
                : 0.0;

            // Nejnovější přidané anime
            var newestAnimeAdded = animes.OrderByDescending(a => a.Id).FirstOrDefault();
            ViewBag.NewestAnimeAdded = newestAnimeAdded;

            // Nejlépe hodnocené anime
            var topRatedAnime = animes.OrderByDescending(a => a.Rating).FirstOrDefault();
            ViewBag.TopRatedAnime = topRatedAnime;

            // Nejlépe hodnocený žánr (průměrné hodnocení všech anime v daném žánru)
            var genreRatings = animes
                .SelectMany(a => a.Genres)
                .GroupBy(g => g.Id)
                .Select(g => new
                {
                    Genre = genres.First(genre => genre.Id == g.Key).Name,
                    AverageRating = g.Average(a => animes.First(anime => anime.Genres.Any(genre => genre.Id == g.Key)).Rating)
                })
                .OrderByDescending(gr => gr.AverageRating)
                .FirstOrDefault();
            ViewBag.TopRatedGenre = genreRatings;

            // Žánr s nejvíce anime
            var mostPopularGenre = animes
                .SelectMany(a => a.Genres)
                .GroupBy(g => g.Id)
                .Select(g => new
                {
                    Genre = genres.First(genre => genre.Id == g.Key).Name,
                    Count = g.Count()
                })
                .OrderByDescending(gr => gr.Count)
                .FirstOrDefault();
            ViewBag.MostPopularGenre = mostPopularGenre;

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

            // Předání statistik do ViewBag
            ViewBag.TotalAnime = totalAnime;
            ViewBag.TotalEpisodes = totalEpisodes;
            ViewBag.TotalDays = days;
            ViewBag.TotalHours = hours;
            ViewBag.TotalMinutes = minutes;
            ViewBag.AverageRating = averageRating;

            return View();
        }

    }
}
