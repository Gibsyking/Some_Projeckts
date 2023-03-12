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
using System.Data.Common;

namespace BonusOkul_proje1
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-KO6B9FU\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True"); 
        DatasetDerslerTableAdapters.DataTable1TableAdapter ds = new DatasetDerslerTableAdapters.DataTable1TableAdapter();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Ogrenciliste();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kulup",baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt= new DataTable();
            da.Fill(dt);
            comboklup.DisplayMember= "KULUPAD"; /////////  combo boxa bilgileri sql den çekmek için kullanılır.
            comboklup.ValueMember = "KULUPID";
            comboklup.DataSource= dt;
            baglan.Close();

        }
        string c = "";

        private void btnekle_Click(object sender, EventArgs e)
        {
           
            if (radioerkek.Checked == true)
            {
                c = "Erkek";
            }
            if(radiokiz.Checked== true)
            {
                c = "Kız";
            }
            ds.ogrenciekle(txtad.Text, txtsoy.Text, byte.Parse(comboklup.SelectedValue.ToString()), c ); // combokulup kısmında id numarasını girmeden çalışmaz.. buna dikkat et
            MessageBox.Show("Ogrencı Eklendi");
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Ogrenciliste();
        }

        private void comboklup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtogrid.Text=comboklup.SelectedValue.ToString(); // BURADAKİ ÖRNEKTE COMBOBOXTAKİ DEĞERİ ŞEÇTİĞİNDE İD MUMARASINI İD TXT AKTARMAK..
        }
        int notid;
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            ds.ogrenciguncelle(txtad.Text, txtsoy.Text, byte.Parse(comboklup.SelectedValue.ToString()),c,int.Parse(txtogrid.Text.ToString()));
            MessageBox.Show("Güncellendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.ogrencisil(int.Parse(txtogrid.Text));
            MessageBox.Show("ogrenci silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtogrid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoy.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboklup.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            c = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (c == "Erkek") 
            {
                radioerkek.Checked = true;
                radiokiz.Checked = false;
            }
            if (c=="Kız")
            {
                radioerkek.Checked = false;
                radiokiz.Checked = true;
            }
        }

        private void radiokiz_CheckedChanged(object sender, EventArgs e)
        {
            if (radioerkek.Checked == true)
            {
                c = "Erkek";
            }
            if (radiokiz.Checked == true)
            {
                c = "Kız";
            }
        }

        private void radioerkek_CheckedChanged(object sender, EventArgs e)
        {
            if (radioerkek.Checked == true)
            {
                c = "Erkek";
            }
            if (radiokiz.Checked == true)
            {
                c = "Kız";
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ogrenciarama(txtara.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
