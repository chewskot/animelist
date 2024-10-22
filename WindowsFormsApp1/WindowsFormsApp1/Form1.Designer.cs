namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtNazev = new System.Windows.Forms.TextBox();
            this.btnShowAnime = new System.Windows.Forms.Button();
            this.lstAnime = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // animeBtn
            // 
            this.animeBtn.Location = new System.Drawing.Point(373, 37);
            this.animeBtn.Name = "animeBtn";
            this.animeBtn.Size = new System.Drawing.Size(101, 23);
            this.animeBtn.TabIndex = 0;
            this.animeBtn.Text = "Pridej Anime";
            this.animeBtn.UseVisualStyleBackColor = true;
            this.animeBtn.Click += new System.EventHandler(this.animeBtn_Click);
            // 
            // txtNazev
            // 
            this.txtNazev.Location = new System.Drawing.Point(373, 98);
            this.txtNazev.Name = "txtNazev";
            this.txtNazev.Size = new System.Drawing.Size(100, 22);
            this.txtNazev.TabIndex = 1;
            // 
            // btnShowAnime
            // 
            this.btnShowAnime.Location = new System.Drawing.Point(373, 218);
            this.btnShowAnime.Name = "btnShowAnime";
            this.btnShowAnime.Size = new System.Drawing.Size(117, 23);
            this.btnShowAnime.TabIndex = 2;
            this.btnShowAnime.Text = "Ukaz Anime";
            this.btnShowAnime.UseVisualStyleBackColor = true;
            this.btnShowAnime.Click += new System.EventHandler(this.btnShowAnime_Click);
            // 
            // lstAnime
            // 
            this.lstAnime.FormattingEnabled = true;
            this.lstAnime.ItemHeight = 16;
            this.lstAnime.Location = new System.Drawing.Point(12, 36);
            this.lstAnime.Name = "lstAnime";
            this.lstAnime.Size = new System.Drawing.Size(120, 84);
            this.lstAnime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazev Anime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAnime);
            this.Controls.Add(this.btnShowAnime);
            this.Controls.Add(this.txtNazev);
            this.Controls.Add(this.animeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button animeBtn;
        private System.Windows.Forms.TextBox txtNazev;
        private System.Windows.Forms.Button btnShowAnime;
        private System.Windows.Forms.ListBox lstAnime;
        private System.Windows.Forms.Label label1;
    }
}

