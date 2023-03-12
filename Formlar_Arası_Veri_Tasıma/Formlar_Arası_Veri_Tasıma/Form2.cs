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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string cb1; // diğer form da public adı altında görünür.
        public string cb2;
        private void Form2_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add(cb1); // diğer formdan veri alır.
            comboBox2.Items.Add(cb2);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();


        }
    }
}
