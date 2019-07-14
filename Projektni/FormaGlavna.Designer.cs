namespace Projektni
{
    partial class FormaGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaGlavna));
            this.straftaGlavna = new System.Windows.Forms.PictureBox();
            this.brojKartice = new System.Windows.Forms.Label();
            this.dugmeBiranjePaketa = new System.Windows.Forms.Button();
            this.dugmeProfil = new System.Windows.Forms.Button();
            this.dugmeIstorija = new System.Windows.Forms.Button();
            this.dugmeGlavnaKraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.straftaGlavna)).BeginInit();
            this.SuspendLayout();
            // 
            // straftaGlavna
            // 
            this.straftaGlavna.BackColor = System.Drawing.Color.Gold;
            this.straftaGlavna.Location = new System.Drawing.Point(0, 28);
            this.straftaGlavna.Name = "straftaGlavna";
            this.straftaGlavna.Size = new System.Drawing.Size(227, 34);
            this.straftaGlavna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.straftaGlavna.TabIndex = 0;
            this.straftaGlavna.TabStop = false;
            // 
            // brojKartice
            // 
            this.brojKartice.AutoSize = true;
            this.brojKartice.BackColor = System.Drawing.Color.Transparent;
            this.brojKartice.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.brojKartice.ForeColor = System.Drawing.Color.White;
            this.brojKartice.Location = new System.Drawing.Point(328, 28);
            this.brojKartice.Name = "brojKartice";
            this.brojKartice.Size = new System.Drawing.Size(0, 22);
            this.brojKartice.TabIndex = 1;
            this.brojKartice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dugmeBiranjePaketa
            // 
            this.dugmeBiranjePaketa.BackColor = System.Drawing.Color.Gold;
            this.dugmeBiranjePaketa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeBiranjePaketa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeBiranjePaketa.Location = new System.Drawing.Point(48, 99);
            this.dugmeBiranjePaketa.Name = "dugmeBiranjePaketa";
            this.dugmeBiranjePaketa.Size = new System.Drawing.Size(232, 118);
            this.dugmeBiranjePaketa.TabIndex = 2;
            this.dugmeBiranjePaketa.Text = "Biranje paketa";
            this.dugmeBiranjePaketa.UseVisualStyleBackColor = false;
            this.dugmeBiranjePaketa.Click += new System.EventHandler(this.dugmeBiranjePaketa_Click);
            // 
            // dugmeProfil
            // 
            this.dugmeProfil.BackColor = System.Drawing.Color.Gold;
            this.dugmeProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeProfil.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.dugmeProfil.Location = new System.Drawing.Point(303, 99);
            this.dugmeProfil.Name = "dugmeProfil";
            this.dugmeProfil.Size = new System.Drawing.Size(232, 118);
            this.dugmeProfil.TabIndex = 3;
            this.dugmeProfil.Text = "Profil";
            this.dugmeProfil.UseVisualStyleBackColor = false;
            this.dugmeProfil.Click += new System.EventHandler(this.dugmeProfil_Click);
            // 
            // dugmeIstorija
            // 
            this.dugmeIstorija.BackColor = System.Drawing.Color.Gold;
            this.dugmeIstorija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeIstorija.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.dugmeIstorija.Location = new System.Drawing.Point(48, 243);
            this.dugmeIstorija.Name = "dugmeIstorija";
            this.dugmeIstorija.Size = new System.Drawing.Size(232, 118);
            this.dugmeIstorija.TabIndex = 4;
            this.dugmeIstorija.Text = "Prikaz istorije";
            this.dugmeIstorija.UseVisualStyleBackColor = false;
            this.dugmeIstorija.Click += new System.EventHandler(this.dugmeIstorija_Click);
            // 
            // dugmeGlavnaKraj
            // 
            this.dugmeGlavnaKraj.BackColor = System.Drawing.Color.Gold;
            this.dugmeGlavnaKraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeGlavnaKraj.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.dugmeGlavnaKraj.Location = new System.Drawing.Point(303, 243);
            this.dugmeGlavnaKraj.Name = "dugmeGlavnaKraj";
            this.dugmeGlavnaKraj.Size = new System.Drawing.Size(232, 118);
            this.dugmeGlavnaKraj.TabIndex = 5;
            this.dugmeGlavnaKraj.Text = "Kraj";
            this.dugmeGlavnaKraj.UseVisualStyleBackColor = false;
            this.dugmeGlavnaKraj.Click += new System.EventHandler(this.DugmeGlavnaKraj_Click);
            // 
            // FormaGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(599, 428);
            this.Controls.Add(this.dugmeGlavnaKraj);
            this.Controls.Add(this.dugmeIstorija);
            this.Controls.Add(this.dugmeProfil);
            this.Controls.Add(this.dugmeBiranjePaketa);
            this.Controls.Add(this.brojKartice);
            this.Controls.Add(this.straftaGlavna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavnaForma";
            this.Load += new System.EventHandler(this.FormaGlavna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.straftaGlavna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox straftaGlavna;
        private System.Windows.Forms.Label brojKartice;
        private System.Windows.Forms.Button dugmeBiranjePaketa;
        private System.Windows.Forms.Button dugmeProfil;
        private System.Windows.Forms.Button dugmeIstorija;
        private System.Windows.Forms.Button dugmeGlavnaKraj;
    }
}