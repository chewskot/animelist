using C2.Data;
using C2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;

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
            ViewBag.Genres = _context.Genres.FindAll().ToList(); // Načteme seznam žánrů pro filtrační formulář
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
        [HttpPost]
        public IActionResult DeleteAll()
        {
            // Smažeme všechny záznamy z kolekce Anime
            _context.Animes.DeleteMany(_ => true);

            // Smažeme i všechny související epizody
            _context.Episodes.DeleteMany(_ => true);

            return RedirectToAction(nameof(Index));
        }


        // Filtr anime podle zadaných kritérií
        [HttpGet]
        public IActionResult Filter(AnimeFilterModel filter)
        {
            // Načti aktuální filtry z ViewBag.Filter, pokud existují
            var currentFilter = ViewBag.Filter as AnimeFilterModel ?? new AnimeFilterModel();

            // Sloučení nového filtru s existujícím
            filter.Title = filter.Title ?? currentFilter.Title;
            filter.MinEpisodeCount ??= currentFilter.MinEpisodeCount;
            filter.MaxEpisodeCount ??= currentFilter.MaxEpisodeCount;
            filter.MinRating ??= currentFilter.MinRating;
            filter.MaxRating ??= currentFilter.MaxRating;

            if (filter.SelectedGenreIds == null || !filter.SelectedGenreIds.Any())
            {
                filter.SelectedGenreIds = currentFilter.SelectedGenreIds ?? new List<int>();
            }
            else
            {
                // Přidání nově vybraných žánrů ke stávajícím
                filter.SelectedGenreIds = filter.SelectedGenreIds.Union(currentFilter.SelectedGenreIds ?? new List<int>()).ToList();
            }

            // Uložíme hodnoty aktuálního filtru zpět do ViewBag
            ViewBag.Filter = filter;

            // Použití filtrů
            var query = _context.Animes.FindAll().AsQueryable();

            // Filtrování podle názvu (case-insensitive)
            if (!string.IsNullOrEmpty(filter.Title))
            {
                query = query.Where(a => a.Title.ToLower().Contains(filter.Title.ToLower()));
            }

            // Filtrování podle počtu epizod
            if (filter.MinEpisodeCount.HasValue)
            {
                query = query.Where(a => a.EpisodeCount >= filter.MinEpisodeCount.Value);
            }
            if (filter.MaxEpisodeCount.HasValue)
            {
                query = query.Where(a => a.EpisodeCount <= filter.MaxEpisodeCount.Value);
            }

            // Filtrování podle hodnocení
            if (filter.MinRating.HasValue)
            {
                query = query.Where(a => a.Rating >= filter.MinRating.Value);
            }
            if (filter.MaxRating.HasValue)
            {
                query = query.Where(a => a.Rating <= filter.MaxRating.Value);
            }

            // Filtrování podle vybraných žánrů
            if (filter.SelectedGenreIds != null && filter.SelectedGenreIds.Any())
            {
                query = query.Where(a => a.Genres.Any(g => filter.SelectedGenreIds.Contains(g.Id)));
            }

            var filteredAnimes = query.ToList();

            ViewBag.Genres = _context.Genres.FindAll().ToList();

            return View("Index", filteredAnimes);
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
                anime.Genres = _context.Genres.Find(g => anime.GenreIds.Contains(g.Id)).ToList();
                _context.Animes.Insert(anime);

                DateTime episodeReleaseDate = anime.ReleaseDate;
                for (int i = 1; i <= anime.EpisodeCount; i++)
                {
                    var episode = new Episode
                    {
                        Number = i,
                        Title = $"Epizoda {i}",
                        ReleaseDate = episodeReleaseDate,
                        Duration = 23,
                        AnimeId = anime.Id
                    };

                    _context.Episodes.Insert(episode);
                    episodeReleaseDate = episodeReleaseDate.AddDays(7);
                }

                return RedirectToAction(nameof(Index));
            }

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

            ViewBag.Genres = _context.Genres.FindAll().ToList();
            anime.GenreIds = anime.Genres.Select(g => g.Id).ToList();
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

                // Aktualizace základních informací o anime
                existingAnime.Title = anime.Title;
                existingAnime.ReleaseDate = anime.ReleaseDate;
                existingAnime.Rating = anime.Rating;
                existingAnime.EpisodeCount = anime.EpisodeCount;

                // Reset žánrů - nahradíme celý seznam žánrů na základě vybraných ID
                existingAnime.Genres = _context.Genres.Find(g => anime.GenreIds.Contains(g.Id)).ToList();

                // Správa epizod - přidání nebo odebrání epizod podle změny počtu
                var currentEpisodes = _context.Episodes.Find(e => e.AnimeId == existingAnime.Id).OrderBy(e => e.Number).ToList();
                int currentEpisodeCount = currentEpisodes.Count;

                if (anime.EpisodeCount > currentEpisodeCount)
                {
                    // Přidat nové epizody
                    for (int i = currentEpisodeCount + 1; i <= anime.EpisodeCount; i++)
                    {
                        var episode = new Episode
                        {
                            Number = i,
                            Title = $"Epizoda {i}",
                            ReleaseDate = existingAnime.ReleaseDate.AddDays(7 * (i - 1)),
                            Duration = 23,
                            AnimeId = existingAnime.Id
                        };

                        _context.Episodes.Insert(episode);
                    }
                }
                else if (anime.EpisodeCount < currentEpisodeCount)
                {
                    // Odebrat přebytečné epizody
                    var episodesToRemove = currentEpisodes.Skip(anime.EpisodeCount).ToList();
                    foreach (var episode in episodesToRemove)
                    {
                        _context.Episodes.Delete(episode.Id);
                    }
                }

                // Uložit změny anime
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
                }
            }
            return RedirectToAction("Index");
        }


    }
}
