using BarkodluSatisProgrami;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SATISPROGRAMIBARKODLU
{
    public partial class Fsatis : Form
    {
        public Fsatis()
        {
            InitializeComponent();
        }


        private void Fsatis_Load(object sender, EventArgs e)
        {
            tmiktar.Text = "1";
            HizliButonDoldur();
            b5.Text = 5.ToString("C2");
            b10.Text = 10.ToString("C2");
            b20.Text = 20.ToString("C2");
            b50.Text = 50.ToString("C2");
            b100.Text = 100.ToString("C2");
            b200.Text = 200.ToString("C2");

        }


        private void HizliButonDoldur()
        {
            var hizlurun = db.HizliUrun.ToList();

            foreach (var item in hizlurun)
            {
                Button bh = this.Controls.Find("bh" + item.Id, true).FirstOrDefault() as Button;
                if (bh != null)
                {
                    double fiyat = islemler.DoubleYap(item.Fiyat.ToString());
                    bh.Text = item.Urun + "\n" + fiyat.ToString("C2");
                }
            }
        }
        private void HizliButonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int buttonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));

            if (b.Text.ToString().StartsWith("-"))
            {
                FHizliButonUrunEkle f = new FHizliButonUrunEkle();
                f.lbutonid.Text = buttonid.ToString();
                f.ShowDialog();
            }
            else
            {
                var urunbarkod = db.HizliUrun.Where(a => a.Id == buttonid).Select(a => a.Barkod).FirstOrDefault();
                var urun = db.Urun.Where(a => a.Barkod == urunbarkod).FirstOrDefault();
                UrunGetirListeye(urun, urunbarkod, Convert.ToDouble(tmiktar.Text));
                GenelToplam();
            }

        }

        BarkodluSatisEntities db = new BarkodluSatisEntities();

        private void tbarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tbarkod.Text.Trim();
                if (barkod.Length <= 2)
                {
                    tmiktar.Text = barkod;
                    tbarkod.Clear();
                    tbarkod.Focus();
                }
                else
                {
                    if (db.Urun.Any(a => a.Barkod == barkod))
                    {
                        var urun = db.Urun.Where(a => a.Barkod == barkod).FirstOrDefault();
                        UrunGetirListeye(urun, barkod, Convert.ToDouble(tmiktar.Text));

                    }
                    else
                    {
                        int onek = Convert.ToInt32(barkod.Substring(0, 2));
                        if (db.Terazi.Any(a => a.TeraziOnEk == onek))
                        {
                            string teraziurunno = barkod.Substring(2, 5);
                            if (db.Urun.Any(a => a.Barkod == teraziurunno))
                            {
                                var urunterazi = db.Urun.Where(a => a.Barkod == teraziurunno).FirstOrDefault();
                                double miktarkg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                UrunGetirListeye(urunterazi, teraziurunno, miktarkg);

                            }
                            else
                            {
                                Console.Beep(900, 2000);
                                MessageBox.Show("Kg Ürün Ekleme Sayfası");

                            }
                        }
                        else

                        {
                            Console.Beep(900, 2000);
                            fUrunGiris f = new fUrunGiris();
                            f.tbarkod.Text = barkod;
                            f.ShowDialog();

                        }
                    }


                }
                gridsatislistesi.ClearSelection();
                GenelToplam();
                tbarkod.Focus();

            }


        }

        private void UrunGetirListeye(Urun urun, string barkod, double miktar)
        {
            int satirsayisi = gridsatislistesi.Rows.Count;            
            bool eklenmismi = false;
            if (satirsayisi > 0)
            {
                for (int i = 0; i < satirsayisi; i++)
                {
                    if (gridsatislistesi.Rows[i].Cells["barkod"].Value.ToString() == barkod)
                    {
                        gridsatislistesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Miktar"].Value);
                        gridsatislistesi.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Fiyat"].Value), 2);
                        double dblkdvtutari = (double)urun.KdvTutari;
                        gridsatislistesi.Rows[i].Cells["KdvTutari"].Value = Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Miktar"].Value) * dblkdvtutari;
                        ;

                        eklenmismi |= true;


                    }
                }
            }
            if (!eklenmismi)
            {
                gridsatislistesi.Rows.Add();
                gridsatislistesi.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                gridsatislistesi.Rows[satirsayisi].Cells["UrunAdi"].Value = urun.UrunAd;
                gridsatislistesi.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                gridsatislistesi.Rows[satirsayisi].Cells["BİRİM"].Value = urun.Birim;
                gridsatislistesi.Rows[satirsayisi].Cells["Fiyat"].Value = urun.SatisFiyati;
                gridsatislistesi.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                gridsatislistesi.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * (double)urun.SatisFiyati, 2);
                gridsatislistesi.Rows[satirsayisi].Cells["AlisFiyati"].Value = urun.AlisFiyati;
                gridsatislistesi.Rows[satirsayisi].Cells["KdvTutari"].Value = urun.KdvTutari;

            }
        }


        private void GenelToplam()
        {
            double toplam = 0;
            for (int i = 0; i < gridsatislistesi.Rows.Count; i++)
            {
                toplam += Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Toplam"].Value);

            }
            tgeneltoplam.Text = toplam.ToString("C2");
            tmiktar.Text = "1";
            tbarkod.Clear();
            tbarkod.Focus();
        }

        private void gridsatislistesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)

                gridsatislistesi.Rows.Remove(gridsatislistesi.CurrentRow);
            gridsatislistesi.ClearSelection();
            GenelToplam();
            tbarkod.Focus();

        }

        private void bh_mousedown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button b = (Button)sender;
                if (!b.Text.StartsWith("-"))
                {
                    int buttonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));
                    ContextMenuStrip s = new ContextMenuStrip();
                    ToolStripMenuItem sil = new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton no:" + buttonid.ToString();
                    sil.Click += Sil_Click;
                    s.Items.Add(sil);
                    this.ContextMenuStrip = s;
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int buttonid = Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = db.HizliUrun.Find(buttonid);
            guncelle.Barkod = "-";
            guncelle.Urun = "-";
            guncelle.Fiyat = 0;
            db.SaveChanges();
            double fiyat = 0;
            Button b = this.Controls.Find("bh" + buttonid, true).FirstOrDefault() as Button;
            b.Text = "-" + "\n" + fiyat.ToString("C2");
        }

        private void bnx_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = tnumarator.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tnumarator.Text += b.Text;

                }
            }
            else if (b.Text == "<")
            {
                if (tnumarator.Text.Length > 0)
                {
                    tnumarator.Text = tnumarator.Text.Substring(0, tnumarator.Text.Length - 1);
                }
            }
            else
            {
                tnumarator.Text += b.Text;

            }

        }

        private void badet_Click(object sender, EventArgs e)
        {
            if (tnumarator.Text != "")

            {
                tmiktar.Text = tnumarator.Text;
                tnumarator.Clear();
                tbarkod.Clear();
                tbarkod.Focus();
            }
        }

        private void bodenen_Click(object sender, EventArgs e)
        {
            if (tnumarator.Text != "")
            {
                double sonuc = islemler.DoubleYap(tnumarator.Text) - islemler.DoubleYap(tgeneltoplam.Text);
                tparaustu.Text = sonuc.ToString("C2");
                todenen.Text = islemler.DoubleYap(tnumarator.Text).ToString("C2");
                tnumarator.Clear();
                tbarkod.Focus();
            }
        }

        private void bbarkod_Click(object sender, EventArgs e)
        {
            if (tnumarator.Text != null)
            {
                string barkod = tbarkod.Text.Trim();
                if (db.Urun.Any(a => a.Barkod == tnumarator.Text))
                {
                    var urun = db.Urun.Where(a => a.Barkod == tnumarator.Text).FirstOrDefault();
                    UrunGetirListeye(urun, tnumarator.Text, Convert.ToDouble(tmiktar.Text));
                    tnumarator.Clear();
                    tbarkod.Focus();

                }
                else
                {
                    fUrunGiris f = new fUrunGiris();
                    f.tbarkod.Text = tbarkod.Text;
                    f.ShowDialog();
                }
            }
        }

        private void paraustuhesapla_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            double sonuc = islemler.DoubleYap(b.Text) - islemler.DoubleYap(tgeneltoplam.Text);
            todenen.Text = islemler.DoubleYap(b.Text).ToString("C2");
            tparaustu.Text = sonuc.ToString("C2");
        }

        private void bdiger_Click(object sender, EventArgs e)
        {
            if (tnumarator.Text != "")
            {
                int satirsayisi = gridsatislistesi.Rows.Count;
                gridsatislistesi.Rows.Add();
                gridsatislistesi.Rows[satirsayisi].Cells["BARKOD"].Value = "1111111111116";
                gridsatislistesi.Rows[satirsayisi].Cells["UrunAdi"].Value = "Barkodsuz Ürün";
                gridsatislistesi.Rows[satirsayisi].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                //gridsatislistesi.Rows[satirsayisi].Cells["Birimm"].Value = "Adet";
                gridsatislistesi.Rows[satirsayisi].Cells["Miktar"].Value = 1;
                gridsatislistesi.Rows[satirsayisi].Cells["AlisFiyati"].Value = 0;
                gridsatislistesi.Rows[satirsayisi].Cells["Fiyat"].Value = Convert.ToDouble(tnumarator.Text);
                gridsatislistesi.Rows[satirsayisi].Cells["KdvTutari"].Value = 0;
                gridsatislistesi.Rows[satirsayisi].Cells["Toplam"].Value = Convert.ToDouble(tnumarator.Text);
                tnumarator.Text = "";
                GenelToplam();
                tbarkod.Focus();
            }
        }

        private void biade_Click(object sender, EventArgs e)
        {
            if (chsatisiade.Checked)
            {
                chsatisiade.Checked = false;
                chsatisiade.Text = "Satış Yapılıyor";
            }
            else
            {
                {
                    chsatisiade.Checked = true;
                    chsatisiade.Text = "İade İşlemi";
                }
            }
        }

        private void btemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            tmiktar.Text = "1";
            tbarkod.Clear();
            todenen.Clear();
            tparaustu.Clear();
            tgeneltoplam.Text = 0.ToString("C2");
            chsatisiade.Checked = false;
            tnumarator.Clear();
            gridsatislistesi.Rows.Clear();
            tbarkod.Clear();
            tbarkod.Focus();

        }

        public void satisyap(string odemesekli)
        {
            int satirsayisi = gridsatislistesi.Rows.Count;
            bool satisiade = chsatisiade.Checked;
            double alisfiyattoplam = 0;
            if (satirsayisi > 0)
            {
                int? islemno = db.İslem.First().Islemno;
                Satis satis = new Satis();
                for (int i = 0; i < satirsayisi; i++)
                {
                    satis.IslemNo = islemno;
                    satis.UrunAd = gridsatislistesi.Rows[i].Cells["UrunAdi"].Value.ToString();
                    satis.UrunGrup = gridsatislistesi.Rows[i].Cells["UrunGrup"].Value.ToString();
                    satis.Barkod = gridsatislistesi.Rows[i].Cells["Barkod"].Value.ToString();
                    //satis.Birim = gridsatislistesi.Rows[i].Cells["Birim"].Value.ToString();
                    satis.AlisFiyat = islemler.DoubleYap(gridsatislistesi.Rows[i].Cells["AlisFiyati"].Value.ToString());
                    satis.SatisFiyat = islemler.DoubleYap(gridsatislistesi.Rows[i].Cells["Fiyat"].Value.ToString());
                    satis.Miktar = islemler.DoubleYap(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.Toplam = islemler.DoubleYap(gridsatislistesi.Rows[i].Cells["Toplam"].Value.ToString());
                    satis.KdvTutari = islemler.DoubleYap(gridsatislistesi.Rows[i].Cells["KdvTutari"].Value.ToString()) * islemler.DoubleYap(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.OdemeSekli = odemesekli;
                    satis.Iade = satisiade;
                    satis.Tarih = DateTime.Now;
                    satis.Kullanici = lKullanici.Text;
                    db.Satis.Add(satis);
                    db.SaveChanges();

                    if (!satisiade)
                    {
                        islemler.stokazalt(gridsatislistesi.Rows[i].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString()));

                    }

                    else
                    {
                        islemler.stokarttir(gridsatislistesi.Rows[i].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString()));

                    }
                    alisfiyattoplam += islemler.DoubleYap(gridsatislistesi.Rows[i].Cells["AlisFiyati"].Value.ToString()) * islemler.DoubleYap(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString());
                }

                IslemOzet io = new IslemOzet();
                io.IslemNo = islemno;
                io.Iade = satisiade;
                io.AlisFiyatToplam = alisfiyattoplam;
                io.Gelir = false;
                io.Gider = false;
                if (!satisiade)
                {
                    io.Aciklama = odemesekli + " Satış ";
                }
                else
                {

                    io.Aciklama = "İade işlemi (" + odemesekli + ")";
                }
                io.OdemeSekli = odemesekli;
                io.Kullanici = lKullanici.Text;
                io.Tarih = DateTime.Now;
                switch (odemesekli)
                {
                    case "Nakit":
                        io.Nakti = islemler.DoubleYap(tgeneltoplam.Text);
                        io.Kart = 0; break;

                    case "Kart":
                        io.Nakti = 0;
                        io.Kart = islemler.DoubleYap(tgeneltoplam.Text); break;

                    case "Kart-Nakit":
                        io.Nakti = islemler.DoubleYap(lnakit.Text);
                        io.Kart = islemler.DoubleYap(lkart.Text); break;

                }
                db.IslemOzet.Add(io);
                db.SaveChanges();

                var islemnoartir = db.İslem.First();
                islemnoartir.Islemno += 1;
                db.SaveChanges();
                MessageBox.Show("Yazdırma işlemi yap");
                temizle();

            }
        }

        private void bnakit_Click(object sender, EventArgs e)
        {
            satisyap("Nakit");
        }

        private void bkart_Click(object sender, EventArgs e)
        {
            satisyap("Kart");
        }

        private void bkartnakit_Click(object sender, EventArgs e)
        {
            fNakitKart f = new fNakitKart();
            f.ShowDialog();

        }

        private void tmiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void tbarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void Fsatis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                satisyap("Nakit");

            if (e.KeyCode == Keys.F2)
                satisyap("Kart");

            if (e.KeyCode == Keys.F3)
            {
                fNakitKart f = new fNakitKart();
                f.ShowDialog();
            }



        }

        private void bislembeklet_Click(object sender, EventArgs e)
        {
            if (bislembeklet.Text == "İşlem Beklet")
            {
                beklet();
                bislembeklet.BackColor = System.Drawing.Color.OrangeRed;
                bislembeklet.Text = "İşlem Bekliyor";
                gridsatislistesi.Rows.Clear();
            }

            else

            {
                beklemedencik();
                bislembeklet.BackColor = System.Drawing.Color.DimGray;
                bislembeklet.Text = "İşlem Beklet";
                gridbekle.Rows.Clear();

            }



        }

        private void beklet()
        {
            int satir = gridsatislistesi.Rows.Count;
            int sutun = gridsatislistesi.Columns.Count;
            if (satir > 0) ;
            {
                for (int i = 0; i < satir; i++)
                {
                    gridbekle.Rows.Add();
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        gridbekle.Rows[i].Cells[j].Value = gridsatislistesi.Rows[i].Cells[j].Value;
                    }
                }

            }
        }
        private void beklemedencik()
        {
            int satir = gridbekle.Rows.Count;
            int sutun = gridbekle.Columns.Count;
            if (satir > 0) ;
            {
                for (int i = 0; i < satir; i++)
                {
                    gridsatislistesi.Rows.Add();
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        gridsatislistesi.Rows[i].Cells[j].Value = gridbekle.Rows[i].Cells[j].Value;
                    }
                }

            }
        }

        private void chsatisiade_CheckedChanged(object sender, EventArgs e)
        {
            if (chsatisiade.Checked)
            {
                chsatisiade.Text = "İade yapılıyor.";

            }
            else
            {
                chsatisiade.Text = "Satış yapılıyor.";

            }
        }
    }
}
