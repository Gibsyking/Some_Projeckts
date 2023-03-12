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
    public partial class FrnSınavNot : Form
    {
        public FrnSınavNot()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-KO6B9FU\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
        DatasetDerslerTableAdapters.Tbl_NotlarTableAdapter ds=new DatasetDerslerTableAdapters.Tbl_NotlarTableAdapter();
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.notlistesi(int.Parse(textogid.Text));
        }

        private void FrnSınavNot_Load(object sender, EventArgs e)
        {
           
            baglan.Open();
            //dataGridView1.DataSource = ds.notlistesi();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ders", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboders.DisplayMember = "DERSAD"; /////////  combo boxa bilgileri sql den çekmek için kullanılır.
            comboders.ValueMember = "DERSID";
            comboders.DataSource = dt;
            baglan.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textogid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            texts1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            texts2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            texts3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        int notid;
        int s1, s2, s3, proje;
        double ortalama;
        string durum;
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            
            s1 = Convert.ToInt32(texts1.Text);
            s2 = Convert.ToInt32(texts2.Text);
            s3 = Convert.ToInt32(texts3.Text);
            proje = Convert.ToInt32(textproje.Text);
            ortalama=(s1+s2+s3+proje) / 4.00 ;
            textortalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                textdurum.Text = "Geçti";
            }
            else
            {
                textdurum.Text = "Kaldı";
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.guncelle(byte.Parse(comboders.SelectedValue.ToString()), int.Parse(textogid.Text.ToString()), byte.Parse(texts1.Text.ToString()),byte.Parse(texts2.Text.ToString()),byte.Parse(texts3.Text.ToString()),byte.Parse(textproje.Text.ToString()),decimal.Parse(textortalama.Text.ToString()),bool.Parse(textdurum.Text),notid);
        }
    }
}
