using BarkodluSatisProgrami;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SATISPROGRAMIBARKODLU
{
    public partial class fNakitKart : Form
    {
        public fNakitKart()
        {
            InitializeComponent();
        }

        private void fNakitKart_Load(object sender, EventArgs e)
        {

        }




        private void tnakit_KeyDown(object sender, KeyEventArgs e)
        {
            if (tnakit.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    hesapla();
                }

            }
        }

        private void hesapla()
        {
            Fsatis f = (Fsatis)Application.OpenForms["Fsatis"];
            double nakit = islemler.DoubleYap(tnakit.Text);
            double geneltoplam = islemler.DoubleYap(f.tgeneltoplam.Text);
            double kart = geneltoplam - nakit;
            f.lnakit.Text = nakit.ToString("C2");
            f.lkart.Text = kart.ToString("C2");
            f.satisyap("Kart-Nakit");
            this.Hide();
        }

        private void bnx_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = tnakit.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tnakit.Text += b.Text;

                }
            }
            else if (b.Text == "<")
            {
                if (tnakit.Text.Length > 0)
                {
                    tnakit.Text = tnakit.Text.Substring(0, tnakit.Text.Length - 1);
                }
            }
            else
            {
                tnakit.Text += b.Text;

            }

        }

        private void benter_Click(object sender, EventArgs e)
        {
            if (tnakit.Text != "")
            {
                hesapla();
            }

        }

        private void tnakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void fNakitKart_Load_1(object sender, EventArgs e)
        {

        }
    }
}
