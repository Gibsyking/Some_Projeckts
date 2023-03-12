using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geriye_Değer_Döndüren_metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int carp(int t1, int t2, int t3)
        {
            int t4 = t1 * t2 * t3;
            return t4;
        
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = carp(Convert.ToInt16(textBox1.Text),
                Convert.ToInt16(textBox2.Text),Convert.ToInt16(textBox3.Text)).ToString();

           

            
    }
        
          
}
}
