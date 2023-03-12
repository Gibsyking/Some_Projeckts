using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusOkul_proje1
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DatasetDerslerTableAdapters.Tbl_DersTableAdapter ds = new DatasetDerslerTableAdapters.Tbl_DersTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ds.Derslistesi();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Dersekle(txtad.Text);
            MessageBox.Show("Ders Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.Derssil(byte.Parse(textBox1.Text));
            MessageBox.Show("Ders Silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds.Dersgüncelle(txtad.Text,byte.Parse(textBox1.Text));
            MessageBox.Show("Ders Güncellendi");
        }
    }
}
