using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Anime
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public DateTime DatumVydani { get; set; }
        public int PocetEpizod { get; set; }
        public double Hodnoceni { get; set; }
        public List<Episode> Epizody { get; set; }
        public List<Genre> Zanry { get; set; }  // Seznam žánrů
    }
}
