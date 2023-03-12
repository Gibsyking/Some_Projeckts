using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_oluşturma_Nesne_Kavramı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Class2 xx = new Class2();

            xx.fiyat = 12.500;
            xx.isim = "İphone";
            xx.model = 12300;
            label1.Text = xx.fiyat.ToString("0.000");
            label2.Text = xx.isim.ToString();
            label3.Text = xx.model.ToString();
            pictureBox1.BackColor = Color.IndianRed;
        }
    }
}
