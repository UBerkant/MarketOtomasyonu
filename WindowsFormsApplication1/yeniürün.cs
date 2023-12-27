using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using ZXing;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class yeniürün : Form
    {
        public yeniürün()
        {
            InitializeComponent();
        }
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;
        sqlbag baglanti = new sqlbag();
        private void ÜrünEkleButton_Click(object sender, EventArgs e)
        {
            bool hatali_mi = false;
            if (ÜrünAdıText.Text == string.Empty || ÜrünBilgiText.Text==string.Empty || ÜrünSatışFiyatText.Text==string.Empty || BarkodText.Text == string.Empty)
            {
                hatali_mi = true;
            }
            if (hatali_mi == true)
            {
                MessageBox.Show("Bütün alanları doldurunuz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand kontrol = new SqlCommand("select * from YeniURUNLER where Barkod ='" + BarkodText.Text + "'", baglanti.Sqlbaglanti());
                kontrol.ExecuteNonQuery();
                SqlDataReader dreader = kontrol.ExecuteReader();
                if (dreader.Read())
                {
                    MessageBox.Show("Ürün Market Sisteminde Bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int adet = 0;
                    SqlCommand command = new SqlCommand("insert into YeniURUNLER (Barkod, ürünad, ürünbilgisi, satışfiyatı, adet) values('" + BarkodText.Text + "', '" + ÜrünAdıText.Text + "','" + ÜrünBilgiText.Text + "', '" + ÜrünSatışFiyatText.Text + "', '" + adet + "')", baglanti.Sqlbaglanti());
                    command.ExecuteNonQuery();
                    baglanti.Sqlbaglanti().Close();
                    MessageBox.Show("Ürün Eklendi.");
                }

                baglanti.Sqlbaglanti().Close();
            }
        }

        private void yeniürün_Load(object sender, EventArgs e)
        {
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo f in fic)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
            }
            vcd = new VideoCaptureDevice(fic[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                BarcodeReader barkod = new BarcodeReader();
                Result sonuc = barkod.Decode((Bitmap)pictureBox1.Image);
                if (sonuc != null)
                {
                    BarkodText.Text = sonuc.ToString();
                }
            }
        }

        private void ÇıkışButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

    }
}
