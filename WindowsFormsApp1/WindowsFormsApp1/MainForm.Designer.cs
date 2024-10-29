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
            this.lstAnime = new System.Windows.Forms.ListBox();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animeBtn
            // 
            this.animeBtn.Location = new System.Drawing.Point(373, 191);
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
            this.btnShowAnime.Location = new System.Drawing.Point(373, 28);
            this.btnShowAnime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAnime.Name = "btnShowAnime";
            this.btnShowAnime.Size = new System.Drawing.Size(254, 29);
            this.btnShowAnime.TabIndex = 2;
            this.btnShowAnime.Text = "Ukaz Anime";
            this.btnShowAnime.UseVisualStyleBackColor = true;
            this.btnShowAnime.Click += new System.EventHandler(this.btnShowAnime_Click);
            // 
            // lstAnime
            // 
            this.lstAnime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAnime.FormattingEnabled = true;
            this.lstAnime.ItemHeight = 20;
            this.lstAnime.Location = new System.Drawing.Point(1, -1);
            this.lstAnime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstAnime.Name = "lstAnime";
            this.lstAnime.Size = new System.Drawing.Size(308, 384);
            this.lstAnime.TabIndex = 3;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(373, 263);
            this.btnAddGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(254, 29);
            this.btnAddGenre.TabIndex = 4;
            this.btnAddGenre.Text = "Pridej žánr";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ukaz Anime";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.lstAnime);
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
        private System.Windows.Forms.ListBox lstAnime;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button button1;
    }
}

