using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private AnimeListDatabase _db;
        public Form1()
        {
             InitializeComponent();

            // Cesta k databázi (můžete zadat jinou cestu, pokud chcete)
            _db = new AnimeListDatabase(@"C:\Users\mojan\source\repos\animelist\anime_tracker.db");
        }

        private void animeBtn_Click(object sender, EventArgs e)
        {
            // Získání názvu anime z TextBoxu
            string nazev = txtNazev.Text;

            // Vytvoření nové instance Anime
            var newAnime = new Anime
            {
                Nazev = nazev,
                DatumVydani = DateTime.Now, // Můžete upravit
                PocetEpizod = 12,           // Defaultně nastavte např. 12 epizod, nebo přidejte další TextBox pro vstup
                Hodnoceni = 8.5,            // Defaultní hodnocení
                Zanr = new Genre { Nazev = "Akční", Popis = "Akční anime" } // Můžete přidat TextBox pro výběr žánru
            };

            // Uložení do databáze
            _db.AddAnime(newAnime);

            // Vyčištění TextBoxu
            txtNazev.Clear();

            MessageBox.Show("Anime přidáno.");
        }

        private void btnShowAnime_Click(object sender, EventArgs e)
        {
            lstAnime.Items.Clear();
            var animeList = _db.GetAnimeCollection().FindAll();
            foreach (var anime in animeList)
            {
                lstAnime.Items.Add($"{anime.Nazev} ({anime.PocetEpizod} epizod, hodnocení {anime.Hodnoceni})");
            }
        }

      
    }
}
