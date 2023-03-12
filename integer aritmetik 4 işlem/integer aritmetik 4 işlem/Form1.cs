using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integer_aritmetik_4_işlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, topla, bol, carp, cıkar;

            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2=Convert.ToInt16(textBox2.Text);
            topla = sayi1 + sayi2;
            bol = sayi1 / sayi2;
            carp = sayi1 * sayi2;
            cıkar=sayi1-sayi2;
            MessageBox.Show("Toplam" + topla + "\n"+"Bölme" + bol + "\n"+"Çarpma" + carp + "\n"+"Çıkarma " + cıkar + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox2.Text);
            textBox2.Text=(textBox1.Text);
            label3.Text = (textBox2.Text);

        }
    }
}
