namespace Projektni
{
    partial class FormaPotvrdaUplata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPotvrdaUplata));
            this.dugmeNeOdustaniUplata = new System.Windows.Forms.Button();
            this.dugmeDaUplatiUplata = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUkupnaCenaUplata = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVremeTrajanjaUplata = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dugmeNeOdustaniUplata
            // 
            this.dugmeNeOdustaniUplata.BackColor = System.Drawing.Color.Gold;
            this.dugmeNeOdustaniUplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeNeOdustaniUplata.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeNeOdustaniUplata.ForeColor = System.Drawing.Color.Black;
            this.dugmeNeOdustaniUplata.Location = new System.Drawing.Point(179, 100);
            this.dugmeNeOdustaniUplata.Name = "dugmeNeOdustaniUplata";
            this.dugmeNeOdustaniUplata.Size = new System.Drawing.Size(136, 39);
            this.dugmeNeOdustaniUplata.TabIndex = 33;
            this.dugmeNeOdustaniUplata.Text = "Odustani";
            this.dugmeNeOdustaniUplata.UseVisualStyleBackColor = false;
            this.dugmeNeOdustaniUplata.Click += new System.EventHandler(this.dugmeNeOdustaniUplata_Click);
            // 
            // dugmeDaUplatiUplata
            // 
            this.dugmeDaUplatiUplata.BackColor = System.Drawing.Color.Gold;
            this.dugmeDaUplatiUplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDaUplatiUplata.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeDaUplatiUplata.ForeColor = System.Drawing.Color.Black;
            this.dugmeDaUplatiUplata.Location = new System.Drawing.Point(24, 100);
            this.dugmeDaUplatiUplata.Name = "dugmeDaUplatiUplata";
            this.dugmeDaUplatiUplata.Size = new System.Drawing.Size(136, 39);
            this.dugmeDaUplatiUplata.TabIndex = 34;
            this.dugmeDaUplatiUplata.Text = "Uplati";
            this.dugmeDaUplatiUplata.UseVisualStyleBackColor = false;
            this.dugmeDaUplatiUplata.Click += new System.EventHandler(this.dugmeDaUplatiUplata_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtUkupnaCenaUplata);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtVremeTrajanjaUplata);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(291, 61);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukupna cena:";
            // 
            // txtUkupnaCenaUplata
            // 
            this.txtUkupnaCenaUplata.AutoSize = true;
            this.txtUkupnaCenaUplata.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.txtUkupnaCenaUplata.Location = new System.Drawing.Point(141, 0);
            this.txtUkupnaCenaUplata.Name = "txtUkupnaCenaUplata";
            this.txtUkupnaCenaUplata.Size = new System.Drawing.Size(80, 23);
            this.txtUkupnaCenaUplata.TabIndex = 1;
            this.txtUkupnaCenaUplata.Text = "0,00 din";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vreme trajanja:";
            // 
            // txtVremeTrajanjaUplata
            // 
            this.txtVremeTrajanjaUplata.AutoSize = true;
            this.txtVremeTrajanjaUplata.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.txtVremeTrajanjaUplata.Location = new System.Drawing.Point(154, 23);
            this.txtVremeTrajanjaUplata.Name = "txtVremeTrajanjaUplata";
            this.txtVremeTrajanjaUplata.Size = new System.Drawing.Size(81, 23);
            this.txtVremeTrajanjaUplata.TabIndex = 3;
            this.txtVremeTrajanjaUplata.Text = "15 dana";
            // 
            // FormaPotvrdaUplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(344, 151);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dugmeDaUplatiUplata);
            this.Controls.Add(this.dugmeNeOdustaniUplata);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormaPotvrdaUplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaPotvrdaUplata";
            this.Load += new System.EventHandler(this.FormaPotvrdaUplata_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dugmeNeOdustaniUplata;
        private System.Windows.Forms.Button dugmeDaUplatiUplata;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUkupnaCenaUplata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtVremeTrajanjaUplata;
    }
}