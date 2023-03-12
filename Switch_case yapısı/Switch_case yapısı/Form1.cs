using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case_yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1, s2;
            int islem = ToString;

            switch (islem)
            
            {
                case "+":textBox1.Text = "Toplama";break;
                case "-":textBox1.Text = "çıkarma";break;
                case "*":textBox1.Text = "çarpma";break;
                case "/":textBox1.Text = "bölme";break;
                
                default:label1.Text = "Hatalı";
            }

               
         


            }

        }
    }

