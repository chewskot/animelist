using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class EditEpisodesForm : Form
    {
        public EditEpisodesForm()
        {
            InitializeComponent();
        }
        private Anime anime;
        private AnimeListDatabase animeListDatabase;

        public EditEpisodesForm(Anime anime, AnimeListDatabase animeListDatabase)
        {
            InitializeComponent();
            this.anime = anime;
            this.animeListDatabase = animeListDatabase;

            LoadEpisodes();
        }

        private void LoadEpisodes()
        {
            lstViewEpisodes.Items.Clear();

            // Nastavíme View na List, aby byly položky v jednotlivých řádcích
            lstViewEpisodes.View = View.List;

            foreach (var episode in anime.Epizody)
            {
                // Vytvoříme řádek textu obsahující všechny potřebné informace o epizodě
                string episodeInfo = $"{episode.Nazev} - Číslo: {episode.CisloEpizody}, Délka: {episode.Delka} min";

                // Vytvoříme položku ListView s těmito informacemi
                var item = new ListViewItem(episodeInfo)
                {
                    Tag = episode // Uložíme epizodu do Tag pro pozdější úpravy
                };

                lstViewEpisodes.Items.Add(item);
            }
        }


        private void btnEditEpisode_Click(object sender, EventArgs e)
        {
            if (lstViewEpisodes.SelectedItems.Count > 0)
            {
                var selectedItem = lstViewEpisodes.SelectedItems[0];
                if (selectedItem.Tag is Episode selectedEpisode)
                {
                    var editEpisodeForm = new EpisodeForm(selectedEpisode, animeListDatabase);
                    if (editEpisodeForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadEpisodes(); // Obnoví seznam epizod po úpravě
                    }
                }
            }
            else
            {
                MessageBox.Show("Vyberte epizodu k úpravě.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
