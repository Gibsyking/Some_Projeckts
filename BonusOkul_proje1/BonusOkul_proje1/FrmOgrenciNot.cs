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

namespace BonusOkul_proje1
{
    public partial class FrmOgrenciNot : Form
    {
        public FrmOgrenciNot()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-KO6B9FU\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
        public string numara;
        public string isim;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
          
        }

        private void FrmOgrenciNot_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM FROM Tbl_Notlar\r\nINNER JOIN Tbl_Ders ON Tbl_Notlar.DERSID=Tbl_Ders.DERSID WHERE OGRID=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", numara);
            //this.Text = numara.ToString();
            
            SqlDataAdapter sa=new SqlDataAdapter(komut);
            DataTable dt= new DataTable();
            sa.Fill(dt);
            dataGridView1.DataSource= dt;

            ////
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("select OGRAD,OGRSOY from Tbl_Ogrenci where OGRID=@p1", baglan);

            komut1.Parameters.AddWithValue("@p1", numara); /// ogrencı adını üste verme..

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())

            {

                this.Text = dr1[0] + " " + dr1[1].ToString();

            }
            baglan.Close();

            
        }
    }
}
