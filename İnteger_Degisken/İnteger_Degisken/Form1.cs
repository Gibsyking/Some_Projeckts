using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnteger_Degisken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi = Convert.ToInt16(textBox1.Text);
            sonuc = sayi * sayi;
            label1.Text = sonuc.ToString();

        }
    }
}
///int tutar, toplam, sonuc;
//tutar = 10;
//toplam = 50;
//sonuc = tutar + toplam;
//label1.Text = sonuc.ToString();
