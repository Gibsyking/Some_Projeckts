using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Fonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;

            sayi = Convert.ToDouble(textBox1.Text);
            //label1.Text=Math.Abs(sayi).ToString();
            //label1.Text=Math.Ceiling(sayi).ToString();
            //label1.Text = Math.Floor(sayi).ToString();
            //label1.Text=Math.Pow(sayi,5).ToString();
            //label1.Text=Math.Sqrt(sayi).ToString();
            //label1.Text=Math.Max(sayi, 5).ToString();



            //abs. mutlak değer
            //ceiling .üste yuvarlama
            //floor. alta yuvarlama
            //powe .üs katı
            //sqrt . karekök
            // min,max. iki değer arasını gösterme
        }
    }
}
