using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Araçlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++) // döngü yaratma için kullanılır artırarak istenilen sayıya gelir
            {
                TextBox txt = new TextBox();// txtbox için değer atanır kısayol için
                Point konum = new Point(100, i * 40); // potin için değer atanır ve lokasyon eklenir.
                txt.Location = konum;//  txt gelecek değerlere konumlandırma yapılır.
                txt.Name = i.ToString();//isimi for döngüsü kadar artırılır.
                this.Controls.Add(txt);//ekleme kontrol işlemi yapılır..
                txt.BackColor = Color.Red;//arka plan rengi belirlenir.

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int a = 1; a < 10; a++)
            {
                Label lbl = new Label();
                Point konum = new Point(300, a * 40);
                lbl.Location = konum;
                lbl.Name = a.ToString();
                this.Controls.Add(lbl);
                lbl.BackColor = Color.Blue;
            }
        }
    }
}
