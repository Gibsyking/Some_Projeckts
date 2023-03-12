using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samka_Ticari_Otomasyon
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        FrmUrunler frurun;
        private void btnürünler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frurun == null) // null değer atanmazsa birden çok yeni sekme açar.
            {
                frurun = new FrmUrunler();
                frurun.MdiParent = this; // mdi parant form içinde ayrı bir sekme olmadan ürünleri açar.
                frurun.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
        FrmMusteriler frmusteri;
        private void btnmüsteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmusteri==null)
            {
                frmusteri= new FrmMusteriler();
                frmusteri.MdiParent = this;
                frmusteri.Show();
                
            }
        }
    }
}
