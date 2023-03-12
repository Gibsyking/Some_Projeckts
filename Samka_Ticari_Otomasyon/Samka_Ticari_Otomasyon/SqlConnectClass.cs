using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Samka_Ticari_Otomasyon
{
    internal class SqlConnectClass
    {
        public SqlConnection baglantı() // sql baglantısı için sınıf oluşturulur. her sayfada ayrı ayrı bağlanmamak için. bu çağrılır.
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-KO6B9FU\SQLEXPRESS;Initial Catalog=DboTicariotomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
         

    }
}
