namespace BarkodluSatisProgrami
{
    partial class FGelirGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGelirGider));
            this.cmbodemeturu = new System.Windows.Forms.ComboBox();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.btnekle = new SATISPROGRAMIBARKODLU.bstandart();
            this.lstandart6 = new SATISPROGRAMIBARKODLU.lstandart();
            this.lstandart5 = new SATISPROGRAMIBARKODLU.lstandart();
            this.taciklama = new SATISPROGRAMIBARKODLU.tstandart();
            this.lstandart4 = new SATISPROGRAMIBARKODLU.lstandart();
            this.lstandart3 = new SATISPROGRAMIBARKODLU.lstandart();
            this.tkart = new SATISPROGRAMIBARKODLU.tnumeric();
            this.tnakit = new SATISPROGRAMIBARKODLU.tnumeric();
            this.lstandart2 = new SATISPROGRAMIBARKODLU.lstandart();
            this.lgelirgider = new SATISPROGRAMIBARKODLU.lstandart();
            this.SuspendLayout();
            // 
            // cmbodemeturu
            // 
            this.cmbodemeturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbodemeturu.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbodemeturu.FormattingEnabled = true;
            this.cmbodemeturu.Items.AddRange(new object[] {
            "NAKİT",
            "KART",
            "NAKİT-KART"});
            this.cmbodemeturu.Location = new System.Drawing.Point(54, 77);
            this.cmbodemeturu.Name = "cmbodemeturu";
            this.cmbodemeturu.Size = new System.Drawing.Size(270, 32);
            this.cmbodemeturu.TabIndex = 2;
            this.cmbodemeturu.SelectedIndexChanged += new System.EventHandler(this.cmbodemeturu_SelectedIndexChanged);
            // 
            // dttarih
            // 
            this.dttarih.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dttarih.Location = new System.Drawing.Point(54, 428);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(270, 32);
            this.dttarih.TabIndex = 10;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Tomato;
            this.btnekle.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Image = ((System.Drawing.Image)(resources.GetObject("btnekle.Image")));
            this.btnekle.Location = new System.Drawing.Point(117, 481);
            this.btnekle.Margin = new System.Windows.Forms.Padding(0);
            this.btnekle.Name = "btnekle";
            this.btnekle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnekle.Size = new System.Drawing.Size(148, 103);
            this.btnekle.TabIndex = 12;
            this.btnekle.Text = "EKLE";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // lstandart6
            // 
            this.lstandart6.AutoSize = true;
            this.lstandart6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart6.Location = new System.Drawing.Point(50, 401);
            this.lstandart6.Name = "lstandart6";
            this.lstandart6.Size = new System.Drawing.Size(66, 24);
            this.lstandart6.TabIndex = 11;
            this.lstandart6.Text = "TARİH";
            // 
            // lstandart5
            // 
            this.lstandart5.AutoSize = true;
            this.lstandart5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart5.Location = new System.Drawing.Point(50, 196);
            this.lstandart5.Name = "lstandart5";
            this.lstandart5.Size = new System.Drawing.Size(108, 24);
            this.lstandart5.TabIndex = 9;
            this.lstandart5.Text = "AÇIKLAMA";
            // 
            // taciklama
            // 
            this.taciklama.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.taciklama.Location = new System.Drawing.Point(54, 223);
            this.taciklama.Multiline = true;
            this.taciklama.Name = "taciklama";
            this.taciklama.Size = new System.Drawing.Size(270, 155);
            this.taciklama.TabIndex = 8;
            // 
            // lstandart4
            // 
            this.lstandart4.AutoSize = true;
            this.lstandart4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart4.Location = new System.Drawing.Point(50, 121);
            this.lstandart4.Name = "lstandart4";
            this.lstandart4.Size = new System.Drawing.Size(68, 24);
            this.lstandart4.TabIndex = 7;
            this.lstandart4.Text = "NAKİT";
            // 
            // lstandart3
            // 
            this.lstandart3.AutoSize = true;
            this.lstandart3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart3.Location = new System.Drawing.Point(205, 121);
            this.lstandart3.Name = "lstandart3";
            this.lstandart3.Size = new System.Drawing.Size(60, 24);
            this.lstandart3.TabIndex = 6;
            this.lstandart3.Text = "KART";
            // 
            // tkart
            // 
            this.tkart.BackColor = System.Drawing.Color.White;
            this.tkart.Enabled = false;
            this.tkart.Font = new System.Drawing.Font("Corbel", 12F);
            this.tkart.Location = new System.Drawing.Point(209, 148);
            this.tkart.Name = "tkart";
            this.tkart.Size = new System.Drawing.Size(115, 32);
            this.tkart.TabIndex = 5;
            this.tkart.Text = "0";
            this.tkart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tnakit
            // 
            this.tnakit.BackColor = System.Drawing.Color.White;
            this.tnakit.Enabled = false;
            this.tnakit.Font = new System.Drawing.Font("Corbel", 12F);
            this.tnakit.Location = new System.Drawing.Point(54, 148);
            this.tnakit.Name = "tnakit";
            this.tnakit.Size = new System.Drawing.Size(115, 32);
            this.tnakit.TabIndex = 4;
            this.tnakit.Text = "0";
            this.tnakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstandart2
            // 
            this.lstandart2.AutoSize = true;
            this.lstandart2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart2.Location = new System.Drawing.Point(50, 50);
            this.lstandart2.Name = "lstandart2";
            this.lstandart2.Size = new System.Drawing.Size(133, 24);
            this.lstandart2.TabIndex = 3;
            this.lstandart2.Text = "ÖDEME TÜRÜ";
            // 
            // lgelirgider
            // 
            this.lgelirgider.AutoSize = true;
            this.lgelirgider.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lgelirgider.ForeColor = System.Drawing.Color.DarkCyan;
            this.lgelirgider.Location = new System.Drawing.Point(50, 8);
            this.lgelirgider.Name = "lgelirgider";
            this.lgelirgider.Size = new System.Drawing.Size(124, 24);
            this.lgelirgider.TabIndex = 0;
            this.lgelirgider.Text = "GELİR GİDER";
            // 
            // FGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 594);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lstandart6);
            this.Controls.Add(this.dttarih);
            this.Controls.Add(this.lstandart5);
            this.Controls.Add(this.taciklama);
            this.Controls.Add(this.lstandart4);
            this.Controls.Add(this.lstandart3);
            this.Controls.Add(this.tkart);
            this.Controls.Add(this.tnakit);
            this.Controls.Add(this.lstandart2);
            this.Controls.Add(this.cmbodemeturu);
            this.Controls.Add(this.lgelirgider);
            this.MaximumSize = new System.Drawing.Size(401, 641);
            this.MinimumSize = new System.Drawing.Size(401, 641);
            this.Name = "FGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir Gider İşlemleri";
            this.Load += new System.EventHandler(this.FGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SATISPROGRAMIBARKODLU.lstandart lgelirgider;
        private System.Windows.Forms.ComboBox cmbodemeturu;
        private SATISPROGRAMIBARKODLU.lstandart lstandart2;
        private SATISPROGRAMIBARKODLU.tnumeric tnakit;
        private SATISPROGRAMIBARKODLU.tnumeric tkart;
        private SATISPROGRAMIBARKODLU.lstandart lstandart3;
        private SATISPROGRAMIBARKODLU.lstandart lstandart4;
        private SATISPROGRAMIBARKODLU.tstandart taciklama;
        private SATISPROGRAMIBARKODLU.lstandart lstandart5;
        private System.Windows.Forms.DateTimePicker dttarih;
        private SATISPROGRAMIBARKODLU.lstandart lstandart6;
        private SATISPROGRAMIBARKODLU.bstandart btnekle;
    }
}