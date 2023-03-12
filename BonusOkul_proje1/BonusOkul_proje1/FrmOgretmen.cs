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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKlub fr=new FrmKlub();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDersler frm= new FrmDersler();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgrenci ft= new FrmOgrenci();
            ft.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrnSınavNot fr=new FrnSınavNot();
            fr.Show();
            this.Hide();
        }
    }
}
