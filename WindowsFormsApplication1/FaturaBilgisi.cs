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
    public partial class FaturaBilgisi : Form
    {
        public FaturaBilgisi()
        {
            InitializeComponent();
        }
        sqlbag baglanti = new sqlbag();
        SqlDataAdapter da;
        void Liste() //datagridview içerisini doldurmak için listeleme fonksiyonu
        {
            da = new SqlDataAdapter("SELECT *FROM FaturaBilgisi where FaturaID='"+FaturaIDText.Text+"'", baglanti.Sqlbaglanti());
            DataTable ytablo = new DataTable();
            da.Fill(ytablo);
            FaturaBilgisiData.DataSource = ytablo;
            baglanti.Sqlbaglanti().Close();
        }
        private void FaturaGörButton_Click(object sender, EventArgs e)
        {
            bool hatali_mi = false;
            if (FaturaIDText.Text == string.Empty)
            {
                hatali_mi = true;
            }
            if (hatali_mi == false)
            {
                MessageBox.Show("Fatura ID giriniz");
            }
            else
            {
                Liste();
            }
        }

    }
}
