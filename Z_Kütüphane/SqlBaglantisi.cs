using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Z_Kütüphane
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=OZAN\SQLEXPRESS;Initial Catalog=ZKütüphaneDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
