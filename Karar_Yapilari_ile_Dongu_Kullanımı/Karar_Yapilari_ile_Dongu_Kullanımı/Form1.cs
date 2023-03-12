using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_ile_Dongu_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = Convert.ToInt16(textBox1.Text);


            for (int i = 1; i <=say; i++)
            {



                {

                    listBox1.Items.Add(i);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);

            for (int i=1; i <= sayi;i++)
                 {
                if ( sayi % i == 0)
                {
                    listBox1.Items.Add(i);

                }
            }

        }
    }
}
