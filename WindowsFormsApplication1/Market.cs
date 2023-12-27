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
    public partial class Market : Form
    {
        public Market()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag();
        SqlDataAdapter da;

        void liste()
        {
            da = new SqlDataAdapter("SELECT *FROM Marketler", baglanti.Sqlbaglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Sqlbaglanti().Close();
        }

        void yeniListe()
        {
            da = new SqlDataAdapter("SELECT *FROM Marketler where id='" + MarketIdText.Text + "'", baglanti.Sqlbaglanti());
            DataTable ytablo = new DataTable();
            da.Fill(ytablo);
            dataGridView1.DataSource = ytablo;
            baglanti.Sqlbaglanti().Close();
        }
        private void ListeYenileButton_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void MarketSorgulaButton_Click(object sender, EventArgs e)
        {
            SqlCommand kontrol = new SqlCommand("select * from Marketler where id ='" + MarketIdText.Text + "'", baglanti.Sqlbaglanti());
            kontrol.ExecuteNonQuery();
            SqlDataReader dreader = kontrol.ExecuteReader();
            if (dreader.Read())
            {
                MessageBox.Show("Market Mevcuttur ve Listeye işlendi.", "Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yeniListe();
            }
            else
            {
                MessageBox.Show("Market Bulunmamaktadır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                liste();
            }
            MarketIdText.Clear();
            baglanti.Sqlbaglanti().Close();
        }

        private void MarketSilButton_Click(object sender, EventArgs e)
        {
            SqlCommand personel = new SqlCommand("Select admin from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)", baglanti.Sqlbaglanti());
            SqlDataReader reader = personel.ExecuteReader();
            if (reader.Read())
            {
                int yetki = Convert.ToInt32(reader["admin"]);
                if (yetki == 0)
                {
                    this.Close();
                    MessageBox.Show("Kullanıcı ürün silmek için gerekli yetkiye sahip değildir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand kontrol = new SqlCommand("select * from Marketler where id ='" + MarketIdText2.Text + "' and MarketVergiNo ='" + MarketVergiNumarasıText.Text + "'", baglanti.Sqlbaglanti());
                    kontrol.ExecuteNonQuery();
                    SqlDataReader dreader = kontrol.ExecuteReader();
                    if (dreader.Read())
                    {
                        SqlCommand sil = new SqlCommand("delete from Marketler where id ='" + MarketIdText2.Text + "' and MarketVergiNo ='" + MarketVergiNumarasıText.Text + "'", baglanti.Sqlbaglanti());
                        int basarili = sil.ExecuteNonQuery();
                        baglanti.Sqlbaglanti().Close();
                        if (basarili == 1)
                        {
                            MessageBox.Show("Market başarı ile Kaldırıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            liste();
                        }
                        else
                        {
                            MessageBox.Show("Market Kaldırılamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            liste();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen Market Sistemde Bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    baglanti.Sqlbaglanti().Close();
                }
            }
            MarketVergiNumarasıText.Clear();
            MarketIdText2.Clear();
            baglanti.Sqlbaglanti().Close();
        }

        private void Market_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MarketIdText2.Text = "";
            MarketIdText.Text = "";
            MarketVergiNumarasıText.Text = "";
            MarketIdText2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MarketIdText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MarketVergiNumarasıText.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
