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

        private void btnShowAnime_Click(object sender, EventArgs e)
        {
            lstAnime.Items.Clear();
            var animeList = animeListDatabase.GetAnimeCollection().FindAll();
            foreach (var anime in animeList)
            {
                lstAnime.Items.Add($"{anime.Nazev} ({anime.PocetEpizod} epizod, hodnocení {anime.Hodnoceni})");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {

        }
    }
}
