using SATISPROGRAMIBARKODLU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatisProgrami
{
    public partial class FRapor : Form
    {
        public FRapor()
        {
            InitializeComponent();
        }

        public void btngoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            DateTime baslangic = DateTime.Parse(datebaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(datebitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);
            using (var db = new BarkodluSatisEntities())
            {
                if (listfiltre.SelectedIndex == 0)
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridliste.DataSource = islemozet;

                    tsatisnakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakti)).ToString("C2");
                    tsatiskart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(s => s.Kart)).ToString("C2");

                    tiadenakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Nakti)).ToString("C2");
                    tiadekart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Kart)).ToString("C2");

                    tgelirnakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(s => s.Nakti)).ToString("C2");
                    tgelirkart.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(s => s.Kart)).ToString("C2");

                    tgidernakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(s => s.Nakti)).ToString("C2");
                    tgiderkart.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(s => s.Kart)).ToString("C2");

                    db.Satis.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    var satistablosu = db.Satis.Local.ToBindingList();
                    double kdvtutarisatis = islemler.DoubleYap(satistablosu.Where(x => x.Iade == false).Sum(x => x.KdvTutari).ToString());
                    double kdvtutariiade = islemler.DoubleYap(satistablosu.Where(x => x.Iade == true).Sum(x => x.KdvTutari).ToString());
                    tkdvtoplam.Text = (kdvtutarisatis - kdvtutariiade).ToString("C2");

                }
                else if (listfiltre.SelectedIndex == 1)
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == false && x.Gelir == false && x.Gider == false).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridliste.DataSource = islemozet;
                }
                else if (listfiltre.SelectedIndex == 2)
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == true).Load();
                    gridliste.DataSource = db.IslemOzet.Local.ToBindingList();
                }
                else if (listfiltre.SelectedIndex == 3)
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).Load();
                    gridliste.DataSource = db.IslemOzet.Local.ToBindingList();
                }
                else if (listfiltre.SelectedIndex == 4)
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == true).Load();
                    gridliste.DataSource = db.IslemOzet.Local.ToBindingList();
                }
            }

            islemler.Gridduzenle(gridliste);



            Cursor.Current = Cursors.Default;
        }

        private void FRapor_Load(object sender, EventArgs e)
        {
            listfiltre.SelectedIndex = 0;
            tkomisyon.Text = islemler.KartKomisyon().ToString();
            btngoster_Click(null, null);
        }

        private void gridliste_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır";
                    e.FormattingApplied = true;
                }
            }
        }

        private void bgelirekle_Click(object sender, EventArgs e)
        {
            FGelirGider f = new FGelirGider();
            f.gelirgider = "GELİR";
            f.kullanici = lkullanici.Text;
            f.ShowDialog();
        }

        private void bgiderekle_Click(object sender, EventArgs e)
        {
            FGelirGider f = new FGelirGider();
            f.gelirgider = "GİDER";
            f.kullanici = lkullanici.Text;
            f.ShowDialog();
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridliste.Rows.Count>0)
            {
                int islemno = Convert.ToInt32(gridliste.CurrentRow.Cells["IslemNo"].Value.ToString());
                if (islemno!=0)
                {
                    FDetayGoster f = new FDetayGoster();
                    f.islemno = islemno;
                    f.ShowDialog();
                }
            }
        }

        private void braporal_Click(object sender, EventArgs e)
        {
            Raporlar.Baslik = "GENEL RAPOR";
            Raporlar.SatisKart=tsatiskart.Text;
            Raporlar.SatisNakit=tsatisnakit.Text;
            Raporlar.IadeKart=tiadekart.Text;
            Raporlar.IadeNakit=tiadenakit.Text;
            Raporlar.GelirKart=tgelirkart.Text;
            Raporlar.GelirNakit=tgelirnakit.Text;
            Raporlar.Giderkart=tgiderkart.Text;
            Raporlar.GiderNakit=tgidernakit.Text;
            Raporlar.TarihBaslangic=datebaslangic.Value.ToShortDateString();
            Raporlar.TarihBitis = datebitis.Value.ToShortDateString();
            Raporlar.KdvToplam=tkdvtoplam.Text;
            Raporlar.KartKomisyon=tkomisyon.Text;
            Raporlar.RaporSayfasiRaporu(gridliste);
        }
    }
}
