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

namespace WindowsFormsApplication1
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
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
                PersonelMailUzantıCombo.Items.Add(dr[1]);
            }
            baglanti.Sqlbaglanti().Close();
        }
        private void PersonelEkleButton_Click(object sender, EventArgs e)
        {
            bool hatali_mi = false;
            if (PersonelAdText.Text == string.Empty || PersonelSoyadText.Text == string.Empty || PersonelMailText.Text == string.Empty || PersonelTcText.Text == string.Empty || PersonelTelText.Text == string.Empty || PersonelÜnvanText.Text == string.Empty || PersonelAdresText.Text == string.Empty || PersonelMarketIdNumeric.Text == string.Empty || PersonelPuanNumeric.Text == string.Empty)
            {
                hatali_mi = true;
            }
            if (hatali_mi == true)
            {
                MessageBox.Show("Bütün alanları doldurunuz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand kontrol = new SqlCommand("select * from Marketler where id ='" + PersonelMarketIdNumeric.Value + "'", baglanti.Sqlbaglanti());
                kontrol.ExecuteNonQuery();
                SqlDataReader dreader = kontrol.ExecuteReader();
                if (dreader.Read())
                {
                    SqlCommand var_mi = new SqlCommand("Select *from Personeller where PersonelTc='" + PersonelTcText.Text + "'", baglanti.Sqlbaglanti());
                    SqlDataReader dr = var_mi.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Girilen TC sistemde başka bir personelde kullanılmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand tel = new SqlCommand("Select *from Personeller where PersonelTel='" + PersonelTelText.Text + "'", baglanti.Sqlbaglanti());
                        SqlDataReader drtel = tel.ExecuteReader();
                        if (drtel.Read())
                        {
                            MessageBox.Show("Girilen Telefon numarası sistemde başka bir personelde kullanılmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            SqlCommand mail = new SqlCommand("Select *from Personeller where PersonelMail='" + PersonelMailText.Text + "'", baglanti.Sqlbaglanti());
                            SqlDataReader drmail = mail.ExecuteReader();
                            if (drmail.Read())
                            {
                                MessageBox.Show("Girilen Mail adresi sistemde başka bir personelde kullanılmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                SqlCommand personel_ekle = new SqlCommand("insert into Personeller(PersonelAd, PersonelSoyad, PersonelTC, PersonelTel, PersonelMail, PersonelMailuzantı, PersonelUnvan, PersonelAdres, PersonelMarketId, PersonelPuan) values('" + PersonelAdText.Text + "','" + PersonelSoyadText.Text + "','" + PersonelTcText.Text + "','" + PersonelTelText.Text + "','" + PersonelMailText.Text + "', '"+PersonelMailUzantıCombo.Text+"', '" + PersonelÜnvanText.Text + "','" + PersonelAdresText.Text + "','" + PersonelMarketIdNumeric.Value + "', '" + PersonelPuanNumeric.Value + "')", baglanti.Sqlbaglanti());
                                int basarili_mi = personel_ekle.ExecuteNonQuery();
                                baglanti.Sqlbaglanti().Close();
                                if (basarili_mi == 1)
                                {
                                    MessageBox.Show("Personel Eklendi.");
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Personel eklenemedi.");
                                    Close();
                                }
                                baglanti.Sqlbaglanti().Close();
                            }
                        }
                        baglanti.Sqlbaglanti().Close();
                    }
                    baglanti.Sqlbaglanti().Close();
                }
                else
                {
                    MessageBox.Show("Market sistemde bulunmamaktadır.");
                }
                baglanti.Sqlbaglanti().Close();
            }
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            mail();
            SqlCommand personel = new SqlCommand("Select admin from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)", baglanti.Sqlbaglanti());
            SqlDataReader reader = personel.ExecuteReader();
            if (reader.Read())
            {
                bool yetki = Convert.ToBoolean(reader["admin"]);
                if (yetki == false)
                {
                    this.Close();
                    MessageBox.Show("Kullanıcı Personel hesabı oluşturmak için gerekli yetkiye sahip değildir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            baglanti.Sqlbaglanti().Close();
        }
    }
}
