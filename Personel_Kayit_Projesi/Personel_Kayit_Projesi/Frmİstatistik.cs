using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // her yeni forumda sql için tanımlanması gerekir.

namespace Personel_Kayit_Projesi
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KO6B9FU\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            ///İstatistikler aşağıda komutlar gibidir..
            ///
            // toplam personel sayisi
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count (*) From Tbl_Personel", baglanti); // komut ile sonuçları çekmek için kullanılan kod.
            SqlDataReader dr1= komut1.ExecuteReader(); // şeçilen komutları okuma yeri..
            while (dr1.Read()) // while ile değere ulaşma..
            {
                txttoplamper.Text = dr1[0].ToString(); // değerin atandığı yer.
            }
            baglanti.Close();

            //evli personel sayisi
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                txttoplamevli.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //bekar personel sayisi
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                txttoplambekar.Text = dr3[0].ToString();
            }
           
            baglanti.Close();

            //sehir sayisi
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count (distinct (PerSehir)) From Tbl_Personel ", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                txtsehirsayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //toplam maas
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                txttoplammaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //ortalama maas
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                txtortalamamaas.Text = dr6[0].ToString();
            }
            baglanti.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
