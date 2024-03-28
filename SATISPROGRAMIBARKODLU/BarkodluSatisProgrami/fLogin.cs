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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            if (tkullaniciadi.Text != "" && tsifre.Text != "")
            {
                try
                {
                    using (var db = new BarkodluSatisEntities())
                    {
                        if (db.Kullanici.Any())
                        {
                            var bak = db.Kullanici.Where(x => x.KullaniciAd == tkullaniciadi.Text && x.Sifre == tsifre.Text).FirstOrDefault();
                            if (bak != null)
                            {
                                Cursor.Current = Cursors.WaitCursor;

                                fBaslangic f = new fBaslangic();
                                f.btnsatisislemi.Enabled = (bool)bak.Satis;
                                f.btngenelrapor.Enabled = (bool)bak.Rapor;
                                f.btnstoktakibi.Enabled = (bool)bak.Stok;
                                f.btnurungiris.Enabled = (bool)bak.UrunGiris;
                                f.btnayarlar.Enabled = (bool)bak.Ayarlar;
                                f.btnfiyatguncelle.Enabled = (bool)bak.FiyatGuncelle;
                                f.btnyedekleme.Enabled = (bool)bak.Yedekleme;
                                f.lkullanici.Text = bak.AdSoyad;
                                var isyeri = db.Sabit.FirstOrDefault();
                                f.lisyeri.Text = isyeri.Unvan;
                                f.Show();
                                this.Hide();
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Giriş");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                GirisYap();
            }
        }
    }
}
