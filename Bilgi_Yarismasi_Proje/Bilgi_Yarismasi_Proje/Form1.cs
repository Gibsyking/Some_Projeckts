using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi_Proje
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
        int dogru=0 , yanlıs=0 , soruno=0 ;

        private void btnb_Click(object sender, EventArgs e)
        {
            btnb.Enabled = false;
            btnc.Enabled = false;
            btna.Enabled = false;
            btnd.Enabled = false;
            btnsiradaki.Enabled = true;
            
            


            lblfalse.Text=btnb.Text;

            if (lbltrue.Text == btnb.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
               
            }

            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;

            }


            }

        private void btnc_Click(object sender, EventArgs e)
        {
            btnb.Enabled = false;
            btnc.Enabled = false;
            btna.Enabled = false;
            btnd.Enabled = false;
            btnsiradaki.Enabled=true;
            pictureBox1.Enabled = false;
          pictureBox2.Enabled= false;
            lblfalse.Text= btnc.Text;

            if (lbltrue.Text == lblfalse.Text)

            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }

            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();

                pictureBox2.Visible = true;

            }
            }
        

        private void btna_Click(object sender, EventArgs e)
        {
            //lblfalse.Text=btna.Text;
            
            //if(lbldogru.Text==lblfalse.Text)

        }

        private void btnsiradaki_Click(object sender, EventArgs e)
        {
            btnb.Enabled = true;
            btnc.Enabled = true;
            btna.Enabled = true;
            btnd.Enabled = true;
            btnsiradaki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            lblsorusayisi.Text = soruno.ToString();
            if (soruno==1)
                {
                richTextBox1.Text = "Doğru Soru B";
                btna.Text = "a";   
                btnb.Text= "b";
                btnc.Text = "c";    
                btnd.Text = "d";    
                lbltrue.Text = "b";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Doğru Soru C";
                btna.Text = "a";
                btnb.Text = "b";
                btnc.Text = "c";
                btnd.Text = "d";
                lbltrue.Text = "c";
            }
            
            if(soruno==3) 
            {
                btnb.Visible = false;
                btnc.Visible = false;
                btna.Visible = false;
                btnd.Visible = false;
                pictureBox2.Visible= false;
                pictureBox2.Visible = false;
                MessageBox.Show("Doğru Soru : " + dogru + "\n" + "Yanlış Soru : " + yanlıs);
                
            }
    }
}
}



