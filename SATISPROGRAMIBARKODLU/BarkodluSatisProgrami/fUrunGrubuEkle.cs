using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using BarkodluSatisProgrami;

namespace SATISPROGRAMIBARKODLU
{
    public partial class fUrunGrubuEkle : Form
    {
        public fUrunGrubuEkle()
        {
            InitializeComponent();
        }

        BarkodluSatisEntities db = new BarkodluSatisEntities();

        private void fUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            liste();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (turungrubuadi.Text != "")

            {

                UrunGrup ug = new UrunGrup();
                ug.UrunGrupAd = turungrubuadi.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                liste();
                turungrubuadi.Clear();
                MessageBox.Show("Ürün Grubu Eklenmiştir.");

                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                if (f != null)

                {
                    f.liste();
                }
            }
            else
            {
                MessageBox.Show("Grup Bilgisi Ekleyiniz.");
            }


        }
        private void liste()
        {
            listboxekle.DisplayMember = "UrunGrupAd";
            listboxekle.ValueMember = "Id";
            listboxekle.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bsil_Click(object sender, EventArgs e)
        {
            int grupid = Convert.ToInt32(listboxekle.SelectedValue.ToString());
            string grupad = listboxekle.Text;
            DialogResult onay = MessageBox.Show(grupad + " Grubunu Silmek istiyor musunuz? ", "Silme işlemi ", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                var grup = db.UrunGrup.FirstOrDefault(x => x.Id == grupid);
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                liste();
                turungrubuadi.Focus();
                MessageBox.Show(grupad+ "Ürün Grubu Silinmiştir.");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                f.liste();
            }
        }
    }
}
