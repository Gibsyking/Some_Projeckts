using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje__Pasta_pişirme_progresbar_ile_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if (progressBar1.Value % 10== 0)
            {
                label1.BackColor = Color.Black;
                if (progressBar1.Value % 20==0)
                {
                    label1.BackColor = Color.White;
                }
                if (progressBar1.Value == 100)
                {
                    timer1.Stop();  
                    timer2.Start();
                }
                
              }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if (progressBar2.Value %20==0)
            {
                label2.BackColor = Color.Red;
                if(progressBar2.Value%20==0)
                    label2.BackColor= Color.White;
                if (progressBar2.Value == 100)
                {
                    timer2.Stop();  
                    timer3.Start();
                }
            }
           
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value+= 20;
            if(progressBar3.Value%20==0) 
            {

                label3.BackColor = Color.AliceBlue;
                if(progressBar3.Value%20==0)
                {
                    label3.BackColor = Color.Red;
                    timer3.Stop();
                    

                }
                MessageBox.Show("PASTA PİŞİRME İŞLEMİ BİTTİ !!");
            }
        }
    }
}
