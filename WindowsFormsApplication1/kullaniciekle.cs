using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class kullaniciekle : Form
    {
        public kullaniciekle()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag();
        void mail()
        {
            SqlCommand mailbul = new SqlCommand("select * from mail", baglanti.Sqlbaglanti());
            SqlDataReader dr = mailbul.ExecuteReader();
            while (dr.Read())
            {
                MailUzantıCombo.Items.Add(dr[1]);
            }
            baglanti.Sqlbaglanti().Close();
        }
        private void OlusturButton_Click(object sender, EventArgs e)
        {
            bool hatali_mi = false;
            if (KullanıcıAdıText.Text == string.Empty || AdText.Text==string.Empty || SoyadText.Text==string.Empty || ŞifreText.Text==string.Empty || TcMaskedText.Text==string.Empty || TelMaskedText.Text==string.Empty || MailText.Text==string.Empty || UnvanText.Text == string.Empty)
            {
                hatali_mi = true;
            }
            if (hatali_mi == true)
            {
                MessageBox.Show("Bütün alanları doldurunuz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand personel= new SqlCommand("Select *from Personeller where PersonelTC='"+TcMaskedText.Text+"' and PersonelAd='"+AdText.Text+"' and PersonelSoyad='"+SoyadText.Text+"'", baglanti.Sqlbaglanti());
                SqlDataReader dreader = personel.ExecuteReader();
                if (dreader.Read())
                {
                    SqlCommand var_mi = new SqlCommand("SELECT * FROM kullanıcılar WHERE kullanıcıad = '" + KullanıcıAdıText.Text + "'", baglanti.Sqlbaglanti());
                    SqlDataReader dr = var_mi.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Kullanıcı adı sistemde mevcut, başka kullanıcı adı giriniz.", "Hata");
                    }
                    else
                    {
                        SqlCommand mail_var_mi = new SqlCommand("select *from kullanıcılar where mail='"+MailText.Text+"' and mailuzantı='"+MailUzantıCombo.Text+"'", baglanti.Sqlbaglanti());
                        SqlDataReader mail_var = mail_var_mi.ExecuteReader();
                        if (mail_var.Read())
                        {
                            MessageBox.Show("Girilmiş olan Mail adresi sistemde mevcut, başka Mail adresi giriniz.", "Hata");
                        }
                        else
                        {
                            SqlCommand kullanici_ekle = new SqlCommand("insert into kullanıcılar(kullanıcıad, ad, soyad, sifre, TC, telefon, mail, mailuzantı, unvan, admin) values('" + KullanıcıAdıText.Text + "', '" + AdText.Text + "','" + SoyadText.Text + "','" + ŞifreText.Text + "','" + TcMaskedText.Text + "','" + TelMaskedText.Text + "','" + MailText.Text + "', '"+MailUzantıCombo.Text+"', '" + UnvanText.Text + "', '" + AdminCheck.Checked + "')", baglanti.Sqlbaglanti());
                            int basarili_mi = kullanici_ekle.ExecuteNonQuery();
                            baglanti.Sqlbaglanti().Close();
                            if (basarili_mi == 1)
                            {
                                MessageBox.Show("Kayıt Başarılı");
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Kayıt eklenemedi");
                                Close();
                            }
                        }
                        baglanti.Sqlbaglanti().Close();                        
                    }
                    baglanti.Sqlbaglanti().Close();
                }
                else
                {
                    MessageBox.Show("İlgili Personel Sistemde Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Sqlbaglanti().Close();
            }
        }

        private void kullaniciekle_Load(object sender, EventArgs e)
        {
            SqlCommand personel = new SqlCommand("Select admin from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)", baglanti.Sqlbaglanti());
            SqlDataReader reader = personel.ExecuteReader();
            if (reader.Read())
            {
                int yetki = Convert.ToInt32(reader["admin"]);
                if (yetki==0)
                {
                    this.Close();
                    MessageBox.Show("Bağlı olan kullanıcının kuıllanıcı hesabı oluşturmak için gerekli yetkisi yoktur.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mail();
                }
            }
            baglanti.Sqlbaglanti().Close();
        }
    }
}
