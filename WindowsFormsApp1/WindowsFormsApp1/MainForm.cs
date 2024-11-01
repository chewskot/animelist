using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private AnimeListDatabase animeListDatabase;
        public MainForm()
        {
             InitializeComponent();

            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "anime_tracker.db");
            animeListDatabase = new AnimeListDatabase(databasePath);
        }

        private void animeBtn_Click(object sender, EventArgs e)
        {
            var addAnimeForm = new AddAnimeForm(animeListDatabase);
            addAnimeForm.ShowDialog();
        }
        private void btnEditAnime_Click(object sender, EventArgs e)
        {
            
            if (lstView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = (ListViewItem)lstView.SelectedItems[0];
                
                if (selectedItem.Tag is Anime selectedAnime)
                {
                   
                    var editAnimeForm = new AddAnimeForm(animeListDatabase, selectedAnime);
                    // Zde použijeme ShowDialog() pro zobrazení modálního dialogu
                    if (editAnimeForm.ShowDialog() == DialogResult.OK)
                    {
                        ShowAnimeList(); // Aktualizace seznamu po úpravě
                    }
                }
            }
        }

        private void btnShowAnime_Click(object sender, EventArgs e)
        {
            ShowAnimeList();
        }
        private void ShowAnimeList()
        {
            lstView.Items.Clear();
            var animeList = animeListDatabase.GetAnimeCollection().FindAll();

            foreach (var anime in animeList)
            {
                ListViewItem item = new ListViewItem($"{anime.Nazev} ({anime.PocetEpizod} epizod, hodnocení {anime.Hodnoceni}, datum vydani {anime.DatumVydani})");
                item.Tag = anime; // Uložíme celý objekt anime do Tag
                lstView.Items.Add(item);
            }

            lstView.Tag = "Anime"; // Označíme typ aktuálního obsahu
            btnEditAnime.Visible = true;  // Zobrazíme tlačítko pro úpravu anime
            btnEditGenre.Visible = false; // Skryjeme tlačítko pro úpravu žánrů
        }

        private void ShowGenreList()
        {
            lstView.Items.Clear();
            var genreList = animeListDatabase.GetGenreCollection().FindAll();

            foreach (var genre in genreList)
            {
                ListViewItem item = new ListViewItem($"{genre.Nazev} - {genre.Popis}");
                item.Tag = genre; // Uložíme celý objekt žánru do Tag
                lstView.Items.Add(item);
            }

            lstView.Tag = "Genre"; // Označíme typ aktuálního obsahu
            btnEditAnime.Visible = false;  // Skryjeme tlačítko pro úpravu anime
            btnEditGenre.Visible = true; // Zobrazíme tlačítko pro úpravu žánrů
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            var genreForm = new AddGenreForm(animeListDatabase); // Předá instanci databáze do formuláře
            genreForm.ShowDialog();
        }
        private void btnShowGenre_Click(object sender, EventArgs e)
        {
            ShowGenreList();
        }

        private void btnRemoveAnime_Click(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count > 0)
            {
                // Přetypování na ListViewItem, aby byl dostupný Tag
                var selectedItem = (ListViewItem)lstView.SelectedItems[0];

                // Ověříme, zda Tag obsahuje objekt Anime nebo Genre podle aktuálního obsahu lstView
                if ((string)lstView.Tag == "Anime" && selectedItem.Tag is Anime selectedAnime)
                {
                    int selectedId = selectedAnime.Id; // Získáme ID z objektu Anime
                    animeListDatabase.DeleteAnime(selectedId);
                    MessageBox.Show("Anime bylo úspěšně odstraněno.");
                    ShowAnimeList(); // Obnoví seznam anime po odstranění
                }
                else if ((string)lstView.Tag == "Genre" && selectedItem.Tag is Genre selectedGenre)
                {
                    int selectedId = selectedGenre.Id; // Získáme ID z objektu Genre
                    animeListDatabase.DeleteGenre(selectedId);
                    MessageBox.Show("Žánr byl úspěšně odstraněn.");
                    ShowGenreList(); // Obnoví seznam žánrů po odstranění
                }
                else
                {
                    MessageBox.Show("Vybranou položku nelze odstranit.");
                }
            }
            else
            {
                MessageBox.Show("Vyberte položku k odstranění.");
            }
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count > 0)
            {
                var selectedItem = (ListViewItem)lstView.SelectedItems[0];

                if (selectedItem.Tag is Genre selectedGenre)
                {
                    var editGenreForm = new AddGenreForm(animeListDatabase, selectedGenre); // Předá instanci databáze a objekt žánru k úpravě

                    if (editGenreForm.ShowDialog() == DialogResult.OK)
                    {
                        ShowGenreList(); // Aktualizuje seznam žánrů po úpravě
                    }
                }
                else
                {
                    MessageBox.Show("Vybranou položku nelze upravit.");
                }
            }
            else
            {
                MessageBox.Show("Vyberte žánr k úpravě.");
            }
        }

        private void btnEditEpisode_Click(object sender, EventArgs e)
        {

        }
    }
}
    