using C2.Data;
using C2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace C2.Controllers
{
    public class AnimeController : Controller
    {
        private readonly LiteDbContext _context;

        public AnimeController(LiteDbContext context)
        {
            _context = context;
        }

        // Zobrazí seznam anime
        public IActionResult Index()
        {
            var animes = _context.Animes.FindAll().ToList();
            return View(animes);
        }

        // Detail konkrétního anime
        public IActionResult Details(int id)
        {
            var anime = _context.Animes.FindById(id);
            if (anime == null)
            {
                return NotFound();
            }
            return View(anime);
        }

        // Formulář pro vytvoření nového anime
        public IActionResult Create()
        {
            ViewBag.Genres = _context.Genres.FindAll().ToList();
            return View(new Anime()); // Předáváme nový objekt bez předchozích hodnot
        }



        [HttpPost]
        public IActionResult Create(Anime anime)
        {
            if (ModelState.IsValid)
            {
                // Najdeme a přiřadíme žánry na základě zvolených `GenreIds`
                anime.Genres = _context.Genres.Find(g => anime.GenreIds.Contains(g.Id)).ToList();

                // Uložíme anime, abychom získali jeho ID
                _context.Animes.Insert(anime);

                // Vygenerujeme epizody
                DateTime episodeReleaseDate = anime.ReleaseDate;
                for (int i = 1; i <= anime.EpisodeCount; i++)
                {
                    var episode = new Episode
                    {
                        Number = i, // Přiřadíme číslo epizody
                        Title = $"Epizoda {i}",
                        ReleaseDate = episodeReleaseDate,
                        Duration = 23,
                        AnimeId = anime.Id
                    };

                    _context.Episodes.Insert(episode);
                    episodeReleaseDate = episodeReleaseDate.AddDays(7); // Posuneme datum vydání o týden
                }

                return RedirectToAction(nameof(Index));
            }

            // Pokud ModelState není platný, načteme seznam žánrů znovu pro view
            ViewBag.Genres = _context.Genres.FindAll().ToList();
            return View(anime);
        }


        public IActionResult Edit(int id)
        {
            var anime = _context.Animes.FindById(id);
            if (anime == null)
            {
                return NotFound();
            }

            // Načteme všechny dostupné žánry a nastavíme GenreIds podle vybraných žánrů
            ViewBag.Genres = _context.Genres.FindAll().ToList();
            anime.GenreIds = anime.Genres.Select(g => g.Id).ToList();

            // Diagnostický výstup pro kontrolu obsahu
            Console.WriteLine("Editing Anime ID: " + anime.Id);
            Console.WriteLine("Current Genres:");
            foreach (var genre in anime.Genres)
            {
                Console.WriteLine(" - " + genre.Name);
            }

            return View(anime);
        }


        [HttpPost]
        public IActionResult Edit(int id, Anime anime)
        {
            if (ModelState.IsValid)
            {
                var existingAnime = _context.Animes.FindById(id);
                if (existingAnime == null)
                {
                    return NotFound();
                }

                // Aktualizace základních údajů o anime
                existingAnime.Title = anime.Title;
                existingAnime.ReleaseDate = anime.ReleaseDate;
                existingAnime.Rating = anime.Rating;
                existingAnime.EpisodeCount = anime.EpisodeCount;

                // Zachováme stávající žánry, takže načteme pouze změny, pokud byly vybrány jiné žánry
                if (anime.GenreIds != null && anime.GenreIds.Any())
                {
                    var selectedGenres = _context.Genres.Find(g => anime.GenreIds.Contains(g.Id)).ToList();
                    existingAnime.Genres = selectedGenres;
                }

                // Načteme aktuální seznam epizod
                var currentEpisodes = _context.Episodes.Find(e => e.AnimeId == existingAnime.Id).OrderBy(e => e.Number).ToList();
                int currentEpisodeCount = currentEpisodes.Count;
                DateTime episodeReleaseDate = existingAnime.ReleaseDate;

                if (anime.EpisodeCount > currentEpisodeCount)
                {
                    // Přidáme pouze nové epizody
                    for (int i = currentEpisodeCount + 1; i <= anime.EpisodeCount; i++)
                    {
                        var episode = new Episode
                        {
                            Number = i,
                            Title = $"Epizoda {i}",
                            ReleaseDate = episodeReleaseDate.AddDays(7 * (i - 1)),
                            Duration = 23,
                            AnimeId = existingAnime.Id
                        };

                        _context.Episodes.Insert(episode);
                    }
                }
                else if (anime.EpisodeCount < currentEpisodeCount)
                {
                    // Odstraníme pouze nadbytečné epizody
                    var episodesToRemove = currentEpisodes.Skip(anime.EpisodeCount).ToList();
                    foreach (var episode in episodesToRemove)
                    {
                        _context.Episodes.Delete(episode.Id);
                    }
                }

                // Aktualizujeme seznam epizod v objektu Anime
                existingAnime.Episodes = _context.Episodes.Find(e => e.AnimeId == existingAnime.Id).OrderBy(e => e.Number).ToList();

                // Uložíme změny do databáze
                _context.Animes.Update(existingAnime);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Genres = _context.Genres.FindAll().ToList();
            return View(anime);
        }


        // Potvrzení smazání
        public IActionResult Delete(int id)
        {
            var anime = _context.Animes.FindById(id);
            if (anime == null)
            {
                return NotFound();
            }
            return View(anime);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _context.Animes.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult EditEpisodes(int id)
        {
            var anime = _context.Animes.FindById(id);
            if (anime == null)
            {
                return NotFound();
            }

            var episodes = _context.Episodes.Find(e => e.AnimeId == id).ToList();
            Console.WriteLine("Počet načtených epizod: " + episodes.Count);

            ViewBag.AnimeTitle = anime.Title;
            return View(episodes);
        }

        [HttpPost]
        public IActionResult SaveEpisodeChanges(List<Episode> episodes)
        {
            foreach (var episode in episodes)
            {
                if (episode != null)
                {
                    var existingEpisode = _context.Episodes.FindById(episode.Id);
                    if (existingEpisode != null)
                    {
                        existingEpisode.Title = episode.Title;
                        existingEpisode.ReleaseDate = episode.ReleaseDate;
                        existingEpisode.Duration = episode.Duration;

                        _context.Episodes.Update(existingEpisode);
                    }
                    else
                    {
                        Console.WriteLine($"Episode with ID {episode.Id} not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Encountered a null episode in the list.");
                }
            }
            return RedirectToAction("Index");
        }

    }
}
