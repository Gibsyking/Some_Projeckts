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


namespace Personel_Kayit_Projesi
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KO6B9FU\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // Hangi Sehide Kaç personel var.
            baglanti.Open();
            SqlCommand gr1 = new SqlCommand ("Select Persehir,Count(*) From Tbl_Personel Group by Persehir", baglanti);
            SqlDataReader dr1= gr1.ExecuteReader();
            while(dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]); // x 1 satır y 2 satır okur sql içerisinde.
            }

            baglanti.Close();
            //Maaş ortalaması Sehire göre
            baglanti.Open();
            SqlCommand gr2 = new SqlCommand("Select Persehir,avg(PerMaas) From Tbl_Personel Group by PerSehir", baglanti);
            SqlDataReader dr2= gr2.ExecuteReader();          /// avg ile sehirlere göre ortalama maaşlar..
            while(dr2.Read())
            {
                chart2.Series["Maas-Ortalama"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();

            //////şehirlere göre medeni durum
            baglanti.Open();
            SqlCommand gr3 = new SqlCommand("Select PerSehir,sum(PerMaas) From Tbl_Personel Group by PerSehir", baglanti);
            SqlDataReader dr3= gr3.ExecuteReader();
            while (dr3.Read())
            {
                chart3.Series["MedeniDurum"].Points.AddXY(dr3[0], dr3[1]);
            }
            baglanti.Close();

        }




    }
}
