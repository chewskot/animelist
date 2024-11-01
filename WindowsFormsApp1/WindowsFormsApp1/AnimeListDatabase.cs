using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AnimeListDatabase
    {
        private readonly LiteDatabase _db;

        public AnimeListDatabase(string databasePath)
        {
            _db = new LiteDatabase(databasePath);
        }

        public ILiteCollection<Anime> GetAnimeCollection()
        {
            return _db.GetCollection<Anime>("anime");
        }

        public ILiteCollection<Episode> GetEpisodeCollection()
        {
            return _db.GetCollection<Episode>("episodes");
        }

        public ILiteCollection<Genre> GetGenreCollection()
        {
            return _db.GetCollection<Genre>("genres");
        }
        // Přidání anime
        public void AddAnime(Anime anime)
        {
            var animeCollection = GetAnimeCollection();
            animeCollection.Insert(anime);
        }

        // Filtrování podle hodnocení
        public List<Anime> FilterAnimeByRating(double minRating)
        {
            var animeCollection = GetAnimeCollection();
            return animeCollection.Find(x => x.Hodnoceni >= minRating).ToList();
        }

        // Úprava anime
        public void UpdateAnime(Anime anime)
        {
            var animeCollection = GetAnimeCollection();
            animeCollection.Update(anime);
        }

        // Smazání anime
        public void DeleteAnime(int id)
        {
            var animeCollection = GetAnimeCollection();
            animeCollection.Delete(id);
        }
        public void UpdateGenre(Genre genre)
        {
            var genreCollection = GetGenreCollection();
            genreCollection.Update(genre); // Aktualizuje existující záznam žánru
        }

        // Přidání metody pro odstranění žánru
        public void DeleteGenre(int id)
        {
            var genreCollection = GetGenreCollection();
            genreCollection.Delete(id);
        }
        public Anime GetAnimeWithEpisodes(int animeId)
        {
            var animeCollection = GetAnimeCollection();
            var episodeCollection = GetEpisodeCollection();

            var anime = animeCollection.FindById(animeId);
            if (anime != null)
            {
                anime.Epizody = episodeCollection.Find(e => e.Anime.Id == animeId).ToList(); // Načte epizody
            }

            return anime;
        }

        // Metoda pro přidání žánru
        public void AddGenre(Genre genre)
        {
            var genreCollection = GetGenreCollection();
            genreCollection.Insert(genre); // Vložení nového žánru, ID se generuje automaticky
        }
        public void AddEpisode(Episode episode)
        {
            var episodeCollection = GetEpisodeCollection();
            episodeCollection.Insert(episode); // Vloží epizodu do kolekce "episodes"
        }
        public void UpdateEpisode(Episode episode)
        {
            var episodeCollection = GetEpisodeCollection();
            episodeCollection.Update(episode); // Aktualizuje existující epizodu v databázi
        }

    }
}
