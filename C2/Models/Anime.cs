using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace C2.Models
{
    public class Anime
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public int Rating { get; set; }

        [Required]
        [Range(1, 100000, ErrorMessage = "Episode count must be between 1 and 100000.")]
        public int EpisodeCount { get; set; }

        public List<int> GenreIds { get; set; } = new List<int>();
        public List<Genre> Genres { get; set; } = new List<Genre>();

        public List<Episode> Episodes { get; set; } = new List<Episode>();
    }
}
