namespace BarkodluSatisProgrami
{
    partial class fLogin
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
            this.tkullaniciadi = new SATISPROGRAMIBARKODLU.tstandart();
            this.lstandart1 = new SATISPROGRAMIBARKODLU.lstandart();
            this.tsifre = new SATISPROGRAMIBARKODLU.tstandart();
            this.lstandart2 = new SATISPROGRAMIBARKODLU.lstandart();
            this.lstandart3 = new SATISPROGRAMIBARKODLU.lstandart();
            this.btngiris = new System.Windows.Forms.Button();
            this.lstandart4 = new SATISPROGRAMIBARKODLU.lstandart();
            this.SuspendLayout();
            // 
            // tkullaniciadi
            // 
            this.tkullaniciadi.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tkullaniciadi.Location = new System.Drawing.Point(156, 123);
            this.tkullaniciadi.Name = "tkullaniciadi";
            this.tkullaniciadi.Size = new System.Drawing.Size(313, 36);
            this.tkullaniciadi.TabIndex = 1;
            // 
            // lstandart1
            // 
            this.lstandart1.AutoSize = true;
            this.lstandart1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstandart1.ForeColor = System.Drawing.Color.White;
            this.lstandart1.Location = new System.Drawing.Point(12, 123);
            this.lstandart1.Name = "lstandart1";
            this.lstandart1.Size = new System.Drawing.Size(138, 28);
            this.lstandart1.TabIndex = 1;
            this.lstandart1.Text = "Kullanıcı Adı :";
            // 
            // tsifre
            // 
            this.tsifre.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsifre.Location = new System.Drawing.Point(156, 176);
            this.tsifre.Name = "tsifre";
            this.tsifre.PasswordChar = '*';
            this.tsifre.Size = new System.Drawing.Size(313, 36);
            this.tsifre.TabIndex = 2;
            // 
            // lstandart2
            // 
            this.lstandart2.AutoSize = true;
            this.lstandart2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstandart2.ForeColor = System.Drawing.Color.White;
            this.lstandart2.Location = new System.Drawing.Point(83, 176);
            this.lstandart2.Name = "lstandart2";
            this.lstandart2.Size = new System.Drawing.Size(67, 28);
            this.lstandart2.TabIndex = 1;
            this.lstandart2.Text = "Şifre :";
            // 
            // lstandart3
            // 
            this.lstandart3.AutoSize = true;
            this.lstandart3.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstandart3.ForeColor = System.Drawing.Color.White;
            this.lstandart3.Location = new System.Drawing.Point(210, 84);
            this.lstandart3.Name = "lstandart3";
            this.lstandart3.Size = new System.Drawing.Size(394, 36);
            this.lstandart3.TabIndex = 1;
            this.lstandart3.Text = "BARKODLU SATIŞ PROGRAMI";
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(475, 123);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(129, 89);
            this.btngiris.TabIndex = 3;
            this.btngiris.Text = "GİRİŞ";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // lstandart4
            // 
            this.lstandart4.AutoSize = true;
            this.lstandart4.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstandart4.ForeColor = System.Drawing.Color.White;
            this.lstandart4.Location = new System.Drawing.Point(113, 9);
            this.lstandart4.Name = "lstandart4";
            this.lstandart4.Size = new System.Drawing.Size(264, 74);
            this.lstandart4.TabIndex = 3;
            this.lstandart4.Text = "Veggi Soft";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(644, 227);
            this.Controls.Add(this.lstandart4);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.lstandart2);
            this.Controls.Add(this.lstandart3);
            this.Controls.Add(this.lstandart1);
            this.Controls.Add(this.tsifre);
            this.Controls.Add(this.tkullaniciadi);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SATISPROGRAMIBARKODLU.tstandart tkullaniciadi;
        private SATISPROGRAMIBARKODLU.lstandart lstandart1;
        private SATISPROGRAMIBARKODLU.tstandart tsifre;
        private SATISPROGRAMIBARKODLU.lstandart lstandart2;
        private SATISPROGRAMIBARKODLU.lstandart lstandart3;
        private System.Windows.Forms.Button btngiris;
        private SATISPROGRAMIBARKODLU.lstandart lstandart4;
    }
}