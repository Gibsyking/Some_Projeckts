using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entitiy_Proje_Urun_Uygulama
{
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbentitiyUrunEntities db=new DbentitiyUrunEntities(); /// GİRİŞ EKRANLARINDA İNT KULLANMA HATA VERİYOR.
            var login = from x in db.TBL_ADMIN where x.K_ADI == textBox1.Text && x.K_SIFRE == textBox2.Text select x;

            if (login.Any())
            {
                FrmAnaSayfa fr = new FrmAnaSayfa();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı","GİRİŞ HATASI",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
        }
    }
}
