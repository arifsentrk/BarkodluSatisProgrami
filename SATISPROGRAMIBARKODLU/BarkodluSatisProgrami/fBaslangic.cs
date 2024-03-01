using SATISPROGRAMIBARKODLU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatisProgrami
{
    public partial class fBaslangic : Form
    {
        public fBaslangic()
        {
            InitializeComponent();
        }

        private void btnsatisislemi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Fsatis f = new Fsatis();
            f.lKullanici.Text = lkullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btngenelrapor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FRapor f = new FRapor();
            f.lstnkullanici.Text = lkullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void btnstoktakibi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fStok f = new fStok();
            f.lkullanici.Text = lkullanici.Text;  
            f.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void btnurungiris_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fUrunGiris f = new fUrunGiris();
            f.lkullanici.Text= lkullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
