using SATISPROGRAMIBARKODLU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatisProgrami
{
    public partial class fStok : Form
    {
        public fStok()
        {
            InitializeComponent();
        }

        private void bara_Click(object sender, EventArgs e)
        {
            gridliste.DataSource = null;
            using (var db = new BarkodluSatisEntities())

            {
                if (cmbislemturu.Text != "")
                {
                    string urungrubu = cmburungrubu.Text;
                    if (cmbislemturu.SelectedIndex == 0)
                    {
                        if (rbtumu.Checked)
                        {
                            db.Urun.OrderBy(x => x.Miktar).Load();
                            gridliste.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else if (rburungrubunagore.Checked)

                        {
                            db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                            gridliste.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Ürün Grubunu Seçiniz");
                        }
                    }
                    else if (cmbislemturu.SelectedIndex == 1)
                    {
                        DateTime baslangic = DateTime.Parse(datebaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(datebitis.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);
                        if (rbtumu.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                            gridliste.DataSource = db.StokHareket.Local.ToBindingList();
                        }
                        else if (true)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            gridliste.DataSource = db.StokHareket.Local.ToBindingList();

                        }
                        else
                        {
                            
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Lütfen işlem türünü seçiniz.");
                }
            }
            islemler.Gridduzenle(gridliste);


        }
        BarkodluSatisEntities dbx = new BarkodluSatisEntities();

        private void fStok_Load(object sender, EventArgs e)
        {
            cmburungrubu.DisplayMember = "UrunGrupAd";
            cmburungrubu.ValueMember = "Id";
            cmburungrubu.DataSource = dbx.UrunGrup.ToList();

        }

        private void turunara_TextChanged(object sender, EventArgs e)
        {
            if (turunara.Text.Length >= 2)
            {
                string urunad = turunara.Text;
                using (var db = new BarkodluSatisEntities())
                {
                    if (cmbislemturu.SelectedIndex == 0)
                    {
                        db.Urun.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridliste.DataSource = db.Urun.Local.ToBindingList();
                    }
                    else if (cmbislemturu.SelectedIndex == 1)
                    {
                        db.StokHareket.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridliste.DataSource = db.StokHareket.Local.ToBindingList();
                    }
                }
                islemler.Gridduzenle(gridliste);
            }
            
        }
    }
}
