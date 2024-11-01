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
    public partial class AddGenreForm : Form
    {
        private AnimeListDatabase animeListDatabase;
        public AddGenreForm()
        {
            InitializeComponent();
        }
        private Genre editingGenre;
        private bool isEditMode = false;

        // Konstruktor pro přidávání nového žánru
        public AddGenreForm(AnimeListDatabase animeListDatabase)
        {
            InitializeComponent();
            this.animeListDatabase = animeListDatabase;
        }
        private void btnAddGenreOk_Click(object sender, EventArgs e)
        {
            // Získání dat z formuláře
            string nazev = txtGenreName.Text;
            string popis = txtGenreDescription.Text;

            if (isEditMode && editingGenre != null)
            {
                // Úprava existujícího žánru
                editingGenre.Nazev = nazev;
                editingGenre.Popis = popis;
                animeListDatabase.UpdateGenre(editingGenre); // Uloží změny do databáze
            }
            else
            {
                // Přidání nového žánru
                Genre newGenre = new Genre
                {
                    Nazev = nazev,
                    Popis = popis
                };
                animeListDatabase.AddGenre(newGenre); // Uloží nový žánr do databáze
            }

            this.Close(); // Zavře formulář po uložení
        }

        // Konstruktor pro úpravu existujícího žánru
        public AddGenreForm(AnimeListDatabase animeListDatabase, Genre genreToEdit)
        {
            InitializeComponent();
            this.animeListDatabase = animeListDatabase;
            this.editingGenre = genreToEdit;
            this.isEditMode = true;

            FillGenreDetails(); // Načte aktuální data žánru
        }

        private void FillGenreDetails()
        {
            if (editingGenre != null)
            {
                txtGenreName.Text = editingGenre.Nazev;
                txtGenreDescription.Text = editingGenre.Popis;
            }
        }

        

        private void btnAddGenreCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
