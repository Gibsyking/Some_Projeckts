using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Metin_Belgesi_Veri_Kaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin|*.txt"; // filtre verilir oluiturulacak dosya tipi yazılır.
            saveFileDialog1.Title = "richTextBox içindeki verileri kaydet"; // Kaydetme yerindeki başlık yazılır.
            saveFileDialog1.ShowDialog(); // Dialog değeri açılır.
            StreamWriter sw= new StreamWriter(saveFileDialog1.FileName); // Streamwritter ile  saveialog ismi  rich text box okumak için yönlendirilir.
            sw.WriteLine(richTextBox1.Text); // okuma ve yazma yeri değeri.
            sw.Close(); // bağlantı çıkışı
            MessageBox.Show("Veri kaydedildi");

        }
    }
}
