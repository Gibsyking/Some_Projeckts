using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_oluşturma_Nesne_Kavramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class2 xx= new Class2();

            xx.fiyat = 12.500;
            xx.isim = "İphone";
            xx.YIL = 1998;
            xx.imei = 0;
            xx.imei2 = "bilmiyorum";
            
            xx.model = 12300;
    label1.Text=xx.fiyat.ToString("0.000");
           label2.Text=xx.isim.ToString();
            label3.Text=xx.model.ToString();
            pictureBox1.BackColor = Color.CornflowerBlue;
            label4.Text=xx.YIL.ToString();
            label5.Text=xx.imei.ToString();
            label6.Text = xx.imei2;
            

          





        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
