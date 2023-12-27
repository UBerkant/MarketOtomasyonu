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
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag();

        private void ŞifreDeğiştirButton_Click(object sender, EventArgs e)
        {
            bool boş_mu = false;
            if (YeniŞifreTekrarText.Text == string.Empty || YeniŞifreText.Text == string.Empty)
            {
                boş_mu = true;
            }
            if (boş_mu == true)
            {
                MessageBox.Show("Bütün alanları doldurunuz.", "HATA");
            }
            else
            {
                SqlCommand command = new SqlCommand("Select *from kullanıcılar where kullanıcıad='" + KullanıcıAdLabel.Text + "'", baglanti.Sqlbaglanti());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (YeniŞifreText.Text == YeniŞifreTekrarText.Text)
                    {
                        SqlCommand degistir = new SqlCommand("Update kullanıcılar set sifre='" + YeniŞifreTekrarText.Text + "' ", baglanti.Sqlbaglanti());
                        degistir.ExecuteNonQuery();
                        baglanti.Sqlbaglanti().Close();
                        MessageBox.Show("Şifre Değiştirildi.");
                    }
                    else
                    {
                        MessageBox.Show("Şifreler uyumlu değil.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Şifre değiştirilemedi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Sqlbaglanti().Close();
                YeniŞifreText.Clear();
                YeniŞifreTekrarText.Clear();
            }
        }
           

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            SqlCommand bul = new SqlCommand("Select *from Giris ", baglanti.Sqlbaglanti());
            KullanıcıAdLabel.Text = "";
            SqlDataReader read = bul.ExecuteReader();
            while (read.Read())
            {
                KullanıcıAdLabel.Text = read["kullanıcıad"].ToString();
            }
            baglanti.Sqlbaglanti().Close();
        }
    }
}
