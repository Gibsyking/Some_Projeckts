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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
           DataTable dt= new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter("Select * From Tbl_Duyurular", bgl.baglanti());
            sd.Fill(dt);
            dataGridView1.DataSource= dt;   

        }
    }
}
