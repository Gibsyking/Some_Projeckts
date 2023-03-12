using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void renkler()
        {
            textBox1.BackColor = Color.SaddleBrown;
            textBox2.BackColor = Color.SeaShell;
            textBox3.BackColor = Color.Gainsboro;
            textBox4.BackColor= Color.Magenta;
            textBox1.Focus();
        }
        void isimler()
        {
            textBox1.Text = "Rıdvan";
            textBox2.Text = "Aydın";
            textBox3.Text = "Emir";
            textBox4.Text = "Esma Su";
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            ///GERİYE DEĞER DÖNDÜRMEYEN İLE İLGİLİ ÇALIŞMA SCOPE ALANI DIŞINA YAZILIR.
           renkler();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isimler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
