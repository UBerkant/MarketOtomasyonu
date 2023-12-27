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
    public partial class PersonelCikart : Form
    {
        public PersonelCikart()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag();

        private void PersonelCikartButton_Click(object sender, EventArgs e)
        {
            SqlCommand kontrol = new SqlCommand("select * from Personeller where PersonelTC ='" + PersonelTcText.Text + "'", baglanti.Sqlbaglanti());
            kontrol.ExecuteNonQuery();
            SqlDataReader dreader = kontrol.ExecuteReader();
            if (dreader.Read())
            {
                SqlCommand sil = new SqlCommand("delete from Personeller where PersonelTC ='" + PersonelTcText.Text + "'", baglanti.Sqlbaglanti());
                baglanti.Sqlbaglanti().Close();
                sil.ExecuteNonQuery();
                MessageBox.Show("Personel Başarı ile Sistemden Silindi.", "Başarılı");
            }
            else
            {
                MessageBox.Show("Personel Sistemde bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Sqlbaglanti().Close();
        }

        private void PersonelCikart_Load(object sender, EventArgs e)
        {
            SqlCommand personel = new SqlCommand("Select admin from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)", baglanti.Sqlbaglanti());
            SqlDataReader reader = personel.ExecuteReader();
            if (reader.Read())
            {
                int yetki = Convert.ToInt32(reader["admin"]);
                if (yetki == 0)
                {
                    this.Close();
                    MessageBox.Show("Bağlı olan kullanıcının kuıllanıcı hesabı oluşturmak için gerekli yetkisi yoktur.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            baglanti.Sqlbaglanti().Close();
        }
    }
}
