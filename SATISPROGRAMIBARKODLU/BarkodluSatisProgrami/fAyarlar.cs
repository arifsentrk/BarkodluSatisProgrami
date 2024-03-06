using SATISPROGRAMIBARKODLU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatisProgrami
{
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            tadsoyad.Clear();
            msktel.Clear();
            teposta.Clear();
            tkullaniciad.Clear();
            tsifre.Clear();
            tsifretekrar.Clear();
            chsatisekrani.Checked = false;
            chrapor.Checked = false;
            chstok.Checked = false;
            churungiris.Checked = false;
            chayarlar.Checked = false;
            chfiyatguncelle.Checked = false;
            chyedekleme.Checked = false;
            tsifretekrar.Clear();

        }

        private void bkaydet_Click(object sender, EventArgs e)
        {
            if (bkaydet.Text == "KAYDET")
            {
                if (tadsoyad.Text != "" && msktel.Text != "" && tkullaniciad.Text != "" && tsifre.Text != "" && tsifretekrar.Text != "")
                {
                    if (tsifre.Text == tsifretekrar.Text)
                    {
                        try
                        {
                            using (var db = new BarkodluSatisEntities())
                            {
                                if (!db.Kullanici.Any(x => x.KullaniciAd == tkullaniciad.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.AdSoyad = tadsoyad.Text;
                                    k.Telefon = msktel.Text;
                                    k.Eposta = teposta.Text;
                                    k.KullaniciAd = tkullaniciad.Text.Trim();
                                    k.Sifre = tsifre.Text;
                                    k.Satis = chsatisekrani.Checked;
                                    k.Rapor = chrapor.Checked;
                                    k.Stok = chstok.Checked;
                                    k.UrunGiris = churungiris.Checked;
                                    k.Ayarlar = chayarlar.Checked;
                                    k.FiyatGuncelle = chfiyatguncelle.Checked;
                                    k.Yedekleme = chyedekleme.Checked;
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    doldur();
                                    Temizle();

                                }
                                else
                                {
                                    MessageBox.Show("Kullanıcı Zaten Kayıtlı.");
                                }

                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Hata Oluştu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor.");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Girişleri Doldurunuz.");
                }
            }
            else if (bkaydet.Text == "Düzenle/Kaydet")
            {
                if (tadsoyad.Text != "" && msktel.Text != "" && tkullaniciad.Text != "" && tsifre.Text != "" && tsifretekrar.Text != "")
                {
                    if (tsifre.Text == tsifretekrar.Text)
                    {
                        int id = Convert.ToInt32(Lid.Text);
                        using (var db = new BarkodluSatisEntities())
                        {
                            var guncelle = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                            guncelle.AdSoyad = tadsoyad.Text;
                            guncelle.Telefon = msktel.Text;
                            guncelle.Eposta = teposta.Text;
                            guncelle.KullaniciAd = tkullaniciad.Text.Trim();
                            guncelle.Sifre = tsifre.Text;
                            guncelle.Satis = chsatisekrani.Checked;
                            guncelle.Rapor = chrapor.Checked;
                            guncelle.Stok = chstok.Checked;
                            guncelle.UrunGiris = churungiris.Checked;
                            guncelle.Ayarlar = chayarlar.Checked;
                            guncelle.FiyatGuncelle = chfiyatguncelle.Checked;
                            guncelle.Yedekleme = chyedekleme.Checked;
                            db.SaveChanges();
                            MessageBox.Show("Güncelleme Yapılmıştır.");
                            bkaydet.Text = "Kaydet";
                            Temizle();
                            doldur();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor.");
                    }
                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridlistekullanici.Rows.Count > 0)
            {
                int id = Convert.ToInt32(gridlistekullanici.CurrentRow.Cells["Id"].Value.ToString());
                Lid.Text = id.ToString();
                using (var db = new BarkodluSatisEntities())
                {
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                    tadsoyad.Text = getir.AdSoyad;
                    msktel.Text = getir.Telefon;
                    teposta.Text = getir.Eposta;
                    tkullaniciad.Text = getir.KullaniciAd;
                    tsifre.Text = getir.Sifre;
                    tsifretekrar.Text = getir.Sifre;
                    chsatisekrani.Checked = (bool)getir.Satis;
                    chrapor.Checked = (bool)getir.Rapor;
                    chstok.Checked = (bool)getir.Stok;
                    churungiris.Checked = (bool)getir.UrunGiris;
                    chayarlar.Checked = (bool)getir.Ayarlar;
                    chfiyatguncelle.Checked = (bool)getir.FiyatGuncelle;
                    chyedekleme.Checked = (bool)getir.Yedekleme;
                    bkaydet.Text = "Düzenle/Kaydet";
                    doldur();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Seçiniz.");
            }
        }

        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            doldur();
            Cursor.Current = Cursors.Default;
        }

        private void doldur()
        {
            using (var db = new BarkodluSatisEntities())
            {
                if (db.Kullanici.Any())
                {
                    gridlistekullanici.DataSource = db.Kullanici.Select(x => new { x.Id, x.AdSoyad, x.KullaniciAd, x.Telefon }).ToList();


                }
                islemler.SabitVarsayilan();
                var yazici = db.Sabit.FirstOrDefault();
                chyazmadurumu.Checked = Convert.ToBoolean(yazici.Yazici);

                var sabitler = db.Sabit.FirstOrDefault();
                tkartkomisyon.Text = sabitler.KartKomisyon.ToString();

                var terazionek = db.Terazi.ToList();
                cmbterazionek.DisplayMember = "TeraziOnEk";
                cmbterazionek.ValueMember = "Id";
                cmbterazionek.DataSource = terazionek;

                tisyeriadsoyad.Text = sabitler.AdSoyad;
                tisyeriunvan.Text = sabitler.Unvan;
                tisyeriadres.Text = sabitler.Adres;
                mskisyeritelefon.Text = sabitler.Telefon;
                tisyerieposta.Text = sabitler.Eposta;



            }
        }

        private void chyazmadurumu_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new BarkodluSatisEntities())
            {
                if (chyazmadurumu.Checked)
                {

                    islemler.SabitVarsayilan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = true;
                    db.SaveChanges();
                    chyazmadurumu.Text = "Yazma Durumu AKTİF";

                }
                else
                {
                    islemler.SabitVarsayilan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = false;
                    db.SaveChanges();
                    chyazmadurumu.Text = "Yazma Durumu PASİF";
                }
            }

        }

        private void bkartkomisyon_Click(object sender, EventArgs e)
        {
            if (tkartkomisyon.Text != "")
            {
                using (var db = new BarkodluSatisEntities())
                {
                    var sabit = db.Sabit.FirstOrDefault();
                    sabit.KartKomisyon = Convert.ToInt16(tkartkomisyon.Text);
                    db.SaveChanges();
                    MessageBox.Show("Kart Komisyon Ayarlanmıştır.");

                }
            }
            else
            {
                MessageBox.Show("Kart Komisyon Bilgisi Giriniz.");
            }

        }

        private void bterazionekkaydet_Click(object sender, EventArgs e)
        {
            if (tterazionek.Text != "")
            {
                int onek = Convert.ToInt16(tterazionek.Text);
                using (var db = new BarkodluSatisEntities())
                {
                    if (db.Terazi.Any(x => x.TeraziOnEk == onek))
                    {
                        MessageBox.Show(onek.ToString() + " Ön Ek Zaten Kayıtlıdır. ");
                    }
                    else
                    {
                        Terazi t = new Terazi();
                        t.TeraziOnEk = onek;
                        db.Terazi.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Bilgiler Kaydedilmiştir.");
                        cmbterazionek.DisplayMember = "TeraziOnEk";
                        cmbterazionek.ValueMember = "Id";
                        cmbterazionek.DataSource = db.Terazi.ToList();
                        tterazionek.Clear();

                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi  Önek Bilgisini Giriniz.");
            }
        }

        private void bterazioneksil_Click(object sender, EventArgs e)
        {
            if (cmbterazionek.Text != "")
            {
                int onekid = Convert.ToInt16(cmbterazionek.SelectedValue);
                DialogResult onay = MessageBox.Show(cmbterazionek.Text + " Öneki Silmek İstiyormusunuz ? ", "Terazi Önek Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    using (var db = new BarkodluSatisEntities())
                    {
                        var onek = db.Terazi.Find(onekid);
                        db.Terazi.Remove(onek);
                        db.SaveChanges();
                        cmbterazionek.DisplayMember = "TeraziOnEk";
                        cmbterazionek.ValueMember = "Id";
                        cmbterazionek.DataSource = db.Terazi.ToList();
                        MessageBox.Show(" Önek Silinmiştir. ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ön Ek Seçiniz.");
            }
        }

        private void bisyerikaydet_Click(object sender, EventArgs e)
        {
            if (tisyeriadsoyad.Text != "" && tisyeriunvan.Text != "" && tisyeriadres.Text != "" && mskisyeritelefon.Text != "")
            {
                using (var db = new BarkodluSatisEntities())
                {
                    var isyeri = db.Sabit.FirstOrDefault();
                    isyeri.AdSoyad = tisyeriadsoyad.Text;
                    isyeri.Unvan = tisyeriunvan.Text;
                    isyeri.Adres = tisyeriadres.Text;
                    isyeri.Telefon = mskisyeritelefon.Text;
                    isyeri.Eposta = tisyerieposta.Text;
                    db.SaveChanges();
                    MessageBox.Show("İşyeri Bilgileri Kaydedilmiştir.");
                    var yeni = db.Sabit.FirstOrDefault();
                    tisyeriadsoyad.Text = yeni.AdSoyad;
                    tisyeriunvan.Text = yeni.Unvan;
                    tisyeriadres.Text = yeni.Adres;
                    mskisyeritelefon.Text = yeni.Telefon;
                    tisyerieposta.Text = yeni.Eposta;
                }
            }
        }
    }
}

