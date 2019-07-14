namespace Projektni
{
    partial class FormaPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPrijava));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBrojKartice = new System.Windows.Forms.Label();
            this.tekstBrojKarticePrijava = new System.Windows.Forms.TextBox();
            this.dugmePrijavi = new System.Windows.Forms.Button();
            this.dugmeRegistracija = new System.Windows.Forms.Button();
            this.dugmePrijavaKraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelBrojKartice
            // 
            this.labelBrojKartice.AutoSize = true;
            this.labelBrojKartice.Font = new System.Drawing.Font("Arial", 18F);
            this.labelBrojKartice.ForeColor = System.Drawing.Color.White;
            this.labelBrojKartice.Location = new System.Drawing.Point(63, 121);
            this.labelBrojKartice.Name = "labelBrojKartice";
            this.labelBrojKartice.Size = new System.Drawing.Size(139, 27);
            this.labelBrojKartice.TabIndex = 1;
            this.labelBrojKartice.Text = "Broj kartice:";
            // 
            // tekstBrojKarticePrijava
            // 
            this.tekstBrojKarticePrijava.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tekstBrojKarticePrijava.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.tekstBrojKarticePrijava.Location = new System.Drawing.Point(233, 121);
            this.tekstBrojKarticePrijava.MinimumSize = new System.Drawing.Size(2, 20);
            this.tekstBrojKarticePrijava.Name = "tekstBrojKarticePrijava";
            this.tekstBrojKarticePrijava.Size = new System.Drawing.Size(227, 27);
            this.tekstBrojKarticePrijava.TabIndex = 2;
            this.tekstBrojKarticePrijava.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tekstBrojKarticePrijava.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dugmePrijavi
            // 
            this.dugmePrijavi.BackColor = System.Drawing.Color.Gold;
            this.dugmePrijavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmePrijavi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmePrijavi.Location = new System.Drawing.Point(66, 167);
            this.dugmePrijavi.Name = "dugmePrijavi";
            this.dugmePrijavi.Size = new System.Drawing.Size(394, 39);
            this.dugmePrijavi.TabIndex = 3;
            this.dugmePrijavi.Text = "Prijavi";
            this.dugmePrijavi.UseVisualStyleBackColor = false;
            this.dugmePrijavi.Click += new System.EventHandler(this.DugmePrijavi_Click);
            // 
            // dugmeRegistracija
            // 
            this.dugmeRegistracija.BackColor = System.Drawing.Color.Gold;
            this.dugmeRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeRegistracija.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeRegistracija.Location = new System.Drawing.Point(66, 224);
            this.dugmeRegistracija.Name = "dugmeRegistracija";
            this.dugmeRegistracija.Size = new System.Drawing.Size(191, 39);
            this.dugmeRegistracija.TabIndex = 4;
            this.dugmeRegistracija.Text = "Registracija";
            this.dugmeRegistracija.UseVisualStyleBackColor = false;
            this.dugmeRegistracija.Click += new System.EventHandler(this.DugmeRegistracija_Click);
            // 
            // dugmePrijavaKraj
            // 
            this.dugmePrijavaKraj.BackColor = System.Drawing.Color.Gold;
            this.dugmePrijavaKraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmePrijavaKraj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmePrijavaKraj.Location = new System.Drawing.Point(269, 224);
            this.dugmePrijavaKraj.Name = "dugmePrijavaKraj";
            this.dugmePrijavaKraj.Size = new System.Drawing.Size(191, 39);
            this.dugmePrijavaKraj.TabIndex = 5;
            this.dugmePrijavaKraj.Text = "Kraj";
            this.dugmePrijavaKraj.UseVisualStyleBackColor = false;
            this.dugmePrijavaKraj.Click += new System.EventHandler(this.DugmePrijavaKraj_Click);
            // 
            // FormaPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(530, 359);
            this.Controls.Add(this.dugmePrijavaKraj);
            this.Controls.Add(this.dugmeRegistracija);
            this.Controls.Add(this.dugmePrijavi);
            this.Controls.Add(this.tekstBrojKarticePrijava);
            this.Controls.Add(this.labelBrojKartice);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma za prijavu";
            this.Load += new System.EventHandler(this.FormaPrijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBrojKartice;
        private System.Windows.Forms.TextBox tekstBrojKarticePrijava;
        private System.Windows.Forms.Button dugmePrijavi;
        private System.Windows.Forms.Button dugmeRegistracija;
        private System.Windows.Forms.Button dugmePrijavaKraj;
    }
}

