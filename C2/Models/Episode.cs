using System;

namespace C2.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public int Number { get; set; } // Číslo epizody
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; } // Délka v minutách

        // Propojení na Anime
        public int AnimeId { get; set; }
        public Anime Anime { get; set; }
    }
}
