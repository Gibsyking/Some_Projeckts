using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane_Otomasyonu
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti() // sql baglantısı için sıfır tanımlama
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-KO6B9FU\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();  // buradaki amac sınıftan isim türeterek tüm formlara sql dağıtmak tek tek işlememek için bu sınıf içinde sql tanımlanır.
            return baglan; // returnt ile bağlantı dönmezse komut çalışmaz..
        }
    }
}
