using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    internal class baglantı
    {
       public static  SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-KO6B9FU\SQLEXPRESS;Initial Catalog=DbPersonel;Integrated Security=True");

    }
}
