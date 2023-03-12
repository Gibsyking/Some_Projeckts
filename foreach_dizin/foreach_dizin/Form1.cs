using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreach_dizin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] say = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,150,450,150 };
            int ortalama = toplam/say.Length;

            //foreach(int x in say)
            //{
            //    listBox1.Items.Add(x);
            //    toplam = toplam + x;

            //}
            //label1.Text=toplam.ToString();
            
            //foreach(int i in say)
            //{
            //    listBox1.Items.Add(i);
            //    toplam = toplam / i;
            //}
            //label1.Text=toplam.ToString();

           
            




        }
    }
}
