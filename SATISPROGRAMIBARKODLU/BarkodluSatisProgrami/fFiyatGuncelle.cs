using SATISPROGRAMIBARKODLU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatisProgrami
{
    public partial class fFiyatGuncelle : Form
    {
        public fFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void tbarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new BarkodluSatisEntities())
                {
                    if (db.Urun.Any(x => x.Barkod == tbarkod.Text))
                    {
                        var getir = db.Urun.Where(x => x.Barkod == tbarkod.Text).SingleOrDefault();
                        lbarkod.Text = getir.Barkod;
                        lurunad.Text = getir.UrunAd;
                        double satisfiyati = Convert.ToDouble(getir.SatisFiyati);
                        lfiyat.Text = satisfiyati.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Kayıtlı Değildir.");
                    }
                }
            }
        }

        private void bkaydet_Click(object sender, EventArgs e)
        {
            if (tyenifiyat.Text != "" & lbarkod.Text != "")
            {
                using (var db = new BarkodluSatisEntities())
                {
                    var guncellenecek = db.Urun.Where(x => x.Barkod == lbarkod.Text).SingleOrDefault();
                    guncellenecek.SatisFiyati = islemler.DoubleYap(tyenifiyat.Text);
                    int kdvorani = Convert.ToInt16(guncellenecek.KdvOrani);
                    Math.Round(islemler.DoubleYap(tyenifiyat.Text) * kdvorani / 100, 2);
                    db.SaveChanges();
                    MessageBox.Show("Yeni Fiyat Kaydedilmiştir.");
                    lbarkod.Text = "";
                    lurunad.Text = "";
                    lfiyat.Text = "";
                    tbarkod.Clear();
                    tyenifiyat.Clear();
                    tbarkod.Focus();

                }
            }
            else
            {
                MessageBox.Show("Ürün Okutunuz");
                tbarkod.Focus();
            }
        }

        private void fFiyatGuncelle_Load(object sender, EventArgs e)
        {
            lbarkod.Text = "";
            lurunad.Text = "";
            lfiyat.Text = "";
            tbarkod.Clear();
        }
    }
}
