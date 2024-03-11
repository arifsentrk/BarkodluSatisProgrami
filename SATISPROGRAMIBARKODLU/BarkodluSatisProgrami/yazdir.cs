using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BarkodluSatisProgrami
{
    internal class yazdir
    {

        public int? IslemNo { get; set; }

        public yazdir(int? islemno)
        {
            IslemNo = islemno;
        }

        PrintDocument pd = new PrintDocument();

        public void yazdirmayabasla()

        {
            try
            {

                pd.PrintPage += Pd_PrintPage;
                pd.Print();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            BarkodluSatisEntities db = new BarkodluSatisEntities();
            var isyeri = db.Sabit.FirstOrDefault();
            var liste = db.Satis.Where(x => x.IslemNo == IslemNo).ToList();
            if (isyeri != null && liste != null)
            {
                int kagituzunluk = 120;
                for (int i = 0; i < liste.Count; i++) 
                {
                    kagituzunluk += 15;
                }
                PaperSize ps58 = new PaperSize("58 mm Termal", 220, kagituzunluk + 120);
                pd.DefaultPageSettings.PaperSize = ps58;



                Font fontbaslik = new Font("Calibri", 10, FontStyle.Bold);
                Font fontbilgi = new Font("Calibri", 8, FontStyle.Bold);
                Font fontIcerikBaslik = new Font("Calibri", 8, FontStyle.Underline);
                StringFormat ortala = new StringFormat(StringFormatFlags.FitBlackBox);
                ortala.Alignment = StringAlignment.Center;
                RectangleF rcUnvanKonum = new RectangleF(0, 20, 220, 20);
                e.Graphics.DrawString(isyeri.Unvan, fontbaslik, Brushes.Black, rcUnvanKonum, ortala);
                e.Graphics.DrawString("Telefon : " + isyeri.Telefon, fontbilgi, Brushes.Black, new Point(5, 45));
                e.Graphics.DrawString("İşlem No " + IslemNo.ToString(), fontbilgi, Brushes.Black, new Point(5, 60));
                e.Graphics.DrawString("Tarih : " + DateTime.Now, fontbilgi, Brushes.Black, new Point(5, 75));
                e.Graphics.DrawString("--------------------------------------------------------------", fontbilgi, Brushes.Black, new Point(5, 90));

                e.Graphics.DrawString("Ürün Adı", fontIcerikBaslik, Brushes.Black, new Point(5, 105));
                e.Graphics.DrawString("Miktar", fontIcerikBaslik, Brushes.Black, new Point(100, 105));
                e.Graphics.DrawString("Fiyat", fontIcerikBaslik, Brushes.Black, new Point(140, 105));
                e.Graphics.DrawString("Tutar", fontIcerikBaslik, Brushes.Black, new Point(180, 105));

                int yukseklik = 125;
                double geneltoplam = 0;

                foreach (var item in liste)
                {
                    e.Graphics.DrawString(item.UrunAd, fontbilgi, Brushes.Black, new Point(5, yukseklik));
                    e.Graphics.DrawString(item.Miktar.ToString(), fontbilgi, Brushes.Black, new Point(100, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.SatisFiyat).ToString("C2"), fontbilgi, Brushes.Black, new Point(140, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.Toplam).ToString("C2"), fontbilgi, Brushes.Black, new Point(180, yukseklik));
                    yukseklik += 15;
                    geneltoplam += Convert.ToDouble(item.Toplam);
                }
                e.Graphics.DrawString("--------------------------------------------------------------", fontbilgi, Brushes.Black, new Point(5, yukseklik));
                e.Graphics.DrawString("TOPLAM : " + geneltoplam.ToString("C2"), fontbaslik, Brushes.Black, new Point(5, yukseklik + 20));
                e.Graphics.DrawString("--------------------------------------------------------------", fontbilgi, Brushes.Black, new Point(5, yukseklik + 40));
                e.Graphics.DrawString("(Mali Değeri Yoktur.)", fontbilgi, Brushes.Black, new Point(5, yukseklik + 60));

                

            }
        }
    }
}
