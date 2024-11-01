namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animeBtn = new System.Windows.Forms.Button();
            this.btnShowAnime = new System.Windows.Forms.Button();
            this.lstView = new System.Windows.Forms.ListBox();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnShowGenre = new System.Windows.Forms.Button();
            this.btnRemoveAnime = new System.Windows.Forms.Button();
            this.btnEditAnime = new System.Windows.Forms.Button();
            this.btnEditGenre = new System.Windows.Forms.Button();
            this.btnEditEpisode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animeBtn
            // 
            this.animeBtn.Location = new System.Drawing.Point(883, 182);
            this.animeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.animeBtn.Name = "animeBtn";
            this.animeBtn.Size = new System.Drawing.Size(254, 29);
            this.animeBtn.TabIndex = 0;
            this.animeBtn.Text = "Pridej Anime";
            this.animeBtn.UseVisualStyleBackColor = true;
            this.animeBtn.Click += new System.EventHandler(this.animeBtn_Click);
            // 
            // btnShowAnime
            // 
            this.btnShowAnime.Location = new System.Drawing.Point(883, 24);
            this.btnShowAnime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAnime.Name = "btnShowAnime";
            this.btnShowAnime.Size = new System.Drawing.Size(254, 29);
            this.btnShowAnime.TabIndex = 2;
            this.btnShowAnime.Text = "Ukaz Anime";
            this.btnShowAnime.UseVisualStyleBackColor = true;
            this.btnShowAnime.Click += new System.EventHandler(this.btnShowAnime_Click);
            // 
            // lstView
            // 
            this.lstView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstView.FormattingEnabled = true;
            this.lstView.ItemHeight = 20;
            this.lstView.Location = new System.Drawing.Point(1, -1);
            this.lstView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(686, 644);
            this.lstView.TabIndex = 3;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(883, 254);
            this.btnAddGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(254, 29);
            this.btnAddGenre.TabIndex = 4;
            this.btnAddGenre.Text = "Pridej žánr";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnShowGenre
            // 
            this.btnShowGenre.Location = new System.Drawing.Point(883, 106);
            this.btnShowGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowGenre.Name = "btnShowGenre";
            this.btnShowGenre.Size = new System.Drawing.Size(254, 29);
            this.btnShowGenre.TabIndex = 5;
            this.btnShowGenre.Text = "Ukaz Zanr";
            this.btnShowGenre.UseVisualStyleBackColor = true;
            this.btnShowGenre.Click += new System.EventHandler(this.btnShowGenre_Click);
            // 
            // btnRemoveAnime
            // 
            this.btnRemoveAnime.Location = new System.Drawing.Point(883, 330);
            this.btnRemoveAnime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveAnime.Name = "btnRemoveAnime";
            this.btnRemoveAnime.Size = new System.Drawing.Size(254, 29);
            this.btnRemoveAnime.TabIndex = 6;
            this.btnRemoveAnime.Text = "Odeber Anime / Žánr";
            this.btnRemoveAnime.UseVisualStyleBackColor = true;
            this.btnRemoveAnime.Click += new System.EventHandler(this.btnRemoveAnime_Click);
            // 
            // btnEditAnime
            // 
            this.btnEditAnime.Location = new System.Drawing.Point(883, 399);
            this.btnEditAnime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditAnime.Name = "btnEditAnime";
            this.btnEditAnime.Size = new System.Drawing.Size(254, 29);
            this.btnEditAnime.TabIndex = 7;
            this.btnEditAnime.Text = "Uprav Anime";
            this.btnEditAnime.UseVisualStyleBackColor = true;
            this.btnEditAnime.Click += new System.EventHandler(this.btnEditAnime_Click);
            // 
            // btnEditGenre
            // 
            this.btnEditGenre.Location = new System.Drawing.Point(883, 470);
            this.btnEditGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditGenre.Name = "btnEditGenre";
            this.btnEditGenre.Size = new System.Drawing.Size(254, 29);
            this.btnEditGenre.TabIndex = 8;
            this.btnEditGenre.Text = "Uprav Zanr";
            this.btnEditGenre.UseVisualStyleBackColor = true;
            this.btnEditGenre.Click += new System.EventHandler(this.btnEditGenre_Click);
            // 
            // btnEditEpisode
            // 
            this.btnEditEpisode.Location = new System.Drawing.Point(883, 537);
            this.btnEditEpisode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditEpisode.Name = "btnEditEpisode";
            this.btnEditEpisode.Size = new System.Drawing.Size(254, 29);
            this.btnEditEpisode.TabIndex = 9;
            this.btnEditEpisode.Text = "Uprav Epizody";
            this.btnEditEpisode.UseVisualStyleBackColor = true;
            this.btnEditEpisode.Click += new System.EventHandler(this.btnEditEpisode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 651);
            this.Controls.Add(this.btnEditEpisode);
            this.Controls.Add(this.btnEditGenre);
            this.Controls.Add(this.btnEditAnime);
            this.Controls.Add(this.btnRemoveAnime);
            this.Controls.Add(this.btnShowGenre);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.btnShowAnime);
            this.Controls.Add(this.animeBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button animeBtn;
        private System.Windows.Forms.Button btnShowAnime;
        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnShowGenre;
        private System.Windows.Forms.Button btnRemoveAnime;
        private System.Windows.Forms.Button btnEditAnime;
        private System.Windows.Forms.Button btnEditGenre;
        private System.Windows.Forms.Button btnEditEpisode;
    }
}

