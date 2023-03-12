using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int timer = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer++;
            label1.Text= timer.ToString(" Saniye : " + timer);

            if (timer == 1)
            {
                this.BackColor = Color.Red;



            }
            if (timer == 3)
            {
                this.BackColor = Color.Blue;




            }
            if (timer == 4)
            {
                timer = 0;

            }
        }
    }
}
