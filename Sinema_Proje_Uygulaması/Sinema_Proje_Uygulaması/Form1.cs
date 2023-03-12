using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Proje_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lisansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama Samka Yazılım Tarafından geliştirilmiştir", "İnfo", MessageBoxButtons.OK);
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void c1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=89Ji7WYIiTk&list=RD89Ji7WYIiTk&start_radio=1");
            label1.Text = ("Deneme");     
        }

        private void c2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
            label1.Text = ("Deneme 2");
        }
    }
}
