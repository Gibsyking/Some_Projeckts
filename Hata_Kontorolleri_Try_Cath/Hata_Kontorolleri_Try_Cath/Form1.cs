using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hata_Kontorolleri_Try_Cath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt16(textBox1.Text);
                int sayi2 = Convert.ToInt16(textBox2.Text);
                int topla = sayi1 + sayi2;
                MessageBox.Show("Sonuç" + topla);
            }
            catch (Exception) ///// program debug verip kapanmasın diye try cath kullanılır..
            {

                MessageBox.Show("Değerleri Kontrol edin "); // try cath kullanımı
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt16(textBox3.Text);
                s2 = Convert.ToInt16(textBox4.Text);
                sonuc = s1 * s2;
                label5.Text = sonuc.ToString();
            }
            catch (Exception ) /// exception içinde değer ile hata sebebi gösterilebilir..
            {
                MessageBox.Show("Hata Var lütfen firma ile iletişime geçiniz.");
                
            }
            finally
            {
                MessageBox.Show("Hata Yok ");
            }
    }
}
}
