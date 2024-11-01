using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Episode
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public int CisloEpizody { get; set; }
        public int Delka { get; set; }
        public DateTime DatumVydani { get; set; }
        public Anime Anime { get; set; }  // Reference na Anime
    }

}
