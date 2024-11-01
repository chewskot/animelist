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
    public partial class EditEpisodesForm : Form
    {
        public EditEpisodesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            //listViewEpisodes.Items.Clear();

            //foreach (var episode in anime.Epizody)
            //{
            //    var item = new ListViewItem(new[] { episode.CisloEpizody.ToString(), episode.Nazev, episode.Delka.ToString(), episode.DatumVydani.ToShortDateString() });
            //    item.Tag = episode; // Uložíme epizodu do Tag pro úpravy
            //    listViewEpisodes.Items.Add(item);
            //}
        }

        private void btnEditSelectedEpisode_Click(object sender, EventArgs e)
        {
            //if (listViewEpisodes.SelectedItems.Count > 0)
            //{
            //    var selectedItem = listViewEpisodes.SelectedItems[0];
            //    if (selectedItem.Tag is Episode selectedEpisode)
            //    {
            //        // Otevřeme dialog pro úpravu epizody
            //        var editEpisodeForm = new EditEpisodeForm(selectedEpisode, animeListDatabase);
            //        if (editEpisodeForm.ShowDialog() == DialogResult.OK)
            //        {
            //            LoadEpisodes(); // Aktualizujeme seznam epizod po úpravě
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vyberte epizodu k úpravě.");
            //}
        }
    }
}
