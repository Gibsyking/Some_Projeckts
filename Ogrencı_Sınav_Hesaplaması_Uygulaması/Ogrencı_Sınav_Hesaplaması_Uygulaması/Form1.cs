using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrencı_Sınav_Hesaplaması_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soy;
            int s1,s2,s3;
            double ortalama;

            ad = textBox1.Text;
            soy= textBox2.Text;
            s1 = Convert.ToInt16(textBox3.Text);
            s2= Convert.ToInt16(textBox4.Text);
            s3= Convert.ToInt16(textBox5.Text);
            ortalama = (s1 + s2 + s3) / 3;
            listBox1.Items.Add("Öğrenci Bilgisi :"+ ad + " " + soy + " " + " Ortalaması :" + ortalama);
            MessageBox.Show("Başarıyla Hesaplandı");
        }
    }
}
