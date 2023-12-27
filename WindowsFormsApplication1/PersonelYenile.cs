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
    public partial class PersonelYenile : Form
    {
        public PersonelYenile()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag();
        void mail()
        {
            SqlCommand mailbul = new SqlCommand("select * from mail", baglanti.Sqlbaglanti());
            SqlDataReader dr = mailbul.ExecuteReader();
            while (dr.Read())
            {
                PersonelMailUzantıCombo.Items.Add(dr[1]);
            }
            baglanti.Sqlbaglanti().Close();
        }
        private void GüncelleButton_Click(object sender, EventArgs e)
        {
            bool hatali_mi = false;
            if (PersonelAdText.Text == string.Empty || PersonelSoyadText.Text==string.Empty || PersonelMailText.Text==string.Empty || PersonelTcText.Text==string.Empty || PersonelTelText.Text==string.Empty || PersonelÜnvanText.Text==string.Empty || PersonelAdresText.Text==string.Empty || PersonelMarketIdNumeric.Text == string.Empty)
            {
                hatali_mi = true;
            }
            if (hatali_mi == true)
            {
                MessageBox.Show("Bütün alanları doldurunuz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand personel_yenile = new SqlCommand("update Personeller set PersonelAd='" + PersonelAdText.Text + "', PersonelSoyad='" + PersonelSoyadText.Text + "', PersonelTel='" + PersonelTelText.Text + "', PersonelMail='" + PersonelMailText.Text + "', PersonelMailuzantı='"+PersonelMailUzantıCombo.Text+"', PersonelUnvan='" + PersonelÜnvanText.Text + "', PersonelAdres='" + PersonelAdresText.Text + "', PersonelMarketId='" + PersonelMarketIdNumeric.Value + "', admin='"+AdminCheck.Checked+"' where PersonelTC='" + PersonelTcText.Text + "' ", baglanti.Sqlbaglanti());
                int basarili_mi = personel_yenile.ExecuteNonQuery();
                if (basarili_mi == 1)
                {
                    MessageBox.Show("Güncelleme Başarılı.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Güncellenemedi.");
                    Close();
                }
                baglanti.Sqlbaglanti().Close();
            }
        }

        private void PersonelYenile_Load(object sender, EventArgs e)
        {
            mail();
            SqlCommand command = new SqlCommand("Select *from Personeller where PersonelTC=(Select PersonelTC from PersonelGüncelleme)", baglanti.Sqlbaglanti());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                PersonelAdText.Text = read["PersonelAd"].ToString();
                PersonelSoyadText.Text = read["PersonelSoyad"].ToString();
                PersonelTelText.Text = read["PersonelTel"].ToString();
                PersonelMailText.Text = read["PersonelMail"].ToString();
                PersonelÜnvanText.Text = read["PersonelUnvan"].ToString();
                PersonelAdresText.Text = read["PersonelAdres"].ToString();
                PersonelMarketIdNumeric.Text = read["PersonelPuan"].ToString();
                PersonelTcText.Text = read["PersonelTC"].ToString();
                PersonelMarketIdNumeric.Text = read["PersonelMarketId"].ToString();
                PersonelMailUzantıCombo.Text = read["PersonelMailuzantı"].ToString();
            }
            baglanti.Sqlbaglanti().Close();
            if (PersonelTcText.Text == string.Empty)
            {
                MessageBox.Show("Personel seçiniz.", "HATA");
                this.Close();
            }
        }
    }
}
