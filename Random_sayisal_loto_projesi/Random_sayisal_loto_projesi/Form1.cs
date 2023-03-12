using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_sayisal_loto_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////random komutu ile sayısal loto uygulaması..
            Random sl= new Random();
            int s1,s2,s3;
            s1= sl.Next(1,3);
            s2= sl.Next(3,5);
            s3= sl.Next(5,8);
            label1.Text=s1.ToString();
            label2.Text=s2.ToString(); 
            label3.Text=s3.ToString();

           // s1
           if (textBox1.Text==label1.Text)
            {
               textBox1.BackColor = Color.CadetBlue;
            }
           else
            {
                textBox1.BackColor=Color.Red;
                label1.BackColor = Color.Green;
            }
            // s2
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.CadetBlue;
            }
            else
            {
                textBox2.BackColor = Color.Red;
                label2.BackColor = Color.Green;
            }
            // s3
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.CadetBlue;
            }
            else
            {
                textBox3.BackColor = Color.Red;
                label3.BackColor = Color.Green;
            }


        }
    }
}
