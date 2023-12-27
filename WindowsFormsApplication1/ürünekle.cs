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
    public partial class ürünekle : Form
    {
        public ürünekle()
        {
            InitializeComponent();
        }

        sqlbag baglanti = new sqlbag();
        
        private void ÜrünEkleButton_Click(object sender, EventArgs e)
        {
            SqlCommand kontrol = new SqlCommand("select * from URUNLER where ürünkodu ='"+ÜrünKoduText.Text+"'", baglanti.Sqlbaglanti());
            kontrol.ExecuteNonQuery();
            SqlDataReader dreader = kontrol.ExecuteReader();
            if (dreader.Read())
            {
                MessageBox.Show("Ürün Market Sisteminde Bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int adet = 0;
                SqlCommand command = new SqlCommand("insert into URUNLER (ürünad, ürünkodu, ürünbilgisi, satışfiyatı, adet) values('" + ÜrünAdıText.Text + "', '" + ÜrünKoduText.Text + "','" + ÜrünBilgiText.Text + "', '" + ÜrünSatışFiyatıText.Text + "', '"+adet+"')", baglanti.Sqlbaglanti());
                command.ExecuteNonQuery();
                baglanti.Sqlbaglanti().Close();
                MessageBox.Show("Ürün Eklendi.");
            }
            baglanti.Sqlbaglanti().Close();
        }
    }
}
