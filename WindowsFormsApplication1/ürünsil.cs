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
    public partial class ürünsil : Form
    {
        public ürünsil()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag();

        private void ÜrünSilButton_Click(object sender, EventArgs e)
        {
            SqlCommand kontrol = new SqlCommand("select * from YeniURUNLER where Barkod ='" +BarkodText.Text+"'", baglanti.Sqlbaglanti());
            kontrol.ExecuteNonQuery();
            SqlDataReader dreader = kontrol.ExecuteReader();
            if (dreader.Read())
            {
                SqlCommand sil= new SqlCommand("delete from YeniURUNLER where Barkod ='" + BarkodText.Text + "'", baglanti.Sqlbaglanti());
                int basarili = sil.ExecuteNonQuery();
                baglanti.Sqlbaglanti().Close();
                if (basarili == 1)
                {
                    MessageBox.Show("Ürün başarı ile silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ürün silinemedi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ürün Market Sisteminde Bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            BarkodText.Clear();
            baglanti.Sqlbaglanti().Close();
        }

    }
}
