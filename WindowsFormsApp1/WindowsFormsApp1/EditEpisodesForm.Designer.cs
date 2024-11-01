namespace WindowsFormsApp1
{
    partial class EditEpisodesForm
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
            this.btnEditEpisode = new System.Windows.Forms.Button();
            this.lstViewEpisodes = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditEpisode
            // 
            this.btnEditEpisode.Location = new System.Drawing.Point(419, 78);
            this.btnEditEpisode.Name = "btnEditEpisode";
            this.btnEditEpisode.Size = new System.Drawing.Size(146, 44);
            this.btnEditEpisode.TabIndex = 0;
            this.btnEditEpisode.Text = "Edituj Epizodu";
            this.btnEditEpisode.UseVisualStyleBackColor = true;
            this.btnEditEpisode.Click += new System.EventHandler(this.btnEditEpisode_Click);
            // 
            // lstViewEpisodes
            // 
            this.lstViewEpisodes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstViewEpisodes.HideSelection = false;
            this.lstViewEpisodes.Location = new System.Drawing.Point(0, 0);
            this.lstViewEpisodes.Name = "lstViewEpisodes";
            this.lstViewEpisodes.Size = new System.Drawing.Size(375, 365);
            this.lstViewEpisodes.TabIndex = 1;
            this.lstViewEpisodes.UseCompatibleStateImageBehavior = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(419, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Zavři okno";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EditEpisodesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 365);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstViewEpisodes);
            this.Controls.Add(this.btnEditEpisode);
            this.Name = "EditEpisodesForm";
            this.Text = "EditEpisodesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditEpisode;
        private System.Windows.Forms.ListView lstViewEpisodes;
        private System.Windows.Forms.Button btnClose;
    }
}