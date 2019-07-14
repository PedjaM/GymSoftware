namespace Projektni
{
    partial class FormaRegistracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaRegistracija));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dugmeRegistracijaOdustani = new System.Windows.Forms.Button();
            this.dugmeRegistruj = new System.Windows.Forms.Button();
            this.tekstImeRegistracija = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.tekstPrezimeRegistracija = new System.Windows.Forms.TextBox();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.tekstGodisteRegistracija = new System.Windows.Forms.TextBox();
            this.labelGodiste = new System.Windows.Forms.Label();
            this.tekstPolRegistracija = new System.Windows.Forms.TextBox();
            this.labelPol = new System.Windows.Forms.Label();
            this.labelGrad = new System.Windows.Forms.Label();
            this.komboGradRegistracija = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 34);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dugmeRegistracijaOdustani
            // 
            this.dugmeRegistracijaOdustani.BackColor = System.Drawing.Color.Gold;
            this.dugmeRegistracijaOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeRegistracijaOdustani.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeRegistracijaOdustani.Location = new System.Drawing.Point(273, 331);
            this.dugmeRegistracijaOdustani.Name = "dugmeRegistracijaOdustani";
            this.dugmeRegistracijaOdustani.Size = new System.Drawing.Size(191, 39);
            this.dugmeRegistracijaOdustani.TabIndex = 9;
            this.dugmeRegistracijaOdustani.Text = "Odustani";
            this.dugmeRegistracijaOdustani.UseVisualStyleBackColor = false;
            this.dugmeRegistracijaOdustani.Click += new System.EventHandler(this.DugmeRegistracijaKraj_Click);
            // 
            // dugmeRegistruj
            // 
            this.dugmeRegistruj.BackColor = System.Drawing.Color.Gold;
            this.dugmeRegistruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeRegistruj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeRegistruj.Location = new System.Drawing.Point(70, 331);
            this.dugmeRegistruj.Name = "dugmeRegistruj";
            this.dugmeRegistruj.Size = new System.Drawing.Size(191, 39);
            this.dugmeRegistruj.TabIndex = 8;
            this.dugmeRegistruj.Text = "Registruj";
            this.dugmeRegistruj.UseVisualStyleBackColor = false;
            this.dugmeRegistruj.Click += new System.EventHandler(this.DugmeRegistruj_Click);
            // 
            // tekstImeRegistracija
            // 
            this.tekstImeRegistracija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tekstImeRegistracija.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.tekstImeRegistracija.Location = new System.Drawing.Point(139, 99);
            this.tekstImeRegistracija.MinimumSize = new System.Drawing.Size(2, 20);
            this.tekstImeRegistracija.Name = "tekstImeRegistracija";
            this.tekstImeRegistracija.Size = new System.Drawing.Size(325, 27);
            this.tekstImeRegistracija.TabIndex = 7;
            this.tekstImeRegistracija.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Arial", 18F);
            this.labelIme.ForeColor = System.Drawing.Color.White;
            this.labelIme.Location = new System.Drawing.Point(67, 99);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(58, 27);
            this.labelIme.TabIndex = 6;
            this.labelIme.Text = "Ime:";
            // 
            // tekstPrezimeRegistracija
            // 
            this.tekstPrezimeRegistracija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tekstPrezimeRegistracija.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.tekstPrezimeRegistracija.Location = new System.Drawing.Point(189, 141);
            this.tekstPrezimeRegistracija.MinimumSize = new System.Drawing.Size(2, 20);
            this.tekstPrezimeRegistracija.Name = "tekstPrezimeRegistracija";
            this.tekstPrezimeRegistracija.Size = new System.Drawing.Size(275, 27);
            this.tekstPrezimeRegistracija.TabIndex = 11;
            this.tekstPrezimeRegistracija.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Font = new System.Drawing.Font("Arial", 18F);
            this.labelPrezime.ForeColor = System.Drawing.Color.White;
            this.labelPrezime.Location = new System.Drawing.Point(67, 141);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(106, 27);
            this.labelPrezime.TabIndex = 10;
            this.labelPrezime.Text = "Prezime:";
            // 
            // tekstGodisteRegistracija
            // 
            this.tekstGodisteRegistracija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tekstGodisteRegistracija.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.tekstGodisteRegistracija.Location = new System.Drawing.Point(189, 184);
            this.tekstGodisteRegistracija.MinimumSize = new System.Drawing.Size(2, 20);
            this.tekstGodisteRegistracija.Name = "tekstGodisteRegistracija";
            this.tekstGodisteRegistracija.Size = new System.Drawing.Size(275, 27);
            this.tekstGodisteRegistracija.TabIndex = 13;
            this.tekstGodisteRegistracija.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelGodiste
            // 
            this.labelGodiste.AutoSize = true;
            this.labelGodiste.Font = new System.Drawing.Font("Arial", 18F);
            this.labelGodiste.ForeColor = System.Drawing.Color.White;
            this.labelGodiste.Location = new System.Drawing.Point(67, 184);
            this.labelGodiste.Name = "labelGodiste";
            this.labelGodiste.Size = new System.Drawing.Size(102, 27);
            this.labelGodiste.TabIndex = 12;
            this.labelGodiste.Text = "Godište:";
            // 
            // tekstPolRegistracija
            // 
            this.tekstPolRegistracija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tekstPolRegistracija.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.tekstPolRegistracija.Location = new System.Drawing.Point(189, 228);
            this.tekstPolRegistracija.MinimumSize = new System.Drawing.Size(2, 20);
            this.tekstPolRegistracija.Name = "tekstPolRegistracija";
            this.tekstPolRegistracija.Size = new System.Drawing.Size(275, 27);
            this.tekstPolRegistracija.TabIndex = 15;
            this.tekstPolRegistracija.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Font = new System.Drawing.Font("Arial", 18F);
            this.labelPol.ForeColor = System.Drawing.Color.White;
            this.labelPol.Location = new System.Drawing.Point(67, 228);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(118, 27);
            this.labelPol.TabIndex = 14;
            this.labelPol.Text = "Pol (M/Z):";
            // 
            // labelGrad
            // 
            this.labelGrad.AutoSize = true;
            this.labelGrad.Font = new System.Drawing.Font("Arial", 18F);
            this.labelGrad.ForeColor = System.Drawing.Color.White;
            this.labelGrad.Location = new System.Drawing.Point(67, 273);
            this.labelGrad.Name = "labelGrad";
            this.labelGrad.Size = new System.Drawing.Size(73, 27);
            this.labelGrad.TabIndex = 16;
            this.labelGrad.Text = "Grad:";
            // 
            // komboGradRegistracija
            // 
            this.komboGradRegistracija.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.komboGradRegistracija.FormattingEnabled = true;
            this.komboGradRegistracija.ItemHeight = 19;
            this.komboGradRegistracija.Location = new System.Drawing.Point(139, 273);
            this.komboGradRegistracija.Name = "komboGradRegistracija";
            this.komboGradRegistracija.Size = new System.Drawing.Size(325, 27);
            this.komboGradRegistracija.TabIndex = 17;
            // 
            // FormaRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(553, 405);
            this.Controls.Add(this.komboGradRegistracija);
            this.Controls.Add(this.labelGrad);
            this.Controls.Add(this.tekstPolRegistracija);
            this.Controls.Add(this.labelPol);
            this.Controls.Add(this.tekstGodisteRegistracija);
            this.Controls.Add(this.labelGodiste);
            this.Controls.Add(this.tekstPrezimeRegistracija);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.dugmeRegistracijaOdustani);
            this.Controls.Add(this.dugmeRegistruj);
            this.Controls.Add(this.tekstImeRegistracija);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaRegistracija";
            this.Load += new System.EventHandler(this.FormaRegistracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dugmeRegistracijaOdustani;
        private System.Windows.Forms.Button dugmeRegistruj;
        private System.Windows.Forms.TextBox tekstImeRegistracija;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.TextBox tekstPrezimeRegistracija;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox tekstGodisteRegistracija;
        private System.Windows.Forms.Label labelGodiste;
        private System.Windows.Forms.TextBox tekstPolRegistracija;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.Label labelGrad;
        private System.Windows.Forms.ComboBox komboGradRegistracija;
    }
}