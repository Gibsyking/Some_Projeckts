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
    public partial class Frmbrans : Form
    {
        public Frmbrans()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void Frmbrans_Load(object sender, EventArgs e)
        {
            // Braş gösterme
            DataTable dt1 = new DataTable();/// Data Grid veri gösterme
            SqlDataAdapter sd1 = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            sd1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut4= new SqlCommand("insert into  Tbl_Branslar (BransAd) values (@p1) ", bgl.baglanti());
            
            komut4.Parameters.AddWithValue("@p1",txtad.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Eklendi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut5 = new SqlCommand("Update Tbl_Branslar set BransAd=@p1 where Bransid=@p2", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p1", txtad.Text);
            komut5.Parameters.AddWithValue("@p2", txtid.Text);
            komut5.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut6 = new SqlCommand("Delete From Tbl_Branslar Where Bransid=@p1", bgl.baglanti());
            komut6.Parameters.AddWithValue("@p1", txtid.Text);
            komut6.ExecuteNonQuery();   
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");

        }
    }

    // private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    //{


    // private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    // {

    //}
}

