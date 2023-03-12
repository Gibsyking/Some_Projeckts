using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Grafik_Aracı_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void chart1_Click(object sender, EventArgs e)
        {

            chart1.Series["Deneme"].Points.AddXY("Stok", 12);
            chart1.Series["Deneme"].Points.AddXY("Cari", 45);
            chart1.Series["Deneme"].Points.AddXY("Stok", 65);
            /// series kısmında name kısmına isim muhakak aynı yazılmalıdır..
        }
    }
}
