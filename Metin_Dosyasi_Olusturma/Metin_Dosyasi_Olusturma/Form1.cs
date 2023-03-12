﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Metin_Dosyasi_Olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaadi, dosyayolu;
        StreamWriter sw;

        private void button2_Click(object sender, EventArgs e)
        {
            dosyaadi = textBox2.Text;
            sw = File.CreateText(dosyayolu+ "\\"+dosyaadi+".xls"); /// bu satıra pdf xls txt girilir
            sw.Close(); // işlem bittikten sonra çıkış yapılır dosya sürekli okumada kalır yoksa.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyayolu= folderBrowserDialog1.SelectedPath.ToString(); // dosya yolu değere atanan özellik.
                textBox1.Text= dosyayolu; // dosya yolunu göstermek için kullanılır.

            }
        }
    }
}
