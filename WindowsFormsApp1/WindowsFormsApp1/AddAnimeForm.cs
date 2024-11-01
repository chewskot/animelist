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
        private Anime editingAnime;
        private bool isEditMode = false;
        public AddAnimeForm(AnimeListDatabase animeListDatabase)
        {
            InitializeComponent();
            this.animeListDatabase = animeListDatabase;
            LoadGenres();
        }
        public AddAnimeForm(AnimeListDatabase animeListDatabase, Anime animeToEdit)
        {
            InitializeComponent();
            this.animeListDatabase = animeListDatabase;
            this.editingAnime = animeToEdit; // Přiřazení anime k úpravám
            this.isEditMode = true; // Nastavení režimu úprav

            LoadGenres();
           FillAnimeDetails(); // Volání metody pro předvyplnění údajů
        }

        public AddAnimeForm()
        {
            InitializeComponent();
        }
        private void FillAnimeDetails()
        {
            if (editingAnime != null)
            {
                txtName.Text = editingAnime.Nazev;
                dateTimePicker1.Value = editingAnime.DatumVydani > dateTimePicker1.MinDate ? editingAnime.DatumVydani : DateTime.Today;
                numberOfEpisodesNumeric.Value = editingAnime.PocetEpizod;
                AddAnimeNumericRating.Value = (decimal)editingAnime.Hodnoceni;
                selectedGenreIds = editingAnime.Zanry.Select(z => z.Id).ToList();
                UpdateAddedGenresLabel();
            }
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
            if (isEditMode && editingAnime != null)
            {
                // Úprava existujícího anime
                editingAnime.Nazev = txtName.Text;
                editingAnime.DatumVydani = dateTimePicker1.Value;
                editingAnime.PocetEpizod = (int)numberOfEpisodesNumeric.Value;
                editingAnime.Hodnoceni = (double)AddAnimeNumericRating.Value;
                editingAnime.Zanry = selectedGenreIds.Select(id => animeListDatabase.GetGenreCollection().FindById(id)).ToList();
                animeListDatabase.UpdateAnime(editingAnime); // Uloží změny
            }
            else
            {
                // Přidání nového anime
                var newAnime = new Anime
                {
                    Nazev = txtName.Text,
                    DatumVydani = dateTimePicker1.Value,
                    PocetEpizod = (int)numberOfEpisodesNumeric.Value,
                    Hodnoceni = (double)AddAnimeNumericRating.Value,
                    Zanry = selectedGenreIds.Select(id => animeListDatabase.GetGenreCollection().FindById(id)).ToList()
                };
                animeListDatabase.AddAnime(newAnime);
            }

            Close(); // Zavření formuláře
        }

        private void btnCancelSavingAnime_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
