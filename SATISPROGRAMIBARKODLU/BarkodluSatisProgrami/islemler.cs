using BarkodluSatisProgrami;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SATISPROGRAMIBARKODLU
{
    static class islemler
    {

        public static double DoubleYap(string deger)
        {
            double sonuc;
            double.TryParse(deger, NumberStyles.Currency, CultureInfo.CurrentUICulture.NumberFormat, out sonuc);
            return Math.Round(sonuc, 2);
        }

        public static void stokazalt(string barkod, double miktar)
        {
            if (barkod != "1111111111116")
            {
                using (var db = new BarkodluSatisEntities())
                {
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                    urunbilgi.Miktar -= miktar;
                    db.SaveChanges();
                }
            }
        }

        public static void stokarttir(string barkod, double miktar)
        {
            if (barkod != "1111111111116")
            {
                using (var db = new BarkodluSatisEntities())

                {
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                    urunbilgi.Miktar += miktar;
                    db.SaveChanges();

                }
            }

        }

        public static void Gridduzenle(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {
                        case "Id":
                            dgv.Columns[i].HeaderText = "Numara"; break;
                        case "UrunId":
                            dgv.Columns[i].HeaderText = "Ürun Numarası"; break;
                        case "UrunAd":
                            dgv.Columns[i].HeaderText = "Ürun Adı"; break;
                        case "Acıklama":
                            dgv.Columns[i].HeaderText = "Açıklama"; break;
                        case "UrunGrup":
                            dgv.Columns[i].HeaderText = "Ürün Grubu"; break;
                        case "AlisFiyati":
                            dgv.Columns[i].HeaderText = "Alış Fiyatı"; 
                            dgv.Columns[i].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";  break;
                        case "SatisFiyati":
                            dgv.Columns[i].HeaderText = "Satış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "KdvOrani":
                            dgv.Columns[i].HeaderText = "Kdv Oranı"; 
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "Birim":                            
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "Miktar":                            
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "OdemeSekli":
                            dgv.Columns[i].HeaderText = "Ödeme Şekli";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "Kart":                            
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Nakit":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Gelir":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Gider":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Kullanici":
                            dgv.Columns[i].HeaderText = "Kullanıcı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "KdvTutari":
                            dgv.Columns[i].HeaderText = "Kdv Tutarı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;



                    }
                }
            }
        }



    }
}
