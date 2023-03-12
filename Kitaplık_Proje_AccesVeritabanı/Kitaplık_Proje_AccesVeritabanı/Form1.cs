using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplık_Proje_AccesVeritabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }                                               // acces veritabanı bağlantısı..
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Kitaplik.accdb");
        void listele()
        {
            DataTable dt = new DataTable(); /// buradaki metot ile datagrid e acces içerisindeki bilgileri çekiyoruz..
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kitaplar", baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele(); // forum yüklendiğinde sürekli listele yapacak..
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }
        string durum = "";
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into kitaplar (KitapAd,Yazar,Tur,Sayfa,Durum) values (@p1,@p2,@p3,@p4,@p5)", baglan);
            komut1.Parameters.AddWithValue("@p1", txtkitapad.Text);
            komut1.Parameters.AddWithValue("@p2", txtyazar.Text);
            komut1.Parameters.AddWithValue("@p3", combotur.Text);
            komut1.Parameters.AddWithValue("@p4", txtsayfa.Text);
            komut1.Parameters.AddWithValue("@p5", durum);
            komut1.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kitap Eklendi");
            listele();
        }

        private void radiosıfır_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1"; // RADİ BOTUNLARI STRİNG DEĞİŞKEN İLE YÖNLENDİRME..
        }

        private void radioikinciel_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtkitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtkitapad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combotur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                radiosıfır.Checked = true;
            }
            else
            {
                radioikinciel.Checked = true;
            }



        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Delete From Kitaplar Where Kitapid=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", txtkitapid.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kitap Silindi");
            listele();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Update Kitaplar Set Kitapad=@p1,Yazar=@p2,Tur=@p3,Sayfa=@p4,Durum=@p5 Where Kitapid=@p6", baglan);
            komut.Parameters.AddWithValue("@p1",txtkitapad.Text);
            komut.Parameters.AddWithValue("@p2", txtyazar.Text);
            komut.Parameters.AddWithValue("@p3",combotur.Text);
            komut.Parameters.AddWithValue("@p4", txtsayfa.Text);
            if (radiosıfır.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            if (radioikinciel.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            komut.Parameters.AddWithValue("@p6",txtkitapid.Text);
            komut.ExecuteNonQuery() ;
            baglan.Close() ;
            MessageBox.Show("Kayıt Güncellendi");
            listele();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar Where KitapAd=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", txtara.Text);
            DataTable dt = new DataTable(); /// buradaki metot ile datagrid e acces içerisindeki bilgileri çekiyoruz..
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void btndetaylı_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar Where KitapAd like '%" + txtara.Text + "%'",baglan);
            komut.Parameters.AddWithValue("@p1", txtara.Text);
            DataTable dt = new DataTable(); /// buradaki metot ile datagrid e acces içerisindeki bilgileri çekiyoruz..
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt; // detaylı arama..
        }
    }
}
