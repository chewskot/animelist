// Data/LiteDbContext.cs
using LiteDB;
using C2.Models;

namespace C2.Data
{
    public class LiteDbContext
    {
        private readonly LiteDatabase _database;

        public LiteDbContext()
        {
            // Zadej cestu k databázovému souboru
            _database = new LiteDatabase("Filename=anime.db; Connection=shared");
        }

        // Kolekce (tabulky) pro jednotlivé entity
        public ILiteCollection<Anime> Animes => _database.GetCollection<Anime>("animes");
        public ILiteCollection<Episode> Episodes => _database.GetCollection<Episode>("episodes");
        public ILiteCollection<Genre> Genres => _database.GetCollection<Genre>("genres");

        // Zavře připojení k databázi (volitelné)
        public void Dispose() => _database.Dispose();
    }
}
