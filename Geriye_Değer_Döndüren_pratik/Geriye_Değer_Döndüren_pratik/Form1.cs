using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geriye_Değer_Döndüren_pratik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int topla(int t1,int t2)
        {
            int t = t1 + t2;
            return t;
        }
            int carp(int t1,int t2)
        {
            int c=t1 * t2;
            return c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = carp(Convert.ToInt16(textBox1.Text),Convert.ToInt16(textBox2.Text)).ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text=topla(Convert.ToInt16(textBox3.Text),Convert.ToInt16(textBox4.Text)).ToString();
        }
    }
}
