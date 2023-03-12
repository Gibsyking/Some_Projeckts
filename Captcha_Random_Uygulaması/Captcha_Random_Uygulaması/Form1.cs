using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha_Random_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c" };
            string[] sembol2 = { "/", "*", "-" };
            
            Random cp=new Random();

            int s1,s2,s3;
            s1= cp.Next(0,sembol1.Length);
            s2=cp.Next(0,sembol2.Length);
            s3 = cp.Next(0, 10);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString()+s3.ToString();
            
            if(textBox1.Text==label1.Text)
            {
                label2.Text = "Giriş Başarılı";
                MessageBox.Show("Başarılı");
                label2.BackColor = Color.Green;
            }
            else
            {
                label2.Text = "Başarısız";
               // MessageBox.Show("Tekrar deneyiniz");
                label2.BackColor = Color.Red;
            }


        
            

        }
    }
}
