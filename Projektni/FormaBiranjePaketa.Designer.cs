namespace Projektni
{
    partial class FormaBiranjePaketa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBiranjePaketa));
            this.labelOdBiranjePaketa = new System.Windows.Forms.Label();
            this.labelDoBiranjePaketa = new System.Windows.Forms.Label();
            this.dugmeIzaberiBiranjePaketa = new System.Windows.Forms.Button();
            this.dugmeOdustaniBiranjePaketa = new System.Windows.Forms.Button();
            this.dateOdBiranje = new System.Windows.Forms.DateTimePicker();
            this.dateDoBiranje = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOdBiranjePaketa
            // 
            this.labelOdBiranjePaketa.AutoSize = true;
            this.labelOdBiranjePaketa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOdBiranjePaketa.ForeColor = System.Drawing.Color.White;
            this.labelOdBiranjePaketa.Location = new System.Drawing.Point(30, 299);
            this.labelOdBiranjePaketa.Name = "labelOdBiranjePaketa";
            this.labelOdBiranjePaketa.Size = new System.Drawing.Size(44, 22);
            this.labelOdBiranjePaketa.TabIndex = 0;
            this.labelOdBiranjePaketa.Text = "Od:";
            // 
            // labelDoBiranjePaketa
            // 
            this.labelDoBiranjePaketa.AutoSize = true;
            this.labelDoBiranjePaketa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoBiranjePaketa.ForeColor = System.Drawing.Color.White;
            this.labelDoBiranjePaketa.Location = new System.Drawing.Point(30, 336);
            this.labelDoBiranjePaketa.Name = "labelDoBiranjePaketa";
            this.labelDoBiranjePaketa.Size = new System.Drawing.Size(43, 22);
            this.labelDoBiranjePaketa.TabIndex = 1;
            this.labelDoBiranjePaketa.Text = "Dо:";
            // 
            // dugmeIzaberiBiranjePaketa
            // 
            this.dugmeIzaberiBiranjePaketa.BackColor = System.Drawing.Color.Gold;
            this.dugmeIzaberiBiranjePaketa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeIzaberiBiranjePaketa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeIzaberiBiranjePaketa.Location = new System.Drawing.Point(228, 299);
            this.dugmeIzaberiBiranjePaketa.Name = "dugmeIzaberiBiranjePaketa";
            this.dugmeIzaberiBiranjePaketa.Size = new System.Drawing.Size(85, 55);
            this.dugmeIzaberiBiranjePaketa.TabIndex = 4;
            this.dugmeIzaberiBiranjePaketa.Text = "Izaberi";
            this.dugmeIzaberiBiranjePaketa.UseVisualStyleBackColor = false;
            this.dugmeIzaberiBiranjePaketa.Click += new System.EventHandler(this.dugmeIzaberiBiranjePaketa_Click);
            // 
            // dugmeOdustaniBiranjePaketa
            // 
            this.dugmeOdustaniBiranjePaketa.BackColor = System.Drawing.Color.Gold;
            this.dugmeOdustaniBiranjePaketa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeOdustaniBiranjePaketa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeOdustaniBiranjePaketa.Location = new System.Drawing.Point(319, 299);
            this.dugmeOdustaniBiranjePaketa.Name = "dugmeOdustaniBiranjePaketa";
            this.dugmeOdustaniBiranjePaketa.Size = new System.Drawing.Size(92, 55);
            this.dugmeOdustaniBiranjePaketa.TabIndex = 5;
            this.dugmeOdustaniBiranjePaketa.Text = "Odustani";
            this.dugmeOdustaniBiranjePaketa.UseVisualStyleBackColor = false;
            this.dugmeOdustaniBiranjePaketa.Click += new System.EventHandler(this.dugmeOdustaniBiranjePaketa_Click);
            // 
            // dateOdBiranje
            // 
            this.dateOdBiranje.CalendarForeColor = System.Drawing.Color.Black;
            this.dateOdBiranje.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateOdBiranje.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateOdBiranje.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateOdBiranje.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateOdBiranje.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.dateOdBiranje.Location = new System.Drawing.Point(80, 299);
            this.dateOdBiranje.Name = "dateOdBiranje";
            this.dateOdBiranje.Size = new System.Drawing.Size(132, 20);
            this.dateOdBiranje.TabIndex = 7;
            // 
            // dateDoBiranje
            // 
            this.dateDoBiranje.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.dateDoBiranje.Location = new System.Drawing.Point(80, 334);
            this.dateDoBiranje.Name = "dateDoBiranje";
            this.dateDoBiranje.Size = new System.Drawing.Size(132, 20);
            this.dateDoBiranje.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(34, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 246);
            this.panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 120;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(372, 237);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // FormaBiranjePaketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(450, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateDoBiranje);
            this.Controls.Add(this.dateOdBiranje);
            this.Controls.Add(this.dugmeOdustaniBiranjePaketa);
            this.Controls.Add(this.dugmeIzaberiBiranjePaketa);
            this.Controls.Add(this.labelDoBiranjePaketa);
            this.Controls.Add(this.labelOdBiranjePaketa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaBiranjePaketa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaBiranjePaketa";
            this.Load += new System.EventHandler(this.FormaBiranjePaketa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOdBiranjePaketa;
        private System.Windows.Forms.Label labelDoBiranjePaketa;
        private System.Windows.Forms.Button dugmeIzaberiBiranjePaketa;
        private System.Windows.Forms.Button dugmeOdustaniBiranjePaketa;
        private System.Windows.Forms.DateTimePicker dateOdBiranje;
        private System.Windows.Forms.DateTimePicker dateDoBiranje;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}