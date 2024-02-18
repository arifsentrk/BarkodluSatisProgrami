namespace SATISPROGRAMIBARKODLU
{
    partial class FHizliButonUrunEkle
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbutonid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chtumu = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.turunara = new System.Windows.Forms.TextBox();
            this.gridurunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridurunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbutonid);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.chtumu);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.turunara);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridurunler);
            this.splitContainer1.Size = new System.Drawing.Size(1155, 538);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbutonid
            // 
            this.lbutonid.AutoSize = true;
            this.lbutonid.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbutonid.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbutonid.Location = new System.Drawing.Point(204, 21);
            this.lbutonid.Name = "lbutonid";
            this.lbutonid.Size = new System.Drawing.Size(111, 24);
            this.lbutonid.TabIndex = 8;
            this.lbutonid.Text = "BUTON NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "BUTON NUMARASI :";
            // 
            // chtumu
            // 
            this.chtumu.AutoSize = true;
            this.chtumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chtumu.ForeColor = System.Drawing.Color.DarkCyan;
            this.chtumu.Location = new System.Drawing.Point(355, 101);
            this.chtumu.Name = "chtumu";
            this.chtumu.Size = new System.Drawing.Size(191, 24);
            this.chtumu.TabIndex = 6;
            this.chtumu.Text = "TÜMÜNÜ GÖSTER";
            this.chtumu.UseVisualStyleBackColor = true;
            this.chtumu.CheckedChanged += new System.EventHandler(this.chtumu_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "ÜRÜN ARA";
            // 
            // turunara
            // 
            this.turunara.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turunara.Location = new System.Drawing.Point(17, 96);
            this.turunara.Name = "turunara";
            this.turunara.Size = new System.Drawing.Size(313, 32);
            this.turunara.TabIndex = 4;
            this.turunara.TextChanged += new System.EventHandler(this.turunara_TextChanged);
            // 
            // gridurunler
            // 
            this.gridurunler.AllowUserToAddRows = false;
            this.gridurunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridurunler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridurunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridurunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridurunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridurunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridurunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridurunler.EnableHeadersVisualStyles = false;
            this.gridurunler.Location = new System.Drawing.Point(0, 0);
            this.gridurunler.Name = "gridurunler";
            this.gridurunler.RowHeadersVisible = false;
            this.gridurunler.RowHeadersWidth = 51;
            this.gridurunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridurunler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridurunler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridurunler.RowTemplate.Height = 30;
            this.gridurunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridurunler.Size = new System.Drawing.Size(1155, 389);
            this.gridurunler.TabIndex = 2;
            this.gridurunler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridurunler_CellContentDoubleClick);
            // 
            // FHizliButonUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1155, 538);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FHizliButonUrunEkle";
            this.Text = "Hizli Buton Ürün Ekleme";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridurunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridurunler;
        private System.Windows.Forms.CheckBox chtumu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox turunara;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbutonid;
    }
}