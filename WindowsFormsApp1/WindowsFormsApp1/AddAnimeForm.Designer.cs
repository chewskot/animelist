namespace WindowsFormsApp1
{
    partial class AddAnimeForm
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
            this.AddedGenreLabel = new System.Windows.Forms.Label();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfEpisodesNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSaveAnime = new System.Windows.Forms.Button();
            this.btnCancelSavingAnime = new System.Windows.Forms.Button();
            this.AddAnimeNumericRating = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfEpisodesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAnimeNumericRating)).BeginInit();
            this.SuspendLayout();
            // 
            // AddedGenreLabel
            // 
            this.AddedGenreLabel.AutoSize = true;
            this.AddedGenreLabel.Location = new System.Drawing.Point(26, 320);
            this.AddedGenreLabel.Name = "AddedGenreLabel";
            this.AddedGenreLabel.Size = new System.Drawing.Size(53, 20);
            this.AddedGenreLabel.TabIndex = 23;
            this.AddedGenreLabel.Text = "Žánry:";
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(425, 132);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(127, 29);
            this.btnAddGenre.TabIndex = 22;
            this.btnAddGenre.Text = "Přidat žánr";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Žánry";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(143, 132);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(264, 28);
            this.GenreComboBox.TabIndex = 20;
            // 
            // numberOfEpisodesNumeric
            // 
            this.numberOfEpisodesNumeric.Location = new System.Drawing.Point(145, 83);
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
            this.numberOfEpisodesNumeric.TabIndex = 19;
            this.numberOfEpisodesNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Počet epizod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nazev Anime";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 26);
            this.txtName.TabIndex = 16;
            // 
            // btnSaveAnime
            // 
            this.btnSaveAnime.Location = new System.Drawing.Point(31, 403);
            this.btnSaveAnime.Name = "btnSaveAnime";
            this.btnSaveAnime.Size = new System.Drawing.Size(125, 42);
            this.btnSaveAnime.TabIndex = 24;
            this.btnSaveAnime.Text = "Ulož Anime";
            this.btnSaveAnime.UseVisualStyleBackColor = true;
            this.btnSaveAnime.Click += new System.EventHandler(this.btnSaveAnime_Click);
            // 
            // btnCancelSavingAnime
            // 
            this.btnCancelSavingAnime.Location = new System.Drawing.Point(370, 403);
            this.btnCancelSavingAnime.Name = "btnCancelSavingAnime";
            this.btnCancelSavingAnime.Size = new System.Drawing.Size(125, 42);
            this.btnCancelSavingAnime.TabIndex = 25;
            this.btnCancelSavingAnime.Text = "Zruš Přidávání";
            this.btnCancelSavingAnime.UseVisualStyleBackColor = true;
            // 
            // AddAnimeNumericRating
            // 
            this.AddAnimeNumericRating.Location = new System.Drawing.Point(145, 178);
            this.AddAnimeNumericRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AddAnimeNumericRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AddAnimeNumericRating.Name = "AddAnimeNumericRating";
            this.AddAnimeNumericRating.Size = new System.Drawing.Size(262, 26);
            this.AddAnimeNumericRating.TabIndex = 27;
            this.AddAnimeNumericRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hodnocení";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 26);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Datum vydání";
            // 
            // AddAnimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 483);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AddAnimeNumericRating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelSavingAnime);
            this.Controls.Add(this.btnSaveAnime);
            this.Controls.Add(this.AddedGenreLabel);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.numberOfEpisodesNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "AddAnimeForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfEpisodesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAnimeNumericRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddedGenreLabel;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.NumericUpDown numberOfEpisodesNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSaveAnime;
        private System.Windows.Forms.Button btnCancelSavingAnime;
        private System.Windows.Forms.NumericUpDown AddAnimeNumericRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
    }
}