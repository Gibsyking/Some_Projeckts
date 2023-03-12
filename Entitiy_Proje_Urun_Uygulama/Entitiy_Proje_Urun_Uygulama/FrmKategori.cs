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
    public partial class GİRİŞ : Form
    {
        public GİRİŞ()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DbentitiyUrunEntities db=new DbentitiyUrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            var kategori=db.TBL_KATEGORI.ToList(); // LİSTELEME MANTIĞI
            dataGridView1.DataSource=kategori;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBL_KATEGORI t = new TBL_KATEGORI(); // EKLEME MANTIĞI
            t.AD = textad.Text;
            db.TBL_KATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void bnsil_Click(object sender, EventArgs e)
        {
            int sil = Convert.ToInt32(textid.Text); // SİLME MANTIĞI
            var kategor = db.TBL_KATEGORI.Find(sil);
            db.TBL_KATEGORI.Remove(kategor);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi !");
            textid.Text = "";
            textad.Text = "";
            textid.Focus();
    }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int güncelle = Convert.ToInt32(textid.Text); // GÜNCELLEME MANTIĞI MANTIĞI
            var kategor = db.TBL_KATEGORI.Find(güncelle);
            kategor.AD = textad.Text;
            db.SaveChanges();
            MessageBox.Show("Veriler Güncellendi");
            textad.Text = "";
            textid.Text = "";
            textad.Focus();

        }
    }
}
