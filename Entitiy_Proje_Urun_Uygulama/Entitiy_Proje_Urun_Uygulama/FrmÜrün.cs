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
    public partial class FrmÜrün : Form
    {
        public FrmÜrün()
        {
            InitializeComponent();
        }
        DbentitiyUrunEntities db = new DbentitiyUrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            //var ürün = db.TBL_URUN.ToList(); // LİSTELEME MANTIĞI 
            //dataGridView1.DataSource = ürün;

            dataGridView1.DataSource = (from x in db.TBL_URUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.TBL_KATEGORI.AD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FİYAT
                                        }).ToList();   // İSTENİLEN SIRA VE TABLO İSMİNE GÖRE SIRALAMA.
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBL_URUN t = new TBL_URUN(); // EKLEME MANTIĞI
            t.URUNAD = textürünad.Text;
            t.STOK = byte.Parse(textstok.Text);
            t.DURUMU = true;
            t.FİYAT = decimal.Parse(textfiyat.Text);
            t.MARKA = textmarka.Text;
            t.KATEGORI = int.Parse(combokategori.Text.ToString());
            db.TBL_URUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Eklendi");

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int sil = Convert.ToInt32(textid.Text); // SİLME MANTIĞI
            var ürün = db.TBL_URUN.Find(sil);
            db.TBL_URUN.Remove(ürün);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi !", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int güncelle = Convert.ToInt32(textid.Text); // GÜNCELLENE MANTIĞI MANTIĞI
            var t = db.TBL_URUN.Find(güncelle);
            t.URUNAD = textürünad.Text;
            t.STOK = byte.Parse(textstok.Text);
            t.DURUMU = true;
            t.FİYAT = decimal.Parse(textfiyat.Text);
            t.MARKA = textmarka.Text;
            t.KATEGORI = int.Parse(combokategori.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi.");


        }

        private void FrmÜrün_Load(object sender, EventArgs e)
        {
            var kategori = (from x in db.TBL_KATEGORI select new { x.AD, x.ID }).ToList(); // COMBOBOX DEGER ATAMA.
            combokategori.ValueMember = "ID"; // ARKA PLANDA ÇALIŞAM ID
            combokategori.DisplayMember = "AD"; // ON PLANDA ÇALIŞAN SİM
            combokategori.DataSource = kategori; // değerlerin kategori tablosundan alınıp comboboxa aktarılması.

        }
    }
}

