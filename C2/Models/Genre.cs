using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace C2.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        // Nastav Animes jako volitelný
        public List<Anime>? Animes { get; set; } = new List<Anime>();
    }
}
