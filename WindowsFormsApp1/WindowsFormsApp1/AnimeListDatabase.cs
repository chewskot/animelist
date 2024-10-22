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

    }
}
