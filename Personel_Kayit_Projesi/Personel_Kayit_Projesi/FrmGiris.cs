using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Personel_Kayit_Projesi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KO6B9FU\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();                             //// kullanıcı adı ve sifre değeri sql den gelen
            SqlCommand komut = new SqlCommand("Select * From Tbl_Giris where Kullaniciadi=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);  // kullanıcı adi değeri
            komut.Parameters.AddWithValue("@p2", textBox2.Text);   // sire değeri

            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                FrmAnaForm frm= new FrmAnaForm(); // komut dogru okursa
                frm.Show();
                this.Hide();
                MessageBox.Show("Giriş Başarılı", "Başarılı", MessageBoxButtons.OK); ;
            }
            else /// komut dogru okumazsa
            {
                MessageBox.Show("Giriş Başarısız !!", "Şifre Veya Kullanıcı Adı", MessageBoxButtons.OK);

            }

            baglanti.Close();
        }
    }
}
