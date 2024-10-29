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
    public partial class AddAnimeForm : Form
    {
        private AnimeListDatabase animeListDatabase;
        private List<int> selectedGenreIds = new List<int>(); // Pro uchování vybraných žánrů

        public AddAnimeForm(AnimeListDatabase animeListDatabase)
        {
            InitializeComponent();
            animeListDatabase = animeListDatabase;
            LoadGenres();
        }
        public AddAnimeForm()
        {
            InitializeComponent();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            if (GenreComboBox.SelectedValue != null)
            {
                int selectedGenreId = (int)GenreComboBox.SelectedValue;
                selectedGenreIds.Add(selectedGenreId);
                UpdateAddedGenresLabel(); // Aktualizuje text labelu vybraných žánrů
            }
        }
        private void UpdateAddedGenresLabel()
        {
            // Vytvoříme seznam názvů vybraných žánrů
            var selectedGenres = selectedGenreIds
                .Select(id => animeListDatabase.GetGenreCollection().FindById(id)?.Nazev) // Získejte název žánru podle ID
                .Where(name => name != null); // Zajistíme, že název není null

            // Spojíme názvy do jednoho řetězce
            AddedGenreLabel.Text = string.Join(", ", selectedGenres); // Aktualizace textu labelu
        }
        private void LoadGenres()
        {
            var genres = animeListDatabase.GetGenreCollection().FindAll().ToList();
            GenreComboBox.DataSource = genres;
            GenreComboBox.DisplayMember = "Nazev";
            GenreComboBox.ValueMember = "Id";
        }

        private void btnSaveAnime_Click(object sender, EventArgs e)
        {
            // Získání dat z formuláře
            string animeName = txtName.Text; // Předpokládané TextBox pro název anime
            int numberOfEpisodes = (int)numberOfEpisodesNumeric.Value; // Předpokládaný NumericUpDown pro počet epizod
            double rating = (double)AddAnimeNumericRating.Value; // Předpokládaný NumericUpDown pro hodnocení

            // Vytvoření nového anime objektu
            var newAnime = new Anime
            {
                Nazev = animeName,
                PocetEpizod = numberOfEpisodes,
                Hodnoceni = rating,
                Zanry = selectedGenreIds // Přidání vybraných žánrů
            };

            // Uložení do databáze
            animeListDatabase.AddAnime(newAnime); // Přidejte metodu pro uložení anime do databáze
            Close(); // Zavření formuláře po úspěšném uložení
        }
    }
}
