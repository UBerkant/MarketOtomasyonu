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
    public partial class PersonelSorgulama : Form
    {
        public PersonelSorgulama()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag();
        SqlDataAdapter da;

        void liste()
        {
            da = new SqlDataAdapter("SELECT *FROM Personeller", baglanti.Sqlbaglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Sqlbaglanti().Close();
        }

        void yeniListe()
        {
            da = new SqlDataAdapter("SELECT *FROM Personeller where PersonelAd='"+PersonelAdText.Text+"' and PersonelTC='"+PersonelTcText.Text+"'", baglanti.Sqlbaglanti());
            DataTable yenitablo = new DataTable();
            da.Fill(yenitablo);
            dataGridView1.DataSource = yenitablo;
            baglanti.Sqlbaglanti().Close();
        }

        private void ListeYenileButton_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void PersonelSorgulama_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void PuanGüncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand personel = new SqlCommand("Select admin from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)", baglanti.Sqlbaglanti());
            SqlDataReader reader = personel.ExecuteReader();
            if (reader.Read())
            {
                int yetki = Convert.ToInt32(reader["admin"]);
                if (yetki == 0)
                {
                    MessageBox.Show("Kullanıcı Personel puan güncelleme için gerekli yetkiye sahip değildir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool hatali_mi = false;
                    if (PersonelTcText.Text == string.Empty || PersonelPuanNumeric.Text == string.Empty)
                    {
                        hatali_mi = true;
                    }
                    if (hatali_mi == false)
                    {
                        MessageBox.Show("Bütün alanları doldurunuz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlCommand urunf = new SqlCommand("update Personeller set PersonelPuan=@p where PersonelTC='" + PersonelTcText.Text + "'", baglanti.Sqlbaglanti());
                        urunf.Parameters.AddWithValue("@p", int.Parse(((PersonelPuanNumeric.Value).ToString())));
                        int basarili_mi = urunf.ExecuteNonQuery();
                        baglanti.Sqlbaglanti().Close();
                        if (basarili_mi == 1)
                        {
                            MessageBox.Show("Personel Puanı Güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            liste();
                        }
                        else
                        {
                            MessageBox.Show("Personel Puanı Değiştirilemedi.", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    baglanti.Sqlbaglanti().Close();
                }
            }
            baglanti.Sqlbaglanti().Close();
        }

        private void PersonelGörüntüleButton_Click(object sender, EventArgs e)
        {
            SqlCommand kontrol = new SqlCommand("select * from Personeller where PersonelAd ='" + PersonelAdText.Text + "' and PersonelTC ='" + PersonelTcText.Text + "'", baglanti.Sqlbaglanti());
            kontrol.ExecuteNonQuery();
            SqlDataReader dreader = kontrol.ExecuteReader();
            if (dreader.Read())
            {
                MessageBox.Show("Personel Listelendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yeniListe();
            }
            else
            {
                MessageBox.Show("Personel Bulunamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Sqlbaglanti().Close();
        }

        private void BilgiGüncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand personel = new SqlCommand("Select admin from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)", baglanti.Sqlbaglanti());
            SqlDataReader reader = personel.ExecuteReader();
            if (reader.Read())
            {
                int yetki = Convert.ToInt32(reader["admin"]);
                if (yetki == 0)
                {
                    MessageBox.Show("Kullanıcı Personel bilgi güncelleme işlemi için gerekli yetkiye sahip değildir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand sil = new SqlCommand("Delete from PersonelGüncelleme", baglanti.Sqlbaglanti());
                    sil.ExecuteNonQuery();
                    baglanti.Sqlbaglanti().Close();
                    SqlCommand update = new SqlCommand("insert into PersonelGüncelleme (PersonelTC) values ('" + PersonelTcText.Text + "') ", baglanti.Sqlbaglanti());
                    update.ExecuteNonQuery();
                    baglanti.Sqlbaglanti().Close();
                    var yeniform = new PersonelYenile
                    {
                        ShowInTaskbar = false,
                        MinimizeBox = false,
                        MaximizeBox = false
                    };
                    yeniform.StartPosition = FormStartPosition.CenterParent;
                    yeniform.ShowDialog(this);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PersonelTcText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            PersonelAdText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            PersonelPuanNumeric.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }


        private void PersonelTcText_TextChanged(object sender, EventArgs e)
        {
            SqlCommand control = new SqlCommand("Select * from Personeller where PersonelTC= '" + PersonelTcText.Text + "'", baglanti.Sqlbaglanti());
            SqlDataReader read = control.ExecuteReader();
            while (read.Read())
            {
                PersonelAdText.Text = read["PersonelAd"].ToString();
                PersonelPuanNumeric.Text = read["PersonelPuan"].ToString();
            }
            baglanti.Sqlbaglanti().Close();

        }


    }
}
