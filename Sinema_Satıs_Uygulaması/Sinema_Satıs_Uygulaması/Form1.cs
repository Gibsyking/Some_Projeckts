using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Satıs_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int kasatoplam = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int bilet, misir,toplam;

            bilet = Convert.ToInt16(textBox1.Text);
            misir= Convert.ToInt16(textBox2.Text);
            toplam = bilet * 3 + misir * 10;
            kasatoplam = kasatoplam + toplam;


            label3.Text=toplam.ToString() + "TL";
            label4.Text=kasatoplam.ToString() + "TL";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text= " ";
            textBox1.Focus();
           


        }
    }
}
