using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[]sayi={1,2,3,4,5 };
            char[] harf = { 'a', 'b', 'c', };

          


            label1.Text = sayi[2].ToString();
            label2.Text = harf[2].ToString();





        }
    }
}
