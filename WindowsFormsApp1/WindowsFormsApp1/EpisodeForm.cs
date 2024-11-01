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
    public partial class EpisodeForm : Form
    {
        private Episode editingEpisode;
        public EpisodeForm()
        {
            InitializeComponent();
        }
        // Konstruktor, který přijímá epizodu k úpravě
        public EpisodeForm(Episode episode)
        {
            InitializeComponent();
            this.editingEpisode = episode;
        }
        private AnimeListDatabase animeListDatabase;

        public EpisodeForm(Episode episode, AnimeListDatabase animeListDatabase)
        {
            InitializeComponent();
            this.editingEpisode = episode;
            this.animeListDatabase = animeListDatabase;
        }


        private void EpisodeForm_Load(object sender, EventArgs e)
        {
            // Načteme data epizody do ovládacích prvků
            if (editingEpisode != null)
            {
                txtEpisodeName.Text = editingEpisode.Nazev;
                numericEpisodeNumber.Value = editingEpisode.CisloEpizody;
                numericEpisodeLenght.Value = editingEpisode.Delka;
                datePickerEpisodeDate.Value = editingEpisode.DatumVydani;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editingEpisode != null)
            {
                editingEpisode.Nazev = txtEpisodeName.Text;
                editingEpisode.CisloEpizody = (int)numericEpisodeNumber.Value;
                editingEpisode.Delka = (int)numericEpisodeLenght.Value;
                editingEpisode.DatumVydani = datePickerEpisodeDate.Value;

                animeListDatabase.UpdateEpisode(editingEpisode); // Uloží změny do databáze

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
