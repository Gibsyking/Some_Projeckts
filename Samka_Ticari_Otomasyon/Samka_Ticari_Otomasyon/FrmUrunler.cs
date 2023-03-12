using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samka_Ticari_Otomasyon
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnectClass sql = new SqlConnectClass(); // sql sınıfına bağlantı için kullanılan kısayol.
        void listele() /// Burada metot ile urun tablosu grid içerisine çağrılır. ve listele komutuna atanılır.
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter("Select * From TBL_URUN", sql.baglantı());
            sd.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele(); // forum yüklendiğinde listele metodunu çağırma..
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // ÜRÜN KAYIT ETME..
            SqlCommand komutekle = new SqlCommand("insert into TBL_URUN (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", sql.baglantı());
            komutekle.Parameters.AddWithValue("@p1", txturun.Text);
            komutekle.Parameters.AddWithValue("@p2", txtmarka.Text);
            komutekle.Parameters.AddWithValue("@p3", txtmodel.Text);
            komutekle.Parameters.AddWithValue("@p4", mskyıl.Text);
            komutekle.Parameters.AddWithValue("@p5", mskadet.Text);
            komutekle.Parameters.AddWithValue("@p6", decimal.Parse((txtalısfıyatı.Text).ToString()));
            komutekle.Parameters.AddWithValue("@p7", decimal.Parse((txtsatısfıyatı.Text).ToString()));
            komutekle.Parameters.AddWithValue("@p8", richdetay.Text);

            komutekle.ExecuteNonQuery(); // SQL KOMUTLARININ YERİNE GETİRİLMESİ
            sql.baglantı().Close(); // KOD BİTİNCE BAĞLANTI KAPATILIR.

            MessageBox.Show("Ürün Kaydı Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // İŞLEM SONU VERİLEN MESAJ.
            listele();
            txturun.Text = " ";
            txtmarka.Text = " ";
            txtmodel.Text = " ";
            mskyıl.Text = " ";
            mskadet.Text = "";
            txtsatısfıyatı.Text = " ";
            txtalısfıyatı.Text = " ";
            richdetay.Text = " ";
            txturun.Focus();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            // ÜRÜNÜ İD DEĞERİ GİREREK SİLME İŞLEMİ..
            SqlCommand komutsil = new SqlCommand("delete from TBL_URUN where ID=@p1", sql.baglantı());
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("Ürün Kaydı Silindi !", "Silme işlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            txtid.Text = " ";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // GRİDCONTROL İÇERİSİNDEKİ VERİLERİ TEXTBOXLARA ÇEKME.
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = dr["ID"].ToString();
            txturun.Text = dr["URUNAD"].ToString();
            txtmarka.Text = dr["MARKA"].ToString();
            txtmodel.Text = dr["MODEL"].ToString();
            mskyıl.Text = dr["YIL"].ToString();
            mskadet.Text = dr["ADET"].ToString();
            txtalısfıyatı.Text = dr["ALISFIYAT"].ToString();
            txtsatısfıyatı.Text = dr["SATISFIYAT"].ToString();
            richdetay.Text = dr["DETAY"].ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            // ÜRÜN KAYDINI DATAGRİDDEN ŞEÇEREK GÜNCELLEME..
            SqlCommand komutguncelle = new SqlCommand(" Update  TBL_URUN set URUNAD=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATISFIYAT=@P7,DETAY=@P8 Where ID=@P9", sql.baglantı());
            komutguncelle.Parameters.AddWithValue("@p1", txturun.Text);
            komutguncelle.Parameters.AddWithValue("@p2", txtmarka.Text);
            komutguncelle.Parameters.AddWithValue("@p3", txtmodel.Text);
            komutguncelle.Parameters.AddWithValue("@p4", mskyıl.Text);
            komutguncelle.Parameters.AddWithValue("@p5", mskadet.Text);
            komutguncelle.Parameters.AddWithValue("@p6", decimal.Parse((txtalısfıyatı.Text).ToString()));
            komutguncelle.Parameters.AddWithValue("@p7", decimal.Parse((txtsatısfıyatı.Text).ToString()));
            komutguncelle.Parameters.AddWithValue("@p8", richdetay.Text);
            komutguncelle.Parameters.AddWithValue("@p9", txtid.Text);

            komutguncelle.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("Ürün Kaydı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

        private void ÜRÜNLER_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
