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
    public partial class marketekle : Form
    {
        public marketekle()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag(); //Sql bağlantısını çağırıyor

        void iller()
        {
            SqlCommand il = new SqlCommand("select * from iller", baglanti.Sqlbaglanti()); 
            SqlDataReader dr = il.ExecuteReader();
            while (dr.Read())
            {
                MarketILCombo.Items.Add(dr[1]);
            }
            baglanti.Sqlbaglanti().Close();
        }
        void mail()
        {
            SqlCommand mailbul = new SqlCommand("select * from mail", baglanti.Sqlbaglanti());
            SqlDataReader dreadsdaf = mailbul.ExecuteReader();
            while (dreadsdaf.Read())
            {
                MarketMailUzantıCombo.Items.Add(dreadsdaf[1]);
            }
            baglanti.Sqlbaglanti().Close();
        }

        private void MarketEkleButton_Click(object sender, EventArgs e)
        {
            bool hatali_mi = false;
            if (MarketAdıText.Text == string.Empty || MarketVergiText.Text==string.Empty || MarketAdresiText.Text==string.Empty || MarketTelText.Text==string.Empty || MarketILCombo.Text==string.Empty || MarketMail.Text==string.Empty || MarketILceCombo.Text == string.Empty)
            {
                hatali_mi = true;
            }

            if (hatali_mi == true)
            {
                MessageBox.Show("Bütün alanları doldurunuz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand adres = new SqlCommand("Select * from Marketler where MarketAdresi='"+MarketAdresiText.Text+"' ", baglanti.Sqlbaglanti());
                SqlDataReader read = adres.ExecuteReader();
                baglanti.Sqlbaglanti().Close();
                if (read.Read())
                {
                    MessageBox.Show("Market adresi daha önceden kullanılmış aynı konuma market açılamaz.", "HATA");
                }
                else
                {
                    SqlCommand vergi_no = new SqlCommand("Select *from Marketler where MarketVergiNo='"+MarketVergiText.Text+"'", baglanti.Sqlbaglanti());
                    SqlDataReader reade = vergi_no.ExecuteReader();
                    baglanti.Sqlbaglanti().Close();
                    if (reade.Read())
                    {
                        MessageBox.Show("Girilen vergi numarası daha önce kullanılmış.", "HATA");
                    }
                    else
                    {
                        SqlCommand tel = new SqlCommand("Select *from Marketler where MarketTel='"+MarketTelText.Text+"'", baglanti.Sqlbaglanti());
                        SqlDataReader reader = tel.ExecuteReader();
                        baglanti.Sqlbaglanti().Close();
                        if (reader.Read())
                        {
                            MessageBox.Show("Girilen telefon numarası daha önce kullanılmış.", "HATA");
                        }
                        else
                        {
                            SqlCommand mail_var = new SqlCommand("Select *from Marketler where MarketMail='"+MarketMail.Text+"' and MarketMailuzantı='"+MarketMailUzantıCombo.Text+"' ", baglanti.Sqlbaglanti());
                            SqlDataReader reader2 = mail_var.ExecuteReader();
                            baglanti.Sqlbaglanti().Close();
                            if (reader2.Read())
                            {
                                MessageBox.Show("Girilen mail adresi daha önce kullanılmış.", "HATA");
                            }
                            else
                            {
                                SqlCommand market_ekle = new SqlCommand("insert into Marketler(MarketAdı, MarketSehri, Marketİlçesi, MarketTel, MarketMail, MarketMailuzantı, MarketVergiNo, MarketAdresi) values('" + MarketAdıText.Text + "','" + MarketILCombo.Text + "','" + MarketILceCombo.Text + "','" + MarketTelText.Text + "','" + MarketMail.Text + "', '" + MarketMailUzantıCombo.Text + "', '" + MarketVergiText.Text + "','" + MarketAdresiText.Text + "')", baglanti.Sqlbaglanti());
                                int basarili_mi = market_ekle.ExecuteNonQuery();
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

                        }
                    }
                }
            }
        }
    

        private void marketekle_Load(object sender, EventArgs e)
        {
            iller();
            mail();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarketILceCombo.Items.Clear();
            MarketILceCombo.Text = "";
            SqlCommand ilce = new SqlCommand("Select * from ilceler where sehir=@p", baglanti.Sqlbaglanti());
            ilce.Parameters.AddWithValue("@p", MarketILCombo.SelectedIndex + 1);
            SqlDataReader dreader = ilce.ExecuteReader();
            while (dreader.Read())
            {
                MarketILceCombo.Items.Add(dreader[1]);
            }
            baglanti.Sqlbaglanti().Close();
        }
    }
}
