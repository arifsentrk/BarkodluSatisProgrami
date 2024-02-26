using BarkodluSatisProgrami;
using SATISPROGRAMIBARKODLU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatisProgrami
{
    public partial class fUrunGiris : Form
    {
        public fUrunGiris()
        {
            InitializeComponent();
        }

        BarkodluSatisEntities db = new BarkodluSatisEntities();

        private void tbarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tbarkod.Text.Trim();
                if (db.Urun.Any(a => a.Barkod == barkod))
                {

                    var urun = db.Urun.Where(a => a.Barkod == barkod).SingleOrDefault();
                    turunadi.Text = urun.UrunAd;
                    taciklama.Text = urun.Acıklama;
                    curungrup.Text = urun.UrunGrup;
                    talisfiyat.Text = urun.AlisFiyati.ToString();
                    tsatisfiyat.Text = urun.SatisFiyati.ToString();
                    tmiktar.Text = urun.Miktar.ToString();
                    tkdvorani.Text = urun.KdvOrani.ToString();
                    if (urun.Birim == "Kg")
                    {
                        chgramaj.Checked = true;
                    }
                    else
                    {
                        chgramaj.Checked = false;
                    }

                }
                else
                {
                    MessageBox.Show("Ürün kayıtlı değildir , kaydedebilirsiniz.");
                }
            }
        }

        private void bkaydet_Click(object sender, EventArgs e)
        {
            if (tbarkod.Text != "" && turunadi.Text != "" && curungrup.Text != "" && talisfiyat.Text != "" && tsatisfiyat.Text != "" && tkdvorani.Text != "" && tmiktar.Text != "")
            {
                if (db.Urun.Any(a => a.Barkod == tbarkod.Text))
                {
                    var guncelle = db.Urun.Where(a => a.Barkod == tbarkod.Text).SingleOrDefault();
                    guncelle.UrunAd = turunadi.Text;
                    guncelle.Acıklama = taciklama.Text;
                    guncelle.UrunGrup = curungrup.Text;
                    guncelle.AlisFiyati = Convert.ToDouble(talisfiyat.Text);
                    guncelle.SatisFiyati = Convert.ToDouble(tsatisfiyat.Text);
                    guncelle.KdvOrani = Convert.ToInt32(tkdvorani.Text);
                    guncelle.KdvTutari = Math.Round(islemler.DoubleYap(tsatisfiyat.Text) * islemler.DoubleYap(tkdvorani.Text) / 100, 2);
                    guncelle.Miktar += Convert.ToDouble(tmiktar.Text);
                    if (chgramaj.Checked)
                    {
                        guncelle.Birim = "Kg";

                    }
                    else
                    {
                        guncelle.Birim = "Adet";
                    }
                    guncelle.Tarih = DateTime.Now;
                    guncelle.Kullanici = lkullanici.Text;
                    db.SaveChanges();
                    MessageBox.Show("Ürün Güncellenmiştir.");
                    gridurunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                }
                else
                {
                    Urun urun = new Urun();
                    urun.Barkod = tbarkod.Text;
                    urun.UrunAd = turunadi.Text;
                    urun.Acıklama = taciklama.Text;
                    urun.UrunGrup = curungrup.Text;
                    urun.AlisFiyati = Convert.ToDouble(talisfiyat.Text);
                    urun.SatisFiyati = Convert.ToDouble(tsatisfiyat.Text);
                    urun.KdvOrani = Convert.ToInt32(tkdvorani.Text);
                    urun.KdvTutari = Math.Round(islemler.DoubleYap(tsatisfiyat.Text) * islemler.DoubleYap(tkdvorani.Text) / 100, 2);
                    urun.Miktar = Convert.ToDouble(tmiktar.Text);
                    if (chgramaj.Checked)
                    {
                        urun.Birim = "Kg";

                    }
                    else
                    {
                        urun.Birim = "Adet";
                    }
                    urun.Tarih = DateTime.Now;
                    urun.Kullanici = lkullanici.Text;
                    db.Urun.Add(urun);
                    db.SaveChanges();
                    if (tbarkod.Text.Length == 8)
                    {
                        var ozelbarkod = db.Barkod.First();
                        ozelbarkod.BarkodNo += 1;
                        db.SaveChanges();

                    }


                    gridurunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
                    islemler.Gridduzenle(gridurunler);
                }

                islemler.StokHareket(tbarkod.Text, turunadi.Text, "Adet", Convert.ToDouble(tmiktar.Text), curungrup.Text, lkullanici.Text);
                temizle();

            }
            else
            {
                MessageBox.Show("Bilgi girişlerini kontrol ediniz.");
                tbarkod.Focus();
            }
        }

        private void turunara_TextChanged(object sender, EventArgs e)
        {
            if (turunara.Text.Length >= 2)
            {
                string urunad = turunara.Text;
                gridurunler.DataSource = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
                islemler.Gridduzenle(gridurunler);
            }



        }

        private void biptal_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()

        {
            tbarkod.Clear();
            taciklama.Clear();
            turunadi.Clear();
            talisfiyat.Text = "0";
            tsatisfiyat.Text = "0";
            tmiktar.Text = "0";
            tkdvorani.Text = "8";
            tbarkod.Focus();
            chgramaj.Checked = false;
        }

        private void fUrunGiris_Load(object sender, EventArgs e)
        {
            turunsayisi.Text = db.Urun.Count().ToString();
            gridurunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
            islemler.Gridduzenle(gridurunler);
            liste();


        }



        private void burungrubuekle_Click(object sender, EventArgs e)
        {
            fUrunGrubuEkle f = new fUrunGrubuEkle();
            f.ShowDialog();
        }

        public void liste()
        {
            curungrup.DisplayMember = "UrunGrupAd";
            curungrup.ValueMember = "Id";
            curungrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bbarkodolustur_Click(object sender, EventArgs e)
        {
            var barkodno = db.Barkod.First();
            int karakter = barkodno.BarkodNo.ToString().Trim().Length;
            string sifirlar = string.Empty;
            for (int i = 0; i < 8 - karakter; i++)
            {
                sifirlar = sifirlar + "0";
            }
            string olusanbarkod = sifirlar + barkodno.BarkodNo.ToString();
            tbarkod.Text = olusanbarkod;
            turunadi.Focus();
        }

        private void talisfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }

        private void fUrunGiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }



        private void chgramaj_CheckedChanged(object sender, EventArgs e)
        {
            if (chgramaj.Checked)
            {
                chgramaj.Text = "GRAMAJLI ÜRÜN İŞLEMİ";
                bbarkodolustur.Enabled = false;
            }
            else
            {
                chgramaj.Text = "BARKODLU ÜRÜN İŞLEMİ";
                bbarkodolustur.Enabled = true;
            }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (gridurunler.Rows.Count > 0)
            {
                int urunid = Convert.ToInt32(gridurunler.CurrentRow.Cells["UrunId"].Value.ToString());
                string urunad = gridurunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                string barkod = gridurunler.CurrentRow.Cells["Barkod"].Value.ToString();
                DialogResult onay = MessageBox.Show(urunad + " Ürünü Silmek İstiyormusunuz ", "Ürün Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    var urun = db.Urun.Find(urunid);
                    db.Urun.Remove(urun);
                    db.SaveChanges();
                    var hizliurun = db.HizliUrun.Where(u => u.Barkod == barkod).SingleOrDefault();
                    hizliurun.Barkod = "-";
                    hizliurun.Urun = "-";
                    hizliurun.Fiyat = 0;
                    db.SaveChanges();
                    MessageBox.Show("Ürün Silinmiştir");
                    gridurunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
                    islemler.Gridduzenle(gridurunler);
                    tbarkod.Focus();
                }

            }

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridurunler.Rows.Count > 0)
            {
                tbarkod.Text = gridurunler.CurrentRow.Cells["Barkod"].Value.ToString();
                turunadi.Text = gridurunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                taciklama.Text = gridurunler.CurrentRow.Cells["Acıklama"].Value.ToString();
                curungrup.Text = gridurunler.CurrentRow.Cells["UrunGrup"].Value.ToString();
                talisfiyat.Text = gridurunler.CurrentRow.Cells["AlisFiyati"].Value.ToString();
                tsatisfiyat.Text = gridurunler.CurrentRow.Cells["SatisFiyati"].Value.ToString();
                tkdvorani.Text = gridurunler.CurrentRow.Cells["KdvOrani"].Value.ToString();
                tmiktar.Text= gridurunler.CurrentRow.Cells["Miktar"].Value.ToString();
                string birim = gridurunler.CurrentRow.Cells["Birim"].Value.ToString();
                if (birim == "Kg")
                {
                    chgramaj.Checked = true;
                }
                else
                {
                    chgramaj.Checked = false;
                }

            }
        }
    }
}

