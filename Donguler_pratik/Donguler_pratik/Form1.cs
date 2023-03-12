using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_pratik
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
            int toplam = 0;

            for(int i=1; i<=10;i+=1)// döngü 1 başlayıp arkadan kalan rakamları toplayarak gidiyor örnek (1+1 1+2 2+3 3+4)
            {
                toplam = toplam + i;

            }
            label1.Text=toplam.ToString();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam2 = 0;
                for (int i=1;i<=3;i+=1) 
            { toplam2 = toplam2 + i; }
                
            label2.Text=toplam2.ToString();
        }
    }
}
