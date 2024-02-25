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
    public partial class FGelirGider : Form
    {
        public FGelirGider()
        {
            InitializeComponent();
        }

        public string gelirgider { get; set; }
        public string kullanici { get; set; }

        private void FGelirGider_Load(object sender, EventArgs e)
        {

            lgelirgider.Text = gelirgider + " iŞLEMİ YAPILIYOR.";

        }

        private void cmbodemeturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbodemeturu.SelectedIndex == 0)
            {
                tnakit.Enabled = true;
                tkart.Enabled = false;
            }
            else if (cmbodemeturu.SelectedIndex == 1)
            {
                tnakit.Enabled = false;
                tkart.Enabled = true;

            }
            else if (cmbodemeturu.SelectedIndex == 2)
            {
                tnakit.Enabled = true;
                tkart.Enabled = true;

            }
            tnakit.Text = "0";
            tkart.Text = "0";


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (cmbodemeturu.Text != "")
            {
                if (tnakit.Text != "" && tkart.Text != "")
                {
                    using (var db = new BarkodluSatisEntities())
                    {
                        IslemOzet io = new IslemOzet();
                        io.IslemNo = 0;
                        io.Iade = false;
                        io.OdemeSekli = cmbodemeturu.Text;
                        io.Nakti = islemler.DoubleYap(tnakit.Text);
                        io.Kart = islemler.DoubleYap(tkart.Text);
                        if (gelirgider == "GELİR")
                        {
                            io.Gelir = true;
                            io.Gider = false;

                        }
                        else
                        {
                            io.Gelir = false;
                            io.Gider = true;
                        }
                        io.AlisFiyatToplam = 0;
                        io.Aciklama = gelirgider + " - İşlemi " + taciklama.Text;
                        io.Tarih = dttarih.Value;
                        io.Kullanici = kullanici;
                        db.IslemOzet.Add(io);
                        db.SaveChanges();
                        MessageBox.Show(gelirgider + " İşlemi Kaydedildi.");
                        tnakit.Text = "0";
                        tkart.Text = "0";
                        taciklama.Clear();
                        cmbodemeturu.Text = "";
                        FRapor f = (FRapor)Application.OpenForms["fRapor"];
                        if (f != null)
                        {
                            f.btngoster_Click(null, null);
                        }
                        this.Hide();


                    }
                }

            }
            else
            {
                MessageBox.Show("LÜTFEN ÖDEME TÜRÜNÜ BELİRLEYİNİZ");
            }
        }
    }
}
