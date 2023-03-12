using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point pn = new Point(); // point değer atar..
       
        

          //  int timer; // timer değer atar
        private void button1_Click(object sender, EventArgs e)
        {
            pn.X = 100;
            pn.Y = 150;
            label1.Location= pn;
           
            //timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            //timer++;

            //if(timer == 20)
            //{
            //   pn.X = 20; /// konumları gösterir.
            //   pn.Y = 30;
            //    label1.Location= pn;
            //    label1.BackColor = Color.Red;

            //}

            //if (timer == 30)
            //{
            //    pn.X = 50; 
            //    pn.Y = 80;
            //    label1.Location = pn;
            //    label1.BackColor=Color  .Green;

            //}

            //timer1.Stop(); //timer durdurur
            //MessageBox.Show("Döngü Tamamlandı"); // son mesajı verir



        }
    }
}
