using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum sehir {x,adana,mersin,ankara,bursa } // enum dizini atanır..
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt16(textBox1.Text); // klavyeden değer girer
            sehir s; // sehirler için yeni isim eklenir
            s = (sehir)plaka; // sehirin plaka olan değeri girilir..
            label1.Text= s.ToString();// girilen  enum değerini gösterir


          
            
        }
    }
}
