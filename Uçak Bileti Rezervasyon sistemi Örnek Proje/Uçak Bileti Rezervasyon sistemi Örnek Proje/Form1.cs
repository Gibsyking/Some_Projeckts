using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçak_Bileti_Rezervasyon_sistemi_Örnek_Proje
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
            listBox1.Items.Add("BİLGİLER " + comboBox1.Text + " " + comboBox2.Text + " " + dateTimePicker1.Text + " " +maskedTextBox1.Text+ " " +textBox1.Text+" "+textBox2.Text+ " " + maskedTextBox2.Text+ " "+maskedTextBox3.Text);
            MessageBox.Show(" Bilgiler Başarıyla Kayıt Edildi");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text= comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text=label10.Text;
            MessageBox.Show(" Dikkat rota değiştirildi !");
            // yön değiştirme için kullanılabilir.

        }
    }
}
