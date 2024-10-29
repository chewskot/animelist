namespace AddAnimeForm
{
    partial class AddAnimeForm1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazev = new System.Windows.Forms.TextBox();
            this.numberOfEpisodesNumeric = new System.Windows.Forms.NumericUpDown();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddedGenreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfEpisodesNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Počet epizod";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nazev Anime";
            // 
            // txtNazev
            // 
            this.txtNazev.Location = new System.Drawing.Point(117, 29);
            this.txtNazev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNazev.Name = "txtNazev";
            this.txtNazev.Size = new System.Drawing.Size(264, 26);
            this.txtNazev.TabIndex = 7;
            // 
            // numberOfEpisodesNumeric
            // 
            this.numberOfEpisodesNumeric.Location = new System.Drawing.Point(119, 81);
            this.numberOfEpisodesNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberOfEpisodesNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfEpisodesNumeric.Name = "numberOfEpisodesNumeric";
            this.numberOfEpisodesNumeric.Size = new System.Drawing.Size(262, 26);
            this.numberOfEpisodesNumeric.TabIndex = 11;
            this.numberOfEpisodesNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfEpisodesNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(117, 130);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(264, 28);
            this.GenreComboBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Žánry";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Přidat žánr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddedGenreLabel
            // 
            this.AddedGenreLabel.AutoSize = true;
            this.AddedGenreLabel.Location = new System.Drawing.Point(29, 199);
            this.AddedGenreLabel.Name = "AddedGenreLabel";
            this.AddedGenreLabel.Size = new System.Drawing.Size(51, 20);
            this.AddedGenreLabel.TabIndex = 15;
            this.AddedGenreLabel.Text = "label4";
            // 
            // AddAnimeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 263);
            this.Controls.Add(this.AddedGenreLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.numberOfEpisodesNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazev);
            this.Name = "AddAnimeForm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfEpisodesNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazev;
        private System.Windows.Forms.NumericUpDown numberOfEpisodesNumeric;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AddedGenreLabel;
    }
}

