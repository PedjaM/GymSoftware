namespace Server
{
    partial class FormaServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaServer));
            this.dugmeUgasiServer = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dugmeUgasiServer
            // 
            this.dugmeUgasiServer.AutoSize = true;
            this.dugmeUgasiServer.BackColor = System.Drawing.Color.Gold;
            this.dugmeUgasiServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeUgasiServer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeUgasiServer.ForeColor = System.Drawing.Color.Black;
            this.dugmeUgasiServer.Location = new System.Drawing.Point(17, 40);
            this.dugmeUgasiServer.Name = "dugmeUgasiServer";
            this.dugmeUgasiServer.Size = new System.Drawing.Size(330, 31);
            this.dugmeUgasiServer.TabIndex = 7;
            this.dugmeUgasiServer.Text = "Ugasi server";
            this.dugmeUgasiServer.UseVisualStyleBackColor = false;
            this.dugmeUgasiServer.Click += new System.EventHandler(this.dugmeUgasiServer_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblServer.ForeColor = System.Drawing.Color.White;
            this.lblServer.Location = new System.Drawing.Point(106, 9);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(0, 19);
            this.lblServer.TabIndex = 8;
            // 
            // FormaServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(359, 83);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.dugmeUgasiServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormaServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dugmeUgasiServer;
        private System.Windows.Forms.Label lblServer;
    }
}

