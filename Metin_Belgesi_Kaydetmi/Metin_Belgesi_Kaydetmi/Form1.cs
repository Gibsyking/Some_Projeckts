using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// sistem kütüphanesi eklenir.

namespace Metin_Belgesi_Kaydetmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //  açılacak txt dosyası için şart oluştulur.
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);// okuma komutu değeri atanır.
                  string satir = sr.ReadLine();// satirlar için string değer atanır ve okunur.
                while(satir != null)// zamanlıyıcı ile satır içi null değer verene kadar okutunur.
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine();
                }
            }

        }
    }
}
