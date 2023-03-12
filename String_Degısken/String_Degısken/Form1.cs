using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Degısken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, yas;

            ad = textBox1.Text;
            soyad = textBox2.Text;
            yas = maskedTextBox1.Text;
            MessageBox.Show("Stringler eklendi");
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + maskedTextBox1.Text);
            label1.Text = ad;   
            label2.Text = soyad;    
            label3.Text = yas;  

        

        }
    }
}
