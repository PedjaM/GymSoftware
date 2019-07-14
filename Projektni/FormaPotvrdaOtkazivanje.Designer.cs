namespace Projektni
{
    partial class FormaPotvrdaOtkazivanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPotvrdaOtkazivanje));
            this.dugmeDugmeNeOtkaziPaket = new System.Windows.Forms.Button();
            this.dugmeDaOtkaziPaket = new System.Windows.Forms.Button();
            this.labelTekstOtkazivanje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dugmeDugmeNeOtkaziPaket
            // 
            this.dugmeDugmeNeOtkaziPaket.BackColor = System.Drawing.Color.Gold;
            this.dugmeDugmeNeOtkaziPaket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDugmeNeOtkaziPaket.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeDugmeNeOtkaziPaket.Location = new System.Drawing.Point(179, 123);
            this.dugmeDugmeNeOtkaziPaket.Name = "dugmeDugmeNeOtkaziPaket";
            this.dugmeDugmeNeOtkaziPaket.Size = new System.Drawing.Size(136, 39);
            this.dugmeDugmeNeOtkaziPaket.TabIndex = 32;
            this.dugmeDugmeNeOtkaziPaket.Text = "Odustani";
            this.dugmeDugmeNeOtkaziPaket.UseVisualStyleBackColor = false;
            this.dugmeDugmeNeOtkaziPaket.Click += new System.EventHandler(this.dugmeDugmeNeOtkaziPaket_Click);
            // 
            // dugmeDaOtkaziPaket
            // 
            this.dugmeDaOtkaziPaket.BackColor = System.Drawing.Color.Gold;
            this.dugmeDaOtkaziPaket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDaOtkaziPaket.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeDaOtkaziPaket.Location = new System.Drawing.Point(28, 123);
            this.dugmeDaOtkaziPaket.Name = "dugmeDaOtkaziPaket";
            this.dugmeDaOtkaziPaket.Size = new System.Drawing.Size(136, 39);
            this.dugmeDaOtkaziPaket.TabIndex = 31;
            this.dugmeDaOtkaziPaket.Text = "Otkaži";
            this.dugmeDaOtkaziPaket.UseVisualStyleBackColor = false;
            this.dugmeDaOtkaziPaket.Click += new System.EventHandler(this.dugmeDaOtkaziPaket_Click);
            // 
            // labelTekstOtkazivanje
            // 
            this.labelTekstOtkazivanje.AutoSize = true;
            this.labelTekstOtkazivanje.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTekstOtkazivanje.ForeColor = System.Drawing.Color.White;
            this.labelTekstOtkazivanje.Location = new System.Drawing.Point(24, 42);
            this.labelTekstOtkazivanje.Name = "labelTekstOtkazivanje";
            this.labelTekstOtkazivanje.Size = new System.Drawing.Size(0, 19);
            this.labelTekstOtkazivanje.TabIndex = 33;
            // 
            // FormaPotvrdaOtkazivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(359, 192);
            this.Controls.Add(this.labelTekstOtkazivanje);
            this.Controls.Add(this.dugmeDugmeNeOtkaziPaket);
            this.Controls.Add(this.dugmeDaOtkaziPaket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaPotvrdaOtkazivanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaPotvrdaOtkazivanje";
            this.Load += new System.EventHandler(this.FormaPotvrdaOtkazivanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dugmeDugmeNeOtkaziPaket;
        private System.Windows.Forms.Button dugmeDaOtkaziPaket;
        private System.Windows.Forms.Label labelTekstOtkazivanje;
    }
}