using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AddAnimeForm
{
    public partial class AddAnimeForm1 : Form
    {
        private AnimeListDatabase _animeListDatabase;
        public AddAnimeForm1(AnimeListDatabase animeListDatabase)
        {
            InitializeComponent();
            _animeListDatabase = animeListDatabase;
            LoadGenres();
        }

        public AddAnimeForm1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void LoadGenres()
        {
            var genres = _animeListDatabase.GetGenreCollection().FindAll().ToList();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
