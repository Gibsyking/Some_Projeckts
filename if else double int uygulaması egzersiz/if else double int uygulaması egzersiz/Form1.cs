using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_double_int_uygulaması_egzersiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet;
            double toplam;

            adet = Convert.ToInt16(textBox1.Text);

            if (adet >= 0 && 0<= 10) 
            {
                toplam = (adet * 5) - (adet * 5 * 0.10);
                label3.Text = toplam + "TL";

            }
            if (adet >= 11 && 12 <= 50)
            {
                toplam = (adet * 5) - (adet * 5 * 0.20);
                label3.Text = toplam + " TL";

            }
            

                  
  
       

            }
        }
    }