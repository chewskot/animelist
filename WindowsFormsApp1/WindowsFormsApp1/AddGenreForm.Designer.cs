namespace WindowsFormsApp1
{
    partial class AddGenreForm
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
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.txtGenreDescription = new System.Windows.Forms.TextBox();
            this.btnAddGenreOk = new System.Windows.Forms.Button();
            this.btnAddGenreCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazev žánru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Popis žánru";
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(212, 47);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(100, 26);
            this.txtGenreName.TabIndex = 2;
            // 
            // txtGenreDescription
            // 
            this.txtGenreDescription.Location = new System.Drawing.Point(212, 135);
            this.txtGenreDescription.Name = "txtGenreDescription";
            this.txtGenreDescription.Size = new System.Drawing.Size(100, 26);
            this.txtGenreDescription.TabIndex = 3;
            // 
            // btnAddGenreOk
            // 
            this.btnAddGenreOk.Location = new System.Drawing.Point(63, 231);
            this.btnAddGenreOk.Name = "btnAddGenreOk";
            this.btnAddGenreOk.Size = new System.Drawing.Size(88, 46);
            this.btnAddGenreOk.TabIndex = 4;
            this.btnAddGenreOk.Text = "OK";
            this.btnAddGenreOk.UseVisualStyleBackColor = true;
            this.btnAddGenreOk.Click += new System.EventHandler(this.btnAddGenreOk_Click);
            // 
            // btnAddGenreCancel
            // 
            this.btnAddGenreCancel.Location = new System.Drawing.Point(212, 231);
            this.btnAddGenreCancel.Name = "btnAddGenreCancel";
            this.btnAddGenreCancel.Size = new System.Drawing.Size(88, 46);
            this.btnAddGenreCancel.TabIndex = 5;
            this.btnAddGenreCancel.Text = "Zrus";
            this.btnAddGenreCancel.UseVisualStyleBackColor = true;
            this.btnAddGenreCancel.Click += new System.EventHandler(this.btnAddGenreCancel_Click);
            // 
            // AddGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 289);
            this.Controls.Add(this.btnAddGenreCancel);
            this.Controls.Add(this.btnAddGenreOk);
            this.Controls.Add(this.txtGenreDescription);
            this.Controls.Add(this.txtGenreName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddGenreForm";
            this.Text = "AddGenreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.TextBox txtGenreDescription;
        private System.Windows.Forms.Button btnAddGenreOk;
        private System.Windows.Forms.Button btnAddGenreCancel;
    }
}