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
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag();

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand personel = new SqlCommand("Select admin from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)", baglanti.Sqlbaglanti());
            SqlDataReader reader = personel.ExecuteReader();
            if (reader.Read())
            {
                int yetki = Convert.ToInt32(reader["admin"]);
                if (yetki == 0)
                {
                    MessageBox.Show("Kullanıcı ürün eklemek için gerekli yetkiye sahip değildir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var yeniform = new yeniürün
                    {
                        ShowInTaskbar = false,
                        MinimizeBox = false,
                        MaximizeBox = false
                    };
                    yeniform.StartPosition = FormStartPosition.CenterParent;
                    yeniform.ShowDialog(this);
                }
            }
            baglanti.Sqlbaglanti().Close();
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
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
                    var yeniform = new ürünsil
                    {
                        ShowInTaskbar = false,
                        MinimizeBox = false,
                        MaximizeBox = false
                    };
                    yeniform.StartPosition = FormStartPosition.CenterParent;
                    yeniform.ShowDialog(this);
                }
            }
            baglanti.Sqlbaglanti().Close();

        }

        private void Form1_StyleChanged(object sender, EventArgs e)
        {

        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new Destek
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void kullanıcıHesabıOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new kullaniciekle
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.Yes)
            {
                SqlCommand cikisyap = new SqlCommand("Select *from giris_cikis where kullanıcıad=(Select kullanıcıad from Giris) and giris=(Select tarih from Giris) ", baglanti.Sqlbaglanti());
                SqlDataReader reader = cikisyap.ExecuteReader();
                if (reader.Read())
                {
                    SqlCommand giris_cikis = new SqlCommand("Update giris_cikis set cikis=@2 where kullanıcıad=(Select kullanıcıad from Giris) and giris=(Select tarih from Giris)", baglanti.Sqlbaglanti());
                    giris_cikis.Parameters.AddWithValue("@2", DateTime.Now.ToString());
                    giris_cikis.ExecuteNonQuery();
                    baglanti.Sqlbaglanti().Close();
                }
                baglanti.Sqlbaglanti().Close();
                SqlCommand sil = new SqlCommand("Delete from Giris", baglanti.Sqlbaglanti());
                sil.ExecuteNonQuery();
                baglanti.Sqlbaglanti().Close();
                Application.Exit();
            }

        }

        private void ürünSiparişVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new urunsiparis
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }


        private void ürünlerleİligliYardımİçinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new Ürünyardımı
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void marketlerleİlgiliYardımİçinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new marketyardımı
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void ürünStokDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new StokSorgulama
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }




        private void marketOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand personel = new SqlCommand("Select admin from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)", baglanti.Sqlbaglanti());
            SqlDataReader reader = personel.ExecuteReader();
            if (reader.Read())
            {
                int yetki = Convert.ToInt32(reader["admin"]);
                if (yetki == 0)
                {
                    this.Close();
                    MessageBox.Show("Kullanıcı market eklemek için gerekli yetkiye sahip değildir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var yeniform = new marketekle
                    {
                        ShowInTaskbar = false,
                        MinimizeBox = false,
                        MaximizeBox = false
                    };
                    yeniform.StartPosition = FormStartPosition.CenterParent;
                    yeniform.ShowDialog(this);
                }
            }
            baglanti.Sqlbaglanti().Close();
        }

        private void marketleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new Market
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new PersonelEkle
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void personelSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new PersonelSorgulama
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void personelÇıkartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new PersonelCikart
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new SifreDegistir
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void satışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new Satış_İşlemi
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void faturaBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new FaturaBilgisi
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void personellerleİlgiliYardımİçinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new Personelyardim
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void satışİşlemleriyleİlgiliYardımİçinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeniform = new satisyardim
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            yeniform.StartPosition = FormStartPosition.CenterParent;
            yeniform.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var yeniform = new giris
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
