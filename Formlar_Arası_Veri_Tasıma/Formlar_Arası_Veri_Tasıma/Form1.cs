using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arası_Veri_Tasıma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 g= new Form2();   // diğer form için metot ekler.
            string isim, soyisim;

            isim = "";
            soyisim = "";


            g.cb1 = textBox1.Text;  // diğer forma veri gönderir.
            g.cb2 =textBox2.Text;

            g.Show();  // diğer formu açar
           // this.Hide();  // form açıldığında arka planda çalışmaya geçer.


        
        }
    }
}
