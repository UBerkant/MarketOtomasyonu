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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        sqlbag baglanti = new sqlbag();

        private void GirisButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM kullanıcılar WHERE kullanıcıad='" + KullanıcıAdıText.Text + "' AND sifre='" + SifreText.Text + "' ", baglanti.Sqlbaglanti());
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand giris_hesab = new SqlCommand("insert into Giris(kullanıcıad, tarih) values('" + KullanıcıAdıText.Text + "', @2)", baglanti.Sqlbaglanti());
                giris_hesab.Parameters.AddWithValue("@2", DateTime.Now);
                giris_hesab.ExecuteNonQuery();
                baglanti.Sqlbaglanti().Close();
                SqlCommand giris_cikis = new SqlCommand("insert into giris_cikis(kullanıcıad, giris) values('"+KullanıcıAdıText.Text+"', @2)", baglanti.Sqlbaglanti());
                giris_cikis.Parameters.AddWithValue("@2", DateTime.Now);
                giris_cikis.ExecuteNonQuery();
                baglanti.Sqlbaglanti().Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatali Giris");
            }
            baglanti.Sqlbaglanti().Close();
        }
        

        private void Cikis_Click(object sender, EventArgs e)
        {
         Application.Exit();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            SqlCommand cikis = new SqlCommand("Select *from giris_cikis where kullanıcıad=(Select kullanıcıad from Giris) and giris=(Select tarih from Giris) ", baglanti.Sqlbaglanti());
            SqlDataReader reader = cikis.ExecuteReader();
            if(reader.Read())
            {
                SqlCommand giris_cikis = new SqlCommand("Update giris_cikis set cikis=@2 where kullanıcıad=(Select kullanıcıad from Giris) and giris=(Select tarih from Giris)", baglanti.Sqlbaglanti());
                giris_cikis.Parameters.AddWithValue("@2", DateTime.Now);
                giris_cikis.ExecuteNonQuery();
                baglanti.Sqlbaglanti().Close();
            }
            baglanti.Sqlbaglanti().Close();
            SqlCommand sil = new SqlCommand("Delete from Giris", baglanti.Sqlbaglanti());
            sil.ExecuteNonQuery();
            baglanti.Sqlbaglanti().Close();
        }

    }
}
