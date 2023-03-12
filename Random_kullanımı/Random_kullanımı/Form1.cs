using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd= new Random();


            int s1, s2, s3;
            s1= rd.Next(99,203);
            s2 = rd.Next(204, 305);
            s3 = rd.Next(306, 500);

            label1.Text = s1.ToString();
            label2.Text= s2.ToString();
            label3.Text= s3.ToString();
                       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
        }
    }
}
