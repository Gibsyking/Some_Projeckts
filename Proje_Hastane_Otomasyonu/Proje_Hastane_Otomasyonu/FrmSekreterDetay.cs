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

namespace Proje_Hastane_Otomasyonu
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        public string Tcnumarası;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = Tcnumarası; // diğer forumdan gelen değer için kullanılır.
            // AD soyad

            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreterler where SekreterTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoy.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            // Branşları dataGrid e çekme

            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

            //Doktorlar DataGrid çekme

            DataTable dt1 = new DataTable();
            SqlDataAdapter sd1 = new SqlDataAdapter("Select (DoktorAd+' ' + DoktorSoyad)as ' Doktorlar ',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            sd1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            bgl.baglanti().Close();
            //Bransı combox a aktarma
            SqlCommand komut5 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                cmbbrans.Items.Add(dr5[0].ToString());
            }
            bgl.baglanti() .Close();
           

        
        }
        
        

        //Randevu Kaydetme
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) Values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@r1", msktarih.Text);
            komut2.Parameters.AddWithValue("@r2", msksaat.Text);
            komut2.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komut2.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komut2.ExecuteNonQuery(); // komut kaydet  ekleme olduğu için
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Kayıt Edildi" + msksaat.Text + " " + msktarih);



        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            //Doktor isme aktarma
            SqlCommand komut6 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut6.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                cmbdoktor.Items.Add((dr6[0]+" "+dr6[1].ToString()));
            }
            bgl.baglanti().Close();
        }
        // duyuru oluşturma
        private void btnduyuru_Click(object sender, EventArgs e)
        {
            SqlCommand komut7=new SqlCommand("insert into  Tbl_Duyurular  (Duyuru) values (@d1)",bgl.baglanti());   
            komut7.Parameters.AddWithValue("@d1",rchduyuru.Text);
            komut7.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Kayıt Edildi");
        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr=new FrmDoktorPaneli();
            fr.Show();
            this.Hide();
        }

        private void btnbranşpaneli_Click(object sender, EventArgs e)
        {
            Frmbrans fr=new Frmbrans();
            fr.Show();
            this.Hide();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr=new FrmRandevuListesi();
            fr.Show();
            this.Hide();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
