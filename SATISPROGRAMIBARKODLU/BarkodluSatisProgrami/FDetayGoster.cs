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
    public partial class FDetayGoster : Form
    {
        public FDetayGoster()
        {
            InitializeComponent();
        }

        public int islemno { get; set; }

        private void FDetayGoster_Load(object sender, EventArgs e)
        {
            lislemno.Text = "İşlem No: " + islemno.ToString();
            using (var db = new BarkodluSatisEntities())
            {
                gridliste.DataSource = db.Satis.Select(s=>new {s.IslemNo,s.UrunAd,s.UrunGrup,s.Miktar,s.Toplam}).Where(x=> x.IslemNo == islemno).ToList();
                islemler.Gridduzenle(gridliste);    
            }
        }
    }
}
