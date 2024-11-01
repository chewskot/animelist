namespace WindowsFormsApp1
{
    partial class EpisodeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEpisodeName = new System.Windows.Forms.TextBox();
            this.numericEpisodeNumber = new System.Windows.Forms.NumericUpDown();
            this.numericEpisodeLenght = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.datePickerEpisodeDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericEpisodeNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEpisodeLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazev Epizody";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cislo Epizody";
            // 
            // txtEpisodeName
            // 
            this.txtEpisodeName.Location = new System.Drawing.Point(181, 25);
            this.txtEpisodeName.Name = "txtEpisodeName";
            this.txtEpisodeName.Size = new System.Drawing.Size(155, 26);
            this.txtEpisodeName.TabIndex = 2;
            this.txtEpisodeName.Text = " ";
            // 
            // numericEpisodeNumber
            // 
            this.numericEpisodeNumber.Location = new System.Drawing.Point(181, 77);
            this.numericEpisodeNumber.Name = "numericEpisodeNumber";
            this.numericEpisodeNumber.Size = new System.Drawing.Size(155, 26);
            this.numericEpisodeNumber.TabIndex = 3;
            // 
            // numericEpisodeLenght
            // 
            this.numericEpisodeLenght.Location = new System.Drawing.Point(181, 137);
            this.numericEpisodeLenght.Name = "numericEpisodeLenght";
            this.numericEpisodeLenght.Size = new System.Drawing.Size(155, 26);
            this.numericEpisodeLenght.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Delka Epizody";
            // 
            // datePickerEpisodeDate
            // 
            this.datePickerEpisodeDate.Location = new System.Drawing.Point(181, 196);
            this.datePickerEpisodeDate.Name = "datePickerEpisodeDate";
            this.datePickerEpisodeDate.Size = new System.Drawing.Size(200, 26);
            this.datePickerEpisodeDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum vydání";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Ulož";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(181, 283);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 41);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Zruš";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EpisodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePickerEpisodeDate);
            this.Controls.Add(this.numericEpisodeLenght);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericEpisodeNumber);
            this.Controls.Add(this.txtEpisodeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EpisodeForm";
            this.Text = "EpisodeForm";
            this.Load += new System.EventHandler(this.EpisodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericEpisodeNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEpisodeLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEpisodeName;
        private System.Windows.Forms.NumericUpDown numericEpisodeNumber;
        private System.Windows.Forms.NumericUpDown numericEpisodeLenght;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePickerEpisodeDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}