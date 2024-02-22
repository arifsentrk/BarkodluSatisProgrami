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
    public partial class FHizliButonUrunEkle : Form
    {
        public FHizliButonUrunEkle()
        {
            InitializeComponent();
        }

        BarkodluSatisEntities db = new BarkodluSatisEntities();

        private void turunara_TextChanged(object sender, EventArgs e)
        {
            if (turunara.Text != "")
            {
                string urunad = turunara.Text;
                var urunler = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
                gridurunler.DataSource = urunler;
                islemler.Gridduzenle(gridurunler);
            }
        }

        private void gridurunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridurunler.Rows.Count > 0)
            {
                string barkod = gridurunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunad = gridurunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                double fiyat = Convert.ToDouble(gridurunler.CurrentRow.Cells["SatisFiyati"].Value.ToString());
                int id = Convert.ToInt16(lbutonid.Text);
                var guncellenecek = db.HizliUrun.Find(id);
                guncellenecek.Barkod = barkod;
                guncellenecek.Urun = urunad;
                guncellenecek.Fiyat = fiyat;
                db.SaveChanges();
                MessageBox.Show("Buton Tanımlanmıştır.");
                Fsatis f = (Fsatis)Application.OpenForms["fsatis"];
                if (f != null)
                {
                    Button b = f.Controls.Find("bh" + id, true).FirstOrDefault() as Button;
                    b.Text = urunad + " \n " + fiyat.ToString("C2");

                }

            }
        }

        private void chtumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chtumu.Checked)
            {
                gridurunler.DataSource = db.Urun.ToList();
                gridurunler.Columns["AlisFiyati"].Visible = false;
                gridurunler.Columns["SatisFiyati"].Visible = false;
                gridurunler.Columns["KdvOrani"].Visible = false;
                gridurunler.Columns["KdvTutari"].Visible = false;
                gridurunler.Columns["Miktar"].Visible = false;
                islemler.Gridduzenle(gridurunler);

            }
            else
            {
                gridurunler.DataSource = null;
            }
        }

        
    }
}
