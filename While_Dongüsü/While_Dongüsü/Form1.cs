using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Dongüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <=10 )
            {
                listBox1.Items.Add("Deneme");
                listBox2.Items.Add(i);
                i++;
                
            }
            MessageBox.Show("Döngü Verildi");

            int r = 1;
            int toplam = 1;

            while (r <=10) 
            {
                toplam=toplam+r;
                r++;

            }
            //MessageBox.Show(listBox1.Text="Döngü"+r);

        }

    }
}
