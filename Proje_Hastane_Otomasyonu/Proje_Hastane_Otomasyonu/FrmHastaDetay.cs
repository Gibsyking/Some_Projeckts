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
using System.Data.Common;

namespace Proje_Hastane_Otomasyonu
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbdoktor.Items.Clear(); // veri içi sürekli tekrar etmesin diye temizleme.
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();

        }
        public string tc;
        // Ad soyad çekme formu.
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar Where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // Randevu Geçmiş bu ALANDA DATAGRİD WİED GÖRÜNTÜLENMEKTE.
            DataTable dt = new DataTable(); // Veri tablosu değişkeni datagriview için
            SqlDataAdapter sd = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc=" + tc, bgl.baglanti());
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

            // Branşları çekme 
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();


        }
        // Aktif randevuları görmek için data grid ayarları
        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); // data grip tablosu için                                  ////// bir şarta bir yerdeki sadece combo box içindeki değeri şeçmek için kullanılır..+ 
            SqlDataAdapter sd = new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuBrans='" + cmbbrans.Text + "'" + " and RandevuDoktor='" + cmbdoktor.Text + "'and RandevuDurum=0", bgl.baglanti());
            sd.Fill(dt);                            /// datagrid içinde görünecek veriler , okuma için Tek ' çizgi kullanılır
            dataGridView2.DataSource = dt; //datagrid Veri bağlantısı sorgulama

        }

        private void linllabelbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.tcno = lbltc.Text; // diğer forma tc numarası aktarmak için kullanılır.
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Aktif randevuyu butonlara taşıma..
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();



        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 Where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2", richTextBox1.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı..");

        }
    }
}
