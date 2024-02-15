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
    public partial class Fsatis : Form
    {
        public Fsatis()
        {
            InitializeComponent();
        }

        BarkodluSatisEntities db = new BarkodluSatisEntities();

        private void tbarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string barkod = tbarkod.Text.Trim();
                if(barkod.Length <=2 ) 
                {
                    tmiktar.Text = barkod;
                    tbarkod.Clear();
                    tbarkod.Focus();
                }
                else
                {
                    if(db.Urun.Any(a=> a.Barkod==barkod))
                    {
                        var urun = db.Urun.Where(a=> a.Barkod == barkod).FirstOrDefault();
                        int satirsayisi = gridsatislistesi.Rows.Count;
                        double miktar = Convert.ToDouble(tmiktar.Text);
                        bool eklenmismi = false;
                        if(satirsayisi> 0)
                        {
                            for (int i = 0; i < satirsayisi; i++)
                            {
                                if (gridsatislistesi.Rows[i].Cells["barkod"].Value.ToString()==barkod)
                                {
                                    gridsatislistesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Miktar"].Value);
                                    gridsatislistesi.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Fiyat"].Value), 2);
                                    eklenmismi |= true;

                                }
                            }
                        }
                        if( !eklenmismi)
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
                   

                }
                gridsatislistesi.ClearSelection();
                GenelToplam();
                tbarkod.Focus();

            }
            

        }

        private void GenelToplam()
        {
            if(gridsatislistesi.Rows.Count > 0)
            {
                double toplam = 0;
                for(int i = 0; i<gridsatislistesi.Rows.Count; i++)
                {
                    toplam += Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Toplam"].Value);

                }
                tgeneltoplam.Text=toplam.ToString("C2");
                tbarkod.Clear();
                tbarkod.Focus();
            }
        }
        
    }
}
