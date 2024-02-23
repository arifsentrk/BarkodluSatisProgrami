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

        private void btngoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            DateTime baslangic = DateTime.Parse(datebaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(datebitis.Value.ToShortDateString());
            bitis=bitis.AddDays(1);
            using (var db = new BarkodluSatisEntities())
            {
                if(listfiltre.SelectedIndex==0)
                {
                    db.IslemOzet.Where(x=> x.Tarih>=baslangic && x.Tarih<=bitis).OrderByDescending(x=> x.Tarih).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridliste.DataSource = islemozet;
                }
            }



            Cursor.Current = Cursors.Default;
        }
    }
}
