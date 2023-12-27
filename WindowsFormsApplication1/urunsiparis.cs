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
    public partial class urunsiparis : Form
    {
        public urunsiparis()
        {
            InitializeComponent();
        }

        sqlbag baglanti = new sqlbag();
        private void ÜrünAlButton_Click(object sender, EventArgs e)
        {
            bool hatali_mi = false;
            if (BarkodText.Text == string.Empty || ÜrünAdetText.Text==string.Empty || ÜrünAlışFiyatıText.Text == string.Empty)
            {
                hatali_mi = true;
            }
            if (hatali_mi == true)
            {
                MessageBox.Show("Bütün alanları doldurunuz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand urunler = new SqlCommand("update YeniURUNLER set alışfiyatı=@p, adet=@p1+adet where Barkod='"+BarkodText.Text+"'", baglanti.Sqlbaglanti());
                urunler.Parameters.AddWithValue("@p", decimal.Parse((ÜrünAlışFiyatıText.Text)));
                urunler.Parameters.AddWithValue("@p1", int.Parse(ÜrünAdetText.Text));
                int basarili_mi = urunler.ExecuteNonQuery();
                if (basarili_mi == 1)
                {
                    MessageBox.Show("Sipariş Verildi, Stoklara Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Sipariş Verilemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
                baglanti.Sqlbaglanti().Close();
            }
        }

    }
}
