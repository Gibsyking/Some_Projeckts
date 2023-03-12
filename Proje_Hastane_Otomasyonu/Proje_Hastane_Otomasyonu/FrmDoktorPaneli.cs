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

namespace Proje_Hastane_Otomasyonu
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoy.Text);
            komut.Parameters.AddWithValue("@p3", cmbrans.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarı ile Doktor Eklendi.");

        }

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();/// Data Grid veri gösterme
            SqlDataAdapter sd1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            sd1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();


            // Combbox içine veri taşıma
            SqlCommand komut = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbrans.Items.Add(dr[0]);
                bgl.baglanti().Close(); // bunu unutrsan veri gelmez.. 
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete From Tbl_Doktorlar Where DoktorTc=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", msktc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Bilgisi Silindi",MessageBoxButtons.OK+" "+MessageBoxIcon.Hand);
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // datagrid içerisinde şeçilen id numarası.
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); // ad kısmını datagridden şeçme     
            txtsoy.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();// soy ismini datagridden şeçme    
            cmbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString(); // brans cagırma datagridden
            msktc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString(); // tc datagridden şeçme
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();// sifre datagirrden şeçme
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update Tbl_Doktorlar Set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 Where Doktortc=@p5", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",txtad.Text);
            komut3.Parameters.AddWithValue("@p2", txtsoy.Text);
            komut3.Parameters.AddWithValue("@p3",cmbrans.Text);
            komut3.Parameters.AddWithValue("@p4",txtsifre.Text);
            komut3.Parameters.AddWithValue("p5",msktc.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Bilgileri Güncellendi"+MessageBoxIcon.Information);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

