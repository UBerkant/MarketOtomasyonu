using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApplication1
{
    public partial class StokSorgulama : Form
    {
        public StokSorgulama()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag();

        SqlDataAdapter da;
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        void liste()
        {
            da = new SqlDataAdapter("SELECT *FROM YeniURUNLER", baglanti.Sqlbaglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Sqlbaglanti().Close();
        }

        void YeniListe()
        {
            da = new SqlDataAdapter("SELECT *FROM YeniURUNLER where Barkod='"+BarkodText.Text+"'", baglanti.Sqlbaglanti());
            DataTable ytablo = new DataTable();
            da.Fill(ytablo);
            dataGridView1.DataSource = ytablo;
            baglanti.Sqlbaglanti().Close();
        }

        private void SorgulaButton_Click(object sender, EventArgs e)
        {
            bool hatali_mi = false;
            if (BarkodText.Text == string.Empty)
            {
                hatali_mi = true;
            }
            if (hatali_mi == true)
            {
                MessageBox.Show("Gerekli alanı doldurunuz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand kontrol = new SqlCommand("select * from YeniURUNLER where Barkod ='" + BarkodText.Text + "'", baglanti.Sqlbaglanti());
                kontrol.ExecuteNonQuery();
                SqlDataReader dreader = kontrol.ExecuteReader();
                if (dreader.Read())
                {
                    MessageBox.Show("Ürün Mevcuttur.", "Başarılı", MessageBoxButtons.OK);
                    YeniListe();
                }
                else
                {
                    MessageBox.Show("Ürün market sisteminde bulunmamaktadır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                BarkodText.Clear();
                baglanti.Sqlbaglanti().Close();
            }
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ListeYenileButton_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void StokSorgulama_Load_1(object sender, EventArgs e)
        {
            liste();
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo f in fic)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
            }
            vcd = new VideoCaptureDevice(fic[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }

        private void FiyatGüncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand personel = new SqlCommand("Select admin from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)", baglanti.Sqlbaglanti());
            SqlDataReader reader = personel.ExecuteReader();
            baglanti.Sqlbaglanti().Close();
            if (reader.Read())
            {
                int yetki = Convert.ToInt32(reader["admin"]);
                if (yetki == 0)
                {
                    MessageBox.Show("Kullanıcının fiyat güncelleme işlemi için gerekli yetkisi yoktur.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool hatali_mi = false;
                    if (BarkodText3.Text == string.Empty || ÜrünYeniSatışText.Text == string.Empty)
                    {
                        hatali_mi = true;
                    }
                    if (hatali_mi == true)
                    {
                        MessageBox.Show("Bütün alanları doldurunuz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlCommand urunf = new SqlCommand("update YeniURUNLER set satışfiyatı='" + ÜrünYeniSatışText.Text + "' where Barkod='" + BarkodText3.Text + "'", baglanti.Sqlbaglanti());
                        int basarili_mi = urunf.ExecuteNonQuery();
                        baglanti.Sqlbaglanti().Close();
                        if (basarili_mi == 1)
                        {
                            MessageBox.Show("Satış Fiyatı Değiştirildi.", "Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Satış Fiyatı Değiştirilemedi.", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        BarkodText3.Clear();
                        ÜrünYeniSatışText.Clear();
                    }
                    baglanti.Sqlbaglanti().Close();
                    liste();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            BarkodText3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            BarkodText2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barkod = new BarcodeReader();
                Result sonuc = barkod.Decode((Bitmap)pictureBox1.Image);
                if (sonuc != null)
                {
                    BarkodText.Text = sonuc.ToString();
                    BarkodText3.Text = sonuc.ToString();
                    BarkodText2.Text = sonuc.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void SiparişVerButton_Click(object sender, EventArgs e)
        {
            SqlCommand personel = new SqlCommand("Select admin from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)", baglanti.Sqlbaglanti());
            SqlDataReader reader = personel.ExecuteReader();
            baglanti.Sqlbaglanti().Close();
            if (reader.Read())
            {
                int persvar = Convert.ToInt32(reader["admin"]);
                if (persvar == 0)
                {
                    MessageBox.Show("Kullanıcının sipariş vermek için gerekli yetkisi yoktur.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool hatali_mi = false;
                    if (ÜrünAdetText.Text == string.Empty || ÜrünAlışText.Text==string.Empty || BarkodText2.Text == string.Empty)
                    {
                        hatali_mi = true;
                    }
                    if (hatali_mi == true)
                    {
                        MessageBox.Show("Bütün alanları doldurunuz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);                        
                    }
                    else
                    {
                        SqlCommand urunler = new SqlCommand("update YeniURUNLER set alışfiyatı=@p, adet=@p1+adet where Barkod='" + BarkodText2.Text + "'", baglanti.Sqlbaglanti());
                        urunler.Parameters.AddWithValue("@p", decimal.Parse((ÜrünAlışText.Text)));
                        urunler.Parameters.AddWithValue("@p1", int.Parse(ÜrünAdetText.Text));
                        int basarili_mi = urunler.ExecuteNonQuery();
                        if (basarili_mi == 1)
                        {
                            MessageBox.Show("Sipariş Verildi, Stoklara Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            liste();
                        }
                        else
                        {
                            MessageBox.Show("Sipariş Verilemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            liste();
                        }
                        baglanti.Sqlbaglanti().Close();
                    }
                }
            }

        }
    }
}
