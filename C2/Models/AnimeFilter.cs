using System;
using System.Collections.Generic;

namespace C2.Models
{
    public class AnimeFilterModel
    {
        public string Title { get; set; } // Název anime pro filtrování

        public int? MinEpisodeCount { get; set; } // Minimální počet epizod pro filtrování
        public int? MaxEpisodeCount { get; set; } // Maximální počet epizod pro filtrování

        public int? MinRating { get; set; } // Minimální hodnocení pro filtrování
        public int? MaxRating { get; set; } // Maximální hodnocení pro filtrování

        public List<int> SelectedGenreIds { get; set; } = new List<int>(); // Vybrané ID žánrů pro filtrování
    }
}
