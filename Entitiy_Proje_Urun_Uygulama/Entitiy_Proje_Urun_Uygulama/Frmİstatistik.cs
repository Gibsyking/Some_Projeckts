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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        private void KAPAT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DbentitiyUrunEntities db = new DbentitiyUrunEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBL_KATEGORI.Count().ToString(); // KATEGORİ TOPLAM SAYISINI ÇEKME
            label3.Text = db.TBL_URUN.Count().ToString(); // TOPLAM URUN SAYISI
            label5.Text = db.TBL_MUSTERI.Count(x => x.DURUM == true).ToString(); // AKTİF MÜŞTERİ SAYISI
            label7.Text = db.TBL_MUSTERI.Count(y => y.DURUM == false).ToString();// PASİF MÜŞTERİ SAYISI
            label13.Text = db.TBL_URUN.Sum(x => x.STOK).ToString();// TOPLAM STOK SAYISI / SUM TOPLA KOMUTU İLE.
            label21.Text = db.TBL_SATIS.Sum(x => x.FIYAT).ToString() + " ₺ "; // TOPLAM SATUŞ RAKAMI TL OLARAK.
            label11.Text = (from x in db.TBL_URUN orderby x.FİYAT descending select x.URUNAD).FirstOrDefault(); // EN YÜKSEK FİYATLI ÜRÜN ADINI BULMA
            label9.Text = (from x in db.TBL_URUN orderby x.FİYAT ascending select x.URUNAD).FirstOrDefault(); // EN DÜŞÜK FİYATLI ÜRÜNÜN ADINI BULMA 
            label15.Text = db.TBL_URUN.Count(x => x.KATEGORI == 1).ToString(); // BEYAZ EŞYA KATEGORİSİNDE KAÇ ÜRÜN VAR
            label17.Text = db.TBL_URUN.Count(x => x.URUNAD == "BULAŞIK MAKİNASI").ToString(); // İSMİ BULAŞIK MAKİNASI OLAN ÜRÜNLERİN TOPLAMINI GETİRME
            label23.Text =(from x in db.TBL_MUSTERI select x.SEHIR ).Distinct().Count().ToString();// DİSTİCNT İLE TEKRARSIZ OLARAK ŞEHİR SAYISINI GETİRME.TOPLAMINI
            label19.Text = db.MARKAGETİR().FirstOrDefault().ToString(); // SQLPROSEDÜR İLE MARKA LAR İÇİNDE EN ÇOK ÜRÜNÜ BULUNAN MARKA GETİRME.

        }
    }
}
