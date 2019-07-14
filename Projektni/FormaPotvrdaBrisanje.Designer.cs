namespace Projektni
{
    partial class FormaPotvrdaBrisanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPotvrdaBrisanje));
            this.labelTekstBrisanje = new System.Windows.Forms.Label();
            this.dugmeNeOdustaniProfil = new System.Windows.Forms.Button();
            this.dugmeDaObrisiProfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTekstBrisanje
            // 
            this.labelTekstBrisanje.AutoSize = true;
            this.labelTekstBrisanje.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTekstBrisanje.ForeColor = System.Drawing.Color.White;
            this.labelTekstBrisanje.Location = new System.Drawing.Point(24, 42);
            this.labelTekstBrisanje.Name = "labelTekstBrisanje";
            this.labelTekstBrisanje.Size = new System.Drawing.Size(0, 19);
            this.labelTekstBrisanje.TabIndex = 0;
            this.labelTekstBrisanje.Click += new System.EventHandler(this.label1_Click);
            // 
            // dugmeNeOdustaniProfil
            // 
            this.dugmeNeOdustaniProfil.BackColor = System.Drawing.Color.Gold;
            this.dugmeNeOdustaniProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeNeOdustaniProfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeNeOdustaniProfil.Location = new System.Drawing.Point(180, 117);
            this.dugmeNeOdustaniProfil.Name = "dugmeNeOdustaniProfil";
            this.dugmeNeOdustaniProfil.Size = new System.Drawing.Size(136, 39);
            this.dugmeNeOdustaniProfil.TabIndex = 32;
            this.dugmeNeOdustaniProfil.Text = "Ne, odustani";
            this.dugmeNeOdustaniProfil.UseVisualStyleBackColor = false;
            this.dugmeNeOdustaniProfil.Click += new System.EventHandler(this.dugmeNeOdustaniProfil_Click);
            // 
            // dugmeDaObrisiProfil
            // 
            this.dugmeDaObrisiProfil.BackColor = System.Drawing.Color.Gold;
            this.dugmeDaObrisiProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDaObrisiProfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeDaObrisiProfil.Location = new System.Drawing.Point(28, 117);
            this.dugmeDaObrisiProfil.Name = "dugmeDaObrisiProfil";
            this.dugmeDaObrisiProfil.Size = new System.Drawing.Size(139, 39);
            this.dugmeDaObrisiProfil.TabIndex = 31;
            this.dugmeDaObrisiProfil.Text = "Da, obriši";
            this.dugmeDaObrisiProfil.UseVisualStyleBackColor = false;
            this.dugmeDaObrisiProfil.Click += new System.EventHandler(this.dugmeDaObrisiProfil_Click);
            // 
            // FormaPotvrdaBrisanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(359, 192);
            this.Controls.Add(this.dugmeNeOdustaniProfil);
            this.Controls.Add(this.dugmeDaObrisiProfil);
            this.Controls.Add(this.labelTekstBrisanje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaPotvrdaBrisanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaPotvrdaBrisanje";
            this.Load += new System.EventHandler(this.FormaPotvrdaBrisanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTekstBrisanje;
        private System.Windows.Forms.Button dugmeNeOdustaniProfil;
        private System.Windows.Forms.Button dugmeDaObrisiProfil;
    }
}