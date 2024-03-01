namespace BarkodluSatisProgrami
{
    partial class fStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStok));
            this.lstandart6 = new SATISPROGRAMIBARKODLU.lstandart();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lkullanici = new SATISPROGRAMIBARKODLU.lstandart();
            this.turunara = new SATISPROGRAMIBARKODLU.tstandart();
            this.gridliste = new System.Windows.Forms.DataGridView();
            this.rburungrubunagore = new System.Windows.Forms.RadioButton();
            this.rbtumu = new System.Windows.Forms.RadioButton();
            this.lstandart2 = new SATISPROGRAMIBARKODLU.lstandart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmburungrubu = new System.Windows.Forms.ComboBox();
            this.datebitis = new System.Windows.Forms.DateTimePicker();
            this.lstandart5 = new SATISPROGRAMIBARKODLU.lstandart();
            this.datebaslangic = new System.Windows.Forms.DateTimePicker();
            this.lstandart3 = new SATISPROGRAMIBARKODLU.lstandart();
            this.lstandart4 = new SATISPROGRAMIBARKODLU.lstandart();
            this.bara = new SATISPROGRAMIBARKODLU.bstandart();
            this.paneltarihler = new System.Windows.Forms.Panel();
            this.cmbislemturu = new System.Windows.Forms.ComboBox();
            this.lstandart1 = new SATISPROGRAMIBARKODLU.lstandart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnrapor = new SATISPROGRAMIBARKODLU.bstandart();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridliste)).BeginInit();
            this.panel1.SuspendLayout();
            this.paneltarihler.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstandart6
            // 
            this.lstandart6.AutoSize = true;
            this.lstandart6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart6.Location = new System.Drawing.Point(12, 30);
            this.lstandart6.Name = "lstandart6";
            this.lstandart6.Size = new System.Drawing.Size(108, 24);
            this.lstandart6.TabIndex = 0;
            this.lstandart6.Text = "ÜRÜN ARA";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer2.Panel1.Controls.Add(this.lkullanici);
            this.splitContainer2.Panel1.Controls.Add(this.turunara);
            this.splitContainer2.Panel1.Controls.Add(this.lstandart6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridliste);
            this.splitContainer2.Size = new System.Drawing.Size(769, 603);
            this.splitContainer2.SplitterDistance = 77;
            this.splitContainer2.TabIndex = 0;
            // 
            // lkullanici
            // 
            this.lkullanici.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lkullanici.AutoSize = true;
            this.lkullanici.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lkullanici.ForeColor = System.Drawing.Color.DarkCyan;
            this.lkullanici.Location = new System.Drawing.Point(611, 32);
            this.lkullanici.Name = "lkullanici";
            this.lkullanici.Size = new System.Drawing.Size(84, 24);
            this.lkullanici.TabIndex = 2;
            this.lkullanici.Text = "Kullanıcı";
            // 
            // turunara
            // 
            this.turunara.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turunara.Location = new System.Drawing.Point(139, 25);
            this.turunara.Name = "turunara";
            this.turunara.Size = new System.Drawing.Size(313, 32);
            this.turunara.TabIndex = 1;
            this.turunara.TextChanged += new System.EventHandler(this.turunara_TextChanged);
            // 
            // gridliste
            // 
            this.gridliste.AllowUserToAddRows = false;
            this.gridliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridliste.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridliste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridliste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridliste.EnableHeadersVisualStyles = false;
            this.gridliste.Location = new System.Drawing.Point(0, 0);
            this.gridliste.Name = "gridliste";
            this.gridliste.RowHeadersVisible = false;
            this.gridliste.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridliste.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridliste.RowTemplate.Height = 24;
            this.gridliste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridliste.Size = new System.Drawing.Size(769, 522);
            this.gridliste.TabIndex = 1;
            // 
            // rburungrubunagore
            // 
            this.rburungrubunagore.AutoSize = true;
            this.rburungrubunagore.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rburungrubunagore.Location = new System.Drawing.Point(7, 81);
            this.rburungrubunagore.Name = "rburungrubunagore";
            this.rburungrubunagore.Size = new System.Drawing.Size(230, 28);
            this.rburungrubunagore.TabIndex = 4;
            this.rburungrubunagore.TabStop = true;
            this.rburungrubunagore.Text = "ÜRÜN GRUBUNA GÖRE";
            this.rburungrubunagore.UseVisualStyleBackColor = true;
            // 
            // rbtumu
            // 
            this.rbtumu.AutoSize = true;
            this.rbtumu.Checked = true;
            this.rbtumu.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtumu.Location = new System.Drawing.Point(7, 47);
            this.rbtumu.Name = "rbtumu";
            this.rbtumu.Size = new System.Drawing.Size(84, 28);
            this.rbtumu.TabIndex = 3;
            this.rbtumu.TabStop = true;
            this.rbtumu.Text = "TÜMÜ";
            this.rbtumu.UseVisualStyleBackColor = true;
            // 
            // lstandart2
            // 
            this.lstandart2.AutoSize = true;
            this.lstandart2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart2.Location = new System.Drawing.Point(3, 9);
            this.lstandart2.Name = "lstandart2";
            this.lstandart2.Size = new System.Drawing.Size(175, 24);
            this.lstandart2.TabIndex = 2;
            this.lstandart2.Text = "FİLTRELEME TÜRÜ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rburungrubunagore);
            this.panel1.Controls.Add(this.rbtumu);
            this.panel1.Controls.Add(this.lstandart2);
            this.panel1.Location = new System.Drawing.Point(3, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 122);
            this.panel1.TabIndex = 3;
            // 
            // cmburungrubu
            // 
            this.cmburungrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmburungrubu.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmburungrubu.FormattingEnabled = true;
            this.cmburungrubu.Location = new System.Drawing.Point(7, 41);
            this.cmburungrubu.Name = "cmburungrubu";
            this.cmburungrubu.Size = new System.Drawing.Size(270, 32);
            this.cmburungrubu.TabIndex = 0;
            // 
            // datebitis
            // 
            this.datebitis.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datebitis.Location = new System.Drawing.Point(9, 107);
            this.datebitis.Name = "datebitis";
            this.datebitis.Size = new System.Drawing.Size(268, 32);
            this.datebitis.TabIndex = 3;
            // 
            // lstandart5
            // 
            this.lstandart5.AutoSize = true;
            this.lstandart5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart5.Location = new System.Drawing.Point(5, 80);
            this.lstandart5.Name = "lstandart5";
            this.lstandart5.Size = new System.Drawing.Size(122, 24);
            this.lstandart5.TabIndex = 2;
            this.lstandart5.Text = "BİTİŞ TARİHİ";
            // 
            // datebaslangic
            // 
            this.datebaslangic.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datebaslangic.Location = new System.Drawing.Point(7, 36);
            this.datebaslangic.Name = "datebaslangic";
            this.datebaslangic.Size = new System.Drawing.Size(270, 32);
            this.datebaslangic.TabIndex = 1;
            // 
            // lstandart3
            // 
            this.lstandart3.AutoSize = true;
            this.lstandart3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart3.Location = new System.Drawing.Point(3, 14);
            this.lstandart3.Name = "lstandart3";
            this.lstandart3.Size = new System.Drawing.Size(135, 24);
            this.lstandart3.TabIndex = 1;
            this.lstandart3.Text = "ÜRÜN GRUBU";
            // 
            // lstandart4
            // 
            this.lstandart4.AutoSize = true;
            this.lstandart4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart4.Location = new System.Drawing.Point(3, 9);
            this.lstandart4.Name = "lstandart4";
            this.lstandart4.Size = new System.Drawing.Size(182, 24);
            this.lstandart4.TabIndex = 0;
            this.lstandart4.Text = "BAŞLANGIÇ TARİHİ";
            // 
            // bara
            // 
            this.bara.BackColor = System.Drawing.Color.Tomato;
            this.bara.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.bara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bara.ForeColor = System.Drawing.Color.White;
            this.bara.Image = ((System.Drawing.Image)(resources.GetObject("bara.Image")));
            this.bara.Location = new System.Drawing.Point(3, 503);
            this.bara.Margin = new System.Windows.Forms.Padding(0);
            this.bara.Name = "bara";
            this.bara.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bara.Size = new System.Drawing.Size(138, 76);
            this.bara.TabIndex = 0;
            this.bara.Text = "ARA";
            this.bara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bara.UseVisualStyleBackColor = false;
            this.bara.Click += new System.EventHandler(this.bara_Click);
            // 
            // paneltarihler
            // 
            this.paneltarihler.Controls.Add(this.datebitis);
            this.paneltarihler.Controls.Add(this.lstandart5);
            this.paneltarihler.Controls.Add(this.datebaslangic);
            this.paneltarihler.Controls.Add(this.lstandart4);
            this.paneltarihler.Location = new System.Drawing.Point(3, 330);
            this.paneltarihler.Name = "paneltarihler";
            this.paneltarihler.Size = new System.Drawing.Size(290, 170);
            this.paneltarihler.TabIndex = 5;
            // 
            // cmbislemturu
            // 
            this.cmbislemturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbislemturu.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbislemturu.FormattingEnabled = true;
            this.cmbislemturu.Items.AddRange(new object[] {
            "STOK DURUMU",
            "STOK GİRİŞ İZLEME"});
            this.cmbislemturu.Location = new System.Drawing.Point(7, 34);
            this.cmbislemturu.Name = "cmbislemturu";
            this.cmbislemturu.Size = new System.Drawing.Size(270, 32);
            this.cmbislemturu.TabIndex = 1;
            // 
            // lstandart1
            // 
            this.lstandart1.AutoSize = true;
            this.lstandart1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart1.Location = new System.Drawing.Point(3, 7);
            this.lstandart1.Name = "lstandart1";
            this.lstandart1.Size = new System.Drawing.Size(122, 24);
            this.lstandart1.TabIndex = 0;
            this.lstandart1.Text = "İŞLEM TÜRÜ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbislemturu);
            this.panel4.Controls.Add(this.lstandart1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 100);
            this.panel4.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.Controls.Add(this.btnrapor);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.bara);
            this.splitContainer1.Panel1.Controls.Add(this.paneltarihler);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1068, 603);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnrapor
            // 
            this.btnrapor.BackColor = System.Drawing.Color.Green;
            this.btnrapor.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnrapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrapor.ForeColor = System.Drawing.Color.White;
            this.btnrapor.Location = new System.Drawing.Point(150, 503);
            this.btnrapor.Margin = new System.Windows.Forms.Padding(0);
            this.btnrapor.Name = "btnrapor";
            this.btnrapor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnrapor.Size = new System.Drawing.Size(142, 76);
            this.btnrapor.TabIndex = 7;
            this.btnrapor.Text = "RAPOR";
            this.btnrapor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrapor.UseVisualStyleBackColor = false;
            this.btnrapor.Click += new System.EventHandler(this.btnrapor_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstandart3);
            this.panel2.Controls.Add(this.cmburungrubu);
            this.panel2.Location = new System.Drawing.Point(3, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 90);
            this.panel2.TabIndex = 4;
            // 
            // fStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 603);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fStok";
            this.Text = "fStok";
            this.Load += new System.EventHandler(this.fStok_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridliste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneltarihler.ResumeLayout(false);
            this.paneltarihler.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SATISPROGRAMIBARKODLU.lstandart lstandart6;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private SATISPROGRAMIBARKODLU.tstandart turunara;
        private System.Windows.Forms.DataGridView gridliste;
        private System.Windows.Forms.RadioButton rburungrubunagore;
        private System.Windows.Forms.RadioButton rbtumu;
        private SATISPROGRAMIBARKODLU.lstandart lstandart2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmburungrubu;
        private System.Windows.Forms.DateTimePicker datebitis;
        private SATISPROGRAMIBARKODLU.lstandart lstandart5;
        private System.Windows.Forms.DateTimePicker datebaslangic;
        private SATISPROGRAMIBARKODLU.lstandart lstandart3;
        private SATISPROGRAMIBARKODLU.lstandart lstandart4;
        private SATISPROGRAMIBARKODLU.bstandart bara;
        private System.Windows.Forms.Panel paneltarihler;
        private System.Windows.Forms.ComboBox cmbislemturu;
        private SATISPROGRAMIBARKODLU.lstandart lstandart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        internal SATISPROGRAMIBARKODLU.lstandart lkullanici;
        private SATISPROGRAMIBARKODLU.bstandart btnrapor;
    }
}