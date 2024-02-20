namespace SATISPROGRAMIBARKODLU
{
    partial class fUrunGrubuEkle
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
            this.btnekle = new SATISPROGRAMIBARKODLU.bstandart();
            this.listboxekle = new System.Windows.Forms.ListBox();
            this.turungrubuadi = new SATISPROGRAMIBARKODLU.tstandart();
            this.lstandart1 = new SATISPROGRAMIBARKODLU.lstandart();
            this.bsil = new SATISPROGRAMIBARKODLU.bstandart();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnekle.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(206, 342);
            this.btnekle.Margin = new System.Windows.Forms.Padding(0);
            this.btnekle.Name = "btnekle";
            this.btnekle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnekle.Size = new System.Drawing.Size(151, 103);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "EKLE";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // listboxekle
            // 
            this.listboxekle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listboxekle.FormattingEnabled = true;
            this.listboxekle.ItemHeight = 24;
            this.listboxekle.Location = new System.Drawing.Point(44, 86);
            this.listboxekle.Name = "listboxekle";
            this.listboxekle.Size = new System.Drawing.Size(313, 244);
            this.listboxekle.TabIndex = 6;
            // 
            // turungrubuadi
            // 
            this.turungrubuadi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turungrubuadi.Location = new System.Drawing.Point(44, 28);
            this.turungrubuadi.Name = "turungrubuadi";
            this.turungrubuadi.Size = new System.Drawing.Size(313, 32);
            this.turungrubuadi.TabIndex = 5;
            // 
            // lstandart1
            // 
            this.lstandart1.AutoSize = true;
            this.lstandart1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lstandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart1.Location = new System.Drawing.Point(40, 1);
            this.lstandart1.Name = "lstandart1";
            this.lstandart1.Size = new System.Drawing.Size(171, 24);
            this.lstandart1.TabIndex = 4;
            this.lstandart1.Text = "ÜRÜN GRUBU ADI";
            // 
            // bsil
            // 
            this.bsil.BackColor = System.Drawing.Color.Tomato;
            this.bsil.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.bsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bsil.ForeColor = System.Drawing.Color.White;
            this.bsil.Location = new System.Drawing.Point(44, 342);
            this.bsil.Margin = new System.Windows.Forms.Padding(0);
            this.bsil.Name = "bsil";
            this.bsil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bsil.Size = new System.Drawing.Size(150, 103);
            this.bsil.TabIndex = 7;
            this.bsil.Text = "SİL";
            this.bsil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bsil.UseVisualStyleBackColor = false;
            this.bsil.Click += new System.EventHandler(this.bsil_Click);
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 447);
            this.Controls.Add(this.bsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.listboxekle);
            this.Controls.Add(this.turungrubuadi);
            this.Controls.Add(this.lstandart1);
            this.Name = "fUrunGrubuEkle";
            this.Text = "fUrunGrubuEkle";
            this.Load += new System.EventHandler(this.fUrunGrubuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bstandart btnekle;
        private System.Windows.Forms.ListBox listboxekle;
        private tstandart turungrubuadi;
        private lstandart lstandart1;
        private bstandart bsil;
    }
}