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
            lstView.Items.Clear(); // Vymažeme existující položky
            lstView.View = View.Details; // Zobrazíme jako tabulku

            // Vymažeme existující sloupce, abychom předešli jejich duplikaci
            lstView.Columns.Clear();

            // Nastavíme konkrétní šířky pro jednotlivé sloupce, aby měly více prostoru
            lstView.Columns.Add("Název", 100, HorizontalAlignment.Left);
            lstView.Columns.Add("Počet epizod", 100, HorizontalAlignment.Left);
            lstView.Columns.Add("Hodnocení", 100, HorizontalAlignment.Left);
            lstView.Columns.Add("Datum vydání", 150, HorizontalAlignment.Left);

            var animeList = animeListDatabase.GetAnimeCollection().FindAll();

            foreach (var anime in animeList)
            {
                var item = new ListViewItem(anime.Nazev); // Hlavní text (první sloupec)
                item.SubItems.Add(anime.PocetEpizod.ToString()); // Druhý sloupec
                item.SubItems.Add(anime.Hodnoceni.ToString()); // Třetí sloupec
                item.SubItems.Add(anime.DatumVydani.ToString("dd/MM/yyyy HH:mm:ss")); // Čtvrtý sloupec

                item.Tag = anime; // Uložíme objekt anime do Tag pro další použití (např. úpravy)
                lstView.Items.Add(item);
            }

            lstView.Tag = "Anime";
            btnEditAnime.Visible = true;
            btnEditGenre.Visible = false;

            // Automaticky nastavíme šířku posledního sloupce, aby se roztáhl a vyplnil zbytek místa
            lstView.Columns[lstView.Columns.Count - 1].Width = -2;
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
            if (lstView.SelectedItems.Count > 0)
            {
                var selectedItem = (ListViewItem)lstView.SelectedItems[0];

                if (selectedItem.Tag is Anime selectedAnime)
                {
                    // Načteme epizody z databáze pro vybrané anime
                    var animeWithEpisodes = animeListDatabase.GetAnimeWithEpisodes(selectedAnime.Id);

                    // Otevřeme formulář pro zobrazení epizod a přidáme animeListDatabase
                    var editEpisodesForm = new EditEpisodesForm(animeWithEpisodes, animeListDatabase);
                    editEpisodesForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vyberte anime k zobrazení epizod.");
                }
            }
        }

    }
}
    