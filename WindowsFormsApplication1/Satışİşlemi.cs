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
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApplication1
{
    public partial class Satış_İşlemi : Form
    {
        public Satış_İşlemi()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag();

        SqlDataAdapter da;
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        void Liste()
        {
            da = new SqlDataAdapter("SELECT * FROM YeniSepet", baglanti.Sqlbaglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Sqlbaglanti().Close();
        }

        bool durum;

        private void var_mi()
        {
            durum = true;
            SqlCommand kont = new SqlCommand("select *from YeniSepet", baglanti.Sqlbaglanti());
            SqlDataReader dread = kont.ExecuteReader();
            while (dread.Read())
            {
                if (BarkodText.Text == dread["ÜrünBarkod"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Sqlbaglanti().Close();
        }


        private void tutar()
        {
            try
            {
                SqlCommand n = new SqlCommand("select sum(ÜrünToplamFiyatı) from YeniSepet", baglanti.Sqlbaglanti());
                SepetTutarıLabel.Text = n.ExecuteScalar()  + " TL";
                baglanti.Sqlbaglanti().Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void SepeteEkleButton_Click(object sender, EventArgs e)
        {
            
            bool hatali_mi = false;
            if (BarkodText.Text == string.Empty || ÜrünAdıText.Text==string.Empty || AdetText.Text==string.Empty || ÜrünAdetSatışText.Text==string.Empty || ToplamSatışFiyatıText.Text == string.Empty)
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
                    int stok = int.Parse(StokMiktarıLabel.Text.ToString());
                    int adet = int.Parse(AdetText.Text.ToString());
                    if (stok>=adet)
                    {
                        var_mi();
                        if (durum==true)
                        {
                            SqlCommand command = new SqlCommand("insert into YeniSepet(ÜrünBarkod, SepetÜrünAdı, ÜrünAdet, ÜrünAdetFiyatı, ÜrünToplamFiyatı ) values(@2 , @3, @4, @5, @6)", baglanti.Sqlbaglanti());
                            command.Parameters.AddWithValue("@2", BarkodText.Text);
                            command.Parameters.AddWithValue("@3", ÜrünAdıText.Text);
                            command.Parameters.AddWithValue("@4", int.Parse(AdetText.Text));
                            command.Parameters.AddWithValue("@5", double.Parse(ÜrünAdetSatışText.Text));
                            command.Parameters.AddWithValue("@6", double.Parse(ToplamSatışFiyatıText.Text));
                            command.ExecuteNonQuery();
                            baglanti.Sqlbaglanti().Close();
                            Liste();
                            tutar();
                        }
                        else
                        {
                            int StokKontrol = 0;
                            SqlCommand c = new SqlCommand("SELECT (SELECT adet from YeniURUNLER WHERE Barkod=ÜrünBarkod)-SUM(ÜrünAdet) as [ADET] FROM[market_automation2].[dbo].[YeniSepet] WHERE ÜrünBarkod= " +BarkodText.Text + "GROUP BY ÜrünBarkod", baglanti.Sqlbaglanti());
                            SqlDataReader read = c.ExecuteReader();
                            while (read.Read())
                            {
                                StokKontrol = Convert.ToInt32(read["adet"]);
                            }
                            baglanti.Sqlbaglanti().Close();
                            tutar();
                            
                            if(StokKontrol< int.Parse(AdetText.Text))
                            {
                                MessageBox.Show("Stokta kalan miktar :"+StokKontrol.ToString()+"");
                            } 
                            else
                            { 
                                SqlCommand a = new SqlCommand("update YeniSepet set ÜrünAdet=ÜrünAdet+'" + int.Parse(AdetText.Text).ToString() + "' where ÜrünBarkod='"+ BarkodText.Text + "'", baglanti.Sqlbaglanti());
                                a.ExecuteNonQuery();
                                SqlCommand fiyat = new SqlCommand("update YeniSepet set ÜrünToplamFiyatı=ÜrünAdetFiyatı*ÜrünAdet where ÜrünBarkod='" + BarkodText.Text + "'", baglanti.Sqlbaglanti());
                                fiyat.ExecuteNonQuery();
                                Liste();
                                tutar();
                                baglanti.Sqlbaglanti().Close();
                              
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Stoktaki Adet Yetersiz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ürün market sisteminde bulunmamaktadır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Sqlbaglanti().Close();
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ToplamSatışFiyatıText.Text = (int.Parse(AdetText.Text) * double.Parse(ÜrünAdetSatışText.Text)).ToString();
            }
            catch(Exception)
            {

                ;
            }
        }


        private void SeçiliSatırıSilButton_Click(object sender, EventArgs e)
        {
            SqlCommand sepetbosalt = new SqlCommand("Select ÜrünBarkod From YeniSepet where ÜrünBarkod='"+BarkodText.Text+"'", baglanti.Sqlbaglanti());
            SqlDataReader drsepetbosalt = sepetbosalt.ExecuteReader();
            if (drsepetbosalt.Read())
            {
                SqlCommand sil = new SqlCommand("delete from YeniSepet where ÜrünBarkod='" + dataGridView1.CurrentRow.Cells["ÜrünBarkod"].Value.ToString() + "'", baglanti.Sqlbaglanti());
                int basarili = sil.ExecuteNonQuery();
                baglanti.Sqlbaglanti().Close();
                if (basarili == 1)
                {
                    MessageBox.Show("Ürün Sepetten Çıkartıldı.", "Başarılı", MessageBoxButtons.OK);
                    Liste();
                    tutar();
                }
                else
                {
                    MessageBox.Show("Ürün Sepetten Çıkartılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ürünü Seçiniz.", "Bilgilendirme");
            }
            baglanti.Sqlbaglanti().Close();
               
        }

        private void Satış_İşlemi_Load(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from YeniSepet", baglanti.Sqlbaglanti());
            sil.ExecuteNonQuery();
            baglanti.Sqlbaglanti().Close();
            Liste();
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo f in fic)
            {
                KameraCombo.Items.Add(f.Name);
                KameraCombo.SelectedIndex = 0;
            }
            vcd = new VideoCaptureDevice(fic[KameraCombo.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
            int faturaId = 1;
            SqlCommand fatura = new SqlCommand("Select *from FaturaBilgisi", baglanti.Sqlbaglanti());
            SqlDataReader drfatura = fatura.ExecuteReader();
            baglanti.Sqlbaglanti().Close();
            if (drfatura.Read())
            {
                while (drfatura.Read())
                {
                    int faturastemp = Convert.ToInt32(drfatura["FaturaID"]);
                    if (faturaId <= faturastemp)
                    {
                        faturaId = faturastemp + 1;
                    }
                }
            }
            FaturaIDText.Text = faturaId.ToString();
            SqlCommand personel = new SqlCommand("Select * from Personeller where PersonelTC=(Select TC from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)) ", baglanti.Sqlbaglanti());
            SqlDataReader reader = personel.ExecuteReader();
            if (reader.Read())
            {
                SqlCommand personel1 = new SqlCommand("Select * from Personeller where PersonelTC=(Select TC from kullanıcılar where kullanıcıad=(Select kullanıcıad from Giris)) ", baglanti.Sqlbaglanti());
                SqlDataReader reader2 = personel1.ExecuteReader();
                while (reader2.Read())
                {
                    PersonelTcText.Text = reader2["PersonelTC"].ToString();
                    SatışYapanPersonelİsimText.Text = reader2["PersonelAd"].ToString();
                }
                baglanti.Sqlbaglanti().Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Personel listesinde bulunmadığı için satış işlemi yapılamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            baglanti.Sqlbaglanti().Close();
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void SatışButton_Click(object sender, EventArgs e)
        {
            SqlCommand sepetss = new SqlCommand("Select *from YeniSepet", baglanti.Sqlbaglanti());
            SqlDataReader sepetdolumu = sepetss.ExecuteReader();
            if (sepetdolumu.Read())
            {
                bool hatali_mi = false;
                if (FaturaIDText.Text == string.Empty)
                {
                    hatali_mi = true;
                }
                if (hatali_mi == true)
                {
                    MessageBox.Show("FaturaID Giriniz.", "Hata");
                }
                else
                {
                    bool alici_bos = false; // alıcı bilgilerinin boş olup olmaması için kontrol
                    if (AlıcıAdText.Text == string.Empty || AlıcıTelText.Text==string.Empty)
                    {
                        alici_bos = true;
                    }
                    if (alici_bos == true)
                    {
                        MessageBox.Show("Alıcı bilgilerini giriniz.", "HATA");
                    }
                    else
                    {
                        SqlCommand fatura = new SqlCommand("Select FaturaID From FaturaBilgisi where FaturaID='" + int.Parse(FaturaIDText.Text).ToString() + "'  ", baglanti.Sqlbaglanti());
                        SqlDataReader dr = fatura.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Fatura ID Daha Önceden Kullanılmış.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            SqlCommand personelkontrol = new SqlCommand("Select * from Personeller where PersonelTC='" + PersonelTcText.Text + "' ", baglanti.Sqlbaglanti());
                            SqlDataReader personeldr = personelkontrol.ExecuteReader();
                            if (personeldr.Read())
                            {
                                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                                {
                                    SqlCommand satis = new SqlCommand("insert into FaturaBilgisi(FaturaID, ürünkodu, ürünadı, adet, fiyat, toplamfiyat, AlıcıAdı, AlıcıTel, SatışPersonel) values (@1, @2, @3, @4, @5, @6, @7, @8, @9)", baglanti.Sqlbaglanti());
                                    satis.Parameters.AddWithValue("@1", int.Parse(FaturaIDText.Text.ToString()));
                                    satis.Parameters.AddWithValue("@2", dataGridView1.Rows[i].Cells["ÜrünBarkod"].Value.ToString());
                                    satis.Parameters.AddWithValue("@3", dataGridView1.Rows[i].Cells["SepetÜrünAdı"].Value.ToString());
                                    satis.Parameters.AddWithValue("@4", int.Parse(dataGridView1.Rows[i].Cells["ÜrünAdet"].Value.ToString()));
                                    satis.Parameters.AddWithValue("@5", double.Parse(dataGridView1.Rows[i].Cells["ÜrünAdetFiyatı"].Value.ToString()));
                                    satis.Parameters.AddWithValue("@6", double.Parse(dataGridView1.Rows[i].Cells["ÜrünToplamFiyatı"].Value.ToString()));
                                    satis.Parameters.AddWithValue("@7", AlıcıAdText.Text);
                                    satis.Parameters.AddWithValue("@8", AlıcıTelText.Text);
                                    satis.Parameters.AddWithValue("@9", SatışYapanPersonelİsimText.Text);
                                    satis.ExecuteNonQuery();
                                    baglanti.Sqlbaglanti().Close();
                                    SqlCommand stokdus = new SqlCommand("update YeniURUNLER set adet=adet-'" + int.Parse(dataGridView1.Rows[i].Cells["ÜrünAdet"].Value.ToString()) + "' where Barkod='" + dataGridView1.Rows[i].Cells["ÜrünBarkod"].Value.ToString() + "'", baglanti.Sqlbaglanti());
                                    stokdus.ExecuteNonQuery();
                                    baglanti.Sqlbaglanti().Close();
                                    SqlCommand personelpuan = new SqlCommand("update Personeller set PersonelPuan=PersonelPuan+1 where PersonelTC='" + PersonelTcText.Text + "'", baglanti.Sqlbaglanti());
                                    personelpuan.ExecuteNonQuery();
                                    baglanti.Sqlbaglanti().Close();
                                    SqlCommand Temizle = new SqlCommand("Delete from YeniSepet where ÜrünBarkod='" + dataGridView1.Rows[i].Cells["ÜrünBarkod"].Value.ToString() + "'", baglanti.Sqlbaglanti());
                                    Temizle.ExecuteNonQuery();
                                    baglanti.Sqlbaglanti().Close();
                                }
                                MessageBox.Show("Satış Başarılı.", "Tebrikler");
                            }
                            else
                            {
                                MessageBox.Show("Böyle bir Personel Bulunmamaktadır. İşlem Geçersiz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            baglanti.Sqlbaglanti().Close();
                        }
                    }
                    baglanti.Sqlbaglanti().Close();
                    Liste();
                }
            }
            else
            {
                MessageBox.Show("Sepet Boş", "HATA");
            }
            
        }


        private void SatışİptalButton_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from YeniSepet", baglanti.Sqlbaglanti());
            sil.ExecuteNonQuery();
            baglanti.Sqlbaglanti().Close();
            Liste();
        }


        private void BelirliAdetÇıkartButton_Click(object sender, EventArgs e)
        {
            bool hatali_mi = false;
            if (BarkodText.Text == string.Empty)
            {
                hatali_mi = true;
            }
            if (hatali_mi == true)
            {
                MessageBox.Show("Ürün Seçiniz.", "HATA");
            }
            else
            {
                SqlCommand sepetsorgu = new SqlCommand("Select ÜrünBarkod from YeniSepet where ÜrünBarkod='"+BarkodText.Text+"'", baglanti.Sqlbaglanti());
                SqlDataReader drsepetsorgu = sepetsorgu.ExecuteReader();
                if (drsepetsorgu.Read())
                {
                    int sepets = (int.Parse(dataGridView1.CurrentRow.Cells["ÜrünAdet"].Value.ToString()));
                    int istenilens = int.Parse(ÇıkartılacakAdetText.Text.ToString());

                    if (sepets < istenilens)
                    {
                        MessageBox.Show("Sepette o kadar adet bulunmamaktadır.");
                    }
                    else
                    {
                        SqlCommand cikart = new SqlCommand("Update YeniSepet set ÜrünAdet=ÜrünAdet-'" + int.Parse(ÇıkartılacakAdetText.Text).ToString() + "' where ÜrünBarkod='" + BarkodText.Text + "'", baglanti.Sqlbaglanti());
                        cikart.ExecuteNonQuery();
                        baglanti.Sqlbaglanti().Close();
                        SqlCommand hesapla = new SqlCommand("Update YeniSepet set ÜrünToplamFiyatı=ÜrünAdet*ÜrünAdetFiyatı where ÜrünBarkod='" + BarkodText.Text + "'", baglanti.Sqlbaglanti());
                        hesapla.ExecuteNonQuery();
                        baglanti.Sqlbaglanti().Close();
                        tutar();
                        Liste();
                    }
                }
                else
                {
                    MessageBox.Show("Sepette belirtilen ürün bulunmamaktadır.", "HATA");
                }
                baglanti.Sqlbaglanti().Close();
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ÜrünAdetSatışText.Text = "";
            StokMiktarıLabel.Text = "";
            ÜrünAdıText.Text = "";
            SqlCommand c = new SqlCommand("Select * from YeniURUNLER where Barkod like '" + BarkodText.Text + "'", baglanti.Sqlbaglanti());
            SqlDataReader drc = c.ExecuteReader();
            baglanti.Sqlbaglanti().Close();
            if (drc.Read())
            {
                SqlCommand d = new SqlCommand("Select * from YeniURUNLER where Barkod like '" + BarkodText.Text + "'", baglanti.Sqlbaglanti());
                SqlDataReader read = d.ExecuteReader();
                while (read.Read())
                {
                    ÜrünAdetSatışText.Text = read["satışfiyatı"].ToString();
                    StokMiktarıLabel.Text = read["adet"].ToString();
                    ÜrünAdıText.Text = read["ürünad"].ToString();
                }
                baglanti.Sqlbaglanti().Close();
            }           
        }
    }
}
