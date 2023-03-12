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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet1.Tbl_Personel' table. You can move, or remove it, as needed.
            //this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KO6B9FU\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        /// sql bağlantısı için kullanılır baglantı komuru ile hareket eder  
        void temizle()
        {
            txtad.Text = "";
            txtid.Text = "";
            txtmaas.Text = "";
            txtmeslek.Text = "";
            txtsehir.Text = "";
            txtsoy.Text = "";
            radiobekar.Checked = false;
            radioevli.Checked = false;
            txtad.Focus();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);//data grid ten sürekli verileri çeker..
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open(); // her soguda bağlantı işlemi açılır ve kapanır..
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,Persoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            ///sql comand ile istenilent veriyi gönderir.. insert into veri eklemeye yarar..
            komut.Parameters.AddWithValue("@p1", txtad.Text);       ///// p1 örnek perad değerini alır..
            komut.Parameters.AddWithValue("@p2", txtsoy.Text);
            komut.Parameters.AddWithValue("@p3", txtsehir.Text);
            komut.Parameters.AddWithValue("@p4", txtmaas.Text);
            komut.Parameters.AddWithValue("@p5", txtmeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery(); /// sql komutunu çalıştırır

            baglanti.Close(); // bağlantı işlem sonu kapatılır..
            MessageBox.Show("Kayıt Eklendi", "Başarılı");




        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioevli_CheckedChanged(object sender, EventArgs e)
        {
            if (radioevli.Checked == true)  /// if komutu ile True ve false yazdılır program data gridwievden şeçildiğinde hata vermesin diye.
            {
                label8.Text = "True";  /// radi botun değişimi için label düzeltme
            }
            //label8.Text = "True"; /// sql true veya false değerini bir label yardımı ile gönderilebilir..
        }

        private void radiobekar_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobekar.Checked == true)  /// radi botun değişimi için label düzeltme
            {
                label8.Text = "False";
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {// şeçim yapmak için datagripwievden gerekli kodlar
            int secilen = dataGridView1.SelectedCells[0].RowIndex; /// data grid view üzerinde şeçim yapmak için tıklama
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); // hangi satır için tıklama yapılacağı.
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoy.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();


        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")  /// radi botun değişimi için label düzeltme
            {
                radioevli.Checked = true;
            }
            if(label8.Text== "False")
            {
                radiobekar.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e) // kayıt silme..
        {
            baglanti.Open();// Her işlemde bağlantı açılır ve kapanır..
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", baglanti); // Silme için Yer bildirim komutu..
            komutsil.Parameters.AddWithValue("@k1",txtid.Text); // id numarası ile satır silinir..
            komutsil.ExecuteNonQuery(); // her sql sorgusunda çalıştırılır.
            baglanti.Close();
            MessageBox.Show("Kayıt Sildi", "Dikkat !", MessageBoxButtons.OK);
        }

        private void btnguncelle_Click(object sender, EventArgs e) /// kayıt güncelleme..
        {
            baglanti.Open();                            // uptada komutu  tablo çağırılır set komutu ile tablo içi alanlara eklenir en son where ile id numarası belirlenir yoksa veriler sürekli yeni veri olarak atar...!!
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,Persoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1",txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2",txtsoy.Text);
            komutguncelle.Parameters.AddWithValue("@a3",txtsehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", txtmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text); // radio buttona atanmış labelden gelen değer.
            komutguncelle.Parameters.AddWithValue("@a6",txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtid.Text); // id numarası where komutu ile eklenir...
            komutguncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi !", "Bilgi", MessageBoxButtons.OK);
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik frm1= new Frmİstatistik(); // ikinci form için değer ataması
            frm1.Show(); // form gösterme..

        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm2= new FrmGrafikler();
            frm2.Show(); // baska form gösterme.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRapor frm11= new FrmRapor();
            frm11.Show();
           
        }
    }
}

