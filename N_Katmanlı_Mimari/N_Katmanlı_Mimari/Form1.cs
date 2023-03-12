using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using DataAccesLayer;
using EntitiyLayer;

namespace N_Katmanlı_Mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<entitiypersonel> Perlist = LogicPersonel.LLpersonellistesi(); // personel listeleme son katman
            dataGridView1.DataSource= Perlist;
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            entitiypersonel ent = new entitiypersonel(); // personel ekleme son katman
            ent.Ad = textad.Text;
            ent.Soy = textsoy.Text;
            ent.Sehir=textsehır.Text;
            ent.Gorev=textgorev.Text;
            ent.Maas = short.Parse(textmaas.Text);
            LogicPersonel.LLpersonelekle(ent);
        }

        private void button2_Click(object sender, EventArgs e) // personel silme son katman
        {
            entitiypersonel ent=new entitiypersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            LogicPersonel.LLpersonelsil(ent.Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                entitiypersonel ent = new entitiypersonel();
                ent.Id = Convert.ToInt16(textBox1.Text);
                ent.Ad= textad.Text;
                ent.Soy = textsoy.Text;
                ent.Sehir = textsehır.Text;
                ent.Gorev = textgorev.Text;
                ent.Maas = short.Parse(textmaas.Text);
                LogicPersonel.LLpersonelGuncelle(ent);
            }
        }
    }
}
