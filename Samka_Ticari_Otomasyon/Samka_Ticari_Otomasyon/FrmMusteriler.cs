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

namespace Samka_Ticari_Otomasyon
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnectClass sql=new SqlConnectClass();
        void listele()
        {
            // MUSTERİLERİN GRİDVİEWDE GÖRÜNMESİ.
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter("Select * From TBL_MUSTERI", sql.baglantı());
            sd.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void il()
        {
            SqlCommand komut= new SqlCommand("Select SEHIR FROM TBL_IL",sql.baglantı()); // COMBOBOX İÇERİSİNE İLLERİ ALMA.
            SqlDataReader sd=komut.ExecuteReader();
            while(sd.Read())
            {
                comboil.Properties.Items.Add(sd[0]);
            }
            sql.baglantı().Close();
        }
       
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            il();
            

        }

        private void comboil_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboilce.Properties.Items.Clear();  // İLLER İLCELER İÇERİSİNDEKİ  SECİLEN İLİ İLCESİ DEĞİŞTİRMEK İÇİN KULLANILAN COMBOX METODU
            
            SqlCommand komut = new SqlCommand("Select ILCE FROM TBL_ILCE WHERE SEHIR=@P1", sql.baglantı());
            komut.Parameters.AddWithValue("@p1",comboil.SelectedIndex +1);
            SqlDataReader sd= komut.ExecuteReader();
            while (sd.Read())
            {
                comboilce.Properties.Items.Add(sd[0]);
            }
            
            sql.baglantı().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            // MUSTERİLERİN EKLENMESİ
            SqlCommand komutekle = new SqlCommand("insert into TBL_MUSTERI (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", sql.baglantı());
            komutekle.Parameters.AddWithValue("@p1", txtad.Text);
            komutekle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komutekle.Parameters.AddWithValue("@p3", msktelefon1.Text);
            komutekle.Parameters.AddWithValue("@p4", msktelefon2.Text);
            komutekle.Parameters.AddWithValue("@p5", msktc.Text);
            komutekle.Parameters.AddWithValue("@p6", txtmail.Text);
            komutekle.Parameters.AddWithValue("@p7", comboil.Text);
            komutekle.Parameters.AddWithValue("@p8", comboilce.Text);
            komutekle.Parameters.AddWithValue("@p9", richadres.Text);
            komutekle.Parameters.AddWithValue("@p10",txtvergi.Text);
            komutekle.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("Müşteri Kaydı Eklendi", "Kayıt işlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
         
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil=new SqlCommand("Delete From TBL_MUSTERI where ID=@P1",sql.baglantı()); // MÜSTERİ KAYDI SİLME.
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("Müşteri Kaydı Silindi !","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listele();
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            msktelefon1.Text = "";
            msktelefon2.Text = "";
            msktc.Text = "";
            txtmail.Text = "";
            comboil.Text = "";
            comboilce.Text = "";
            richadres.Text = "";
            txtvergi.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)

        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); // MÜŞTERİLERİN TEXTBOXLARA TAŞINMASI..

            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtsoyad.Text = dr["SOYAD"].ToString();
                msktelefon1.Text = dr["TELEFON"].ToString();
                msktelefon2.Text = dr["TELEFON2"].ToString();
                msktc.Text = dr["TC"].ToString();
                txtmail.Text = dr["MAIL"].ToString();
                comboil.Text = dr["IL"].ToString();
                comboilce.Text = dr["ILCE"].ToString();
                richadres.Text = dr["ADRES"].ToString();
                txtvergi.Text = dr["VERGIDAIRE"].ToString();
            }
            
            }

        private void ÜRÜNLER_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand(" Update  TBL_MUSTERI set AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,ADRES=@p9,VERGIDAIRE=@P10 where ID=@p11 ", sql.baglantı());
            komutguncelle.Parameters.AddWithValue("@p1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@p3", msktelefon1.Text);
            komutguncelle.Parameters.AddWithValue("@p4", msktelefon2.Text);
            komutguncelle.Parameters.AddWithValue("@p5", msktc.Text);
            komutguncelle.Parameters.AddWithValue("@p6", txtmail.Text);
            komutguncelle.Parameters.AddWithValue("@p7", comboil.Text);
            komutguncelle.Parameters.AddWithValue("@p8", comboilce.Text);
            komutguncelle.Parameters.AddWithValue("@p9", richadres.Text);
            komutguncelle.Parameters.AddWithValue("@p10", txtvergi.Text);
            komutguncelle.Parameters.AddWithValue("@p11",txtid.Text);
            komutguncelle.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("Müşteri Kaydı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            msktelefon1.Text = "";
            msktelefon2.Text = "";
            msktc.Text = "";
            txtmail.Text = "";
            comboil.Text = "";
            comboilce.Text = "";
            richadres.Text = "";
            txtvergi.Text = "";

        }
    }
    }



