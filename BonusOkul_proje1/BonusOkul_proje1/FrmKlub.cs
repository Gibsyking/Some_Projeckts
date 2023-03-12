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
    public partial class FrmKlub : Form
    {
        public FrmKlub()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-KO6B9FU\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
        void liste()
        {
            SqlDataAdapter kom = new SqlDataAdapter("Select * From Tbl_Kulup", baglan);
            DataTable dt = new DataTable();
            kom.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmKlub_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Kulup(KULUPAD,KULUPID) values (@p1,@P2)", baglan);
            komut1.Parameters.AddWithValue("@P1", txtad.Text);
            komut1.Parameters.AddWithValue("@p2", textBox1.Text);
      
            komut1.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kulup Eklendi");
            //liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete From Tbl_Kulup Where KULUPID=@P1", baglan);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kulup silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update  Tbl_Kulup Set KULUPAD=@P1 WHERE KULUPID=@P2", baglan);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@P2", textBox1.Text);
            komut.ExecuteNonQuery();
            baglan.Close() ;
            MessageBox.Show("Bilgiler Güncellendi","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }
    }
}
