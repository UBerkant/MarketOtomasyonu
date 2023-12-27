using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class sqlbag
    {
        public SqlConnection Sqlbaglanti() //Sql bağlantısı için sınıf
        {
            SqlConnection baglanti = new SqlConnection(/* Sql bağlantısı buraya yazılacak */); 
            baglanti.Open();
            return baglanti;
        }
    }
}
