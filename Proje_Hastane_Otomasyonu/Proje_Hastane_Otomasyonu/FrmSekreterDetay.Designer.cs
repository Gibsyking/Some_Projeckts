﻿namespace Proje_Hastane_Otomasyonu
{
    partial class FrmSekreterDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoy = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnduyuru = new System.Windows.Forms.Button();
            this.rchduyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.chechboxdurum = new System.Windows.Forms.CheckBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnrandevuliste = new System.Windows.Forms.Button();
            this.btnbranşpaneli = new System.Windows.Forms.Button();
            this.btndoktorpaneli = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.lbladsoy);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi :";
            // 
            // lbladsoy
            // 
            this.lbladsoy.AutoSize = true;
            this.lbladsoy.Location = new System.Drawing.Point(73, 59);
            this.lbladsoy.Name = "lbladsoy";
            this.lbladsoy.Size = new System.Drawing.Size(46, 13);
            this.lbladsoy.TabIndex = 3;
            this.lbladsoy.Text = "Null Null";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(73, 25);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(61, 13);
            this.lbltc.TabIndex = 2;
            this.lbltc.Text = "000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnduyuru);
            this.groupBox2.Controls.Add(this.rchduyuru);
            this.groupBox2.Location = new System.Drawing.Point(13, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru oluştur";
            // 
            // btnduyuru
            // 
            this.btnduyuru.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnduyuru.Location = new System.Drawing.Point(59, 173);
            this.btnduyuru.Name = "btnduyuru";
            this.btnduyuru.Size = new System.Drawing.Size(75, 23);
            this.btnduyuru.TabIndex = 1;
            this.btnduyuru.Text = "Oluştur";
            this.btnduyuru.UseVisualStyleBackColor = true;
            this.btnduyuru.Click += new System.EventHandler(this.btnduyuru_Click);
            // 
            // rchduyuru
            // 
            this.rchduyuru.Location = new System.Drawing.Point(9, 29);
            this.rchduyuru.Name = "rchduyuru";
            this.rchduyuru.Size = new System.Drawing.Size(178, 138);
            this.rchduyuru.TabIndex = 0;
            this.rchduyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.btnguncelle);
            this.groupBox3.Controls.Add(this.btnkaydet);
            this.groupBox3.Controls.Add(this.chechboxdurum);
            this.groupBox3.Controls.Add(this.msktc);
            this.groupBox3.Controls.Add(this.cmbdoktor);
            this.groupBox3.Controls.Add(this.cmbbrans);
            this.groupBox3.Controls.Add(this.msksaat);
            this.groupBox3.Controls.Add(this.msktarih);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(230, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 329);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(55, 268);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnguncelle.Size = new System.Drawing.Size(75, 43);
            this.btnguncelle.TabIndex = 14;
            this.btnguncelle.Text = "Duyurular";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(55, 211);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 42);
            this.btnkaydet.TabIndex = 13;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // chechboxdurum
            // 
            this.chechboxdurum.AutoSize = true;
            this.chechboxdurum.Location = new System.Drawing.Point(55, 188);
            this.chechboxdurum.Name = "chechboxdurum";
            this.chechboxdurum.Size = new System.Drawing.Size(57, 17);
            this.chechboxdurum.TabIndex = 12;
            this.chechboxdurum.Text = "Durum";
            this.chechboxdurum.UseVisualStyleBackColor = true;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(55, 162);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(128, 20);
            this.msktc.TabIndex = 11;
            this.msktc.ValidatingType = typeof(int);
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(55, 132);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(128, 21);
            this.cmbdoktor.TabIndex = 10;
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(55, 102);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(128, 21);
            this.cmbbrans.TabIndex = 9;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(55, 74);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(39, 20);
            this.msksaat.TabIndex = 8;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(55, 47);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(57, 20);
            this.msktarih.TabIndex = 7;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(55, 20);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(57, 20);
            this.txtid.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "TC NO :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Doktor :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Branş :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Saat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tarih :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "İd No :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(436, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 205);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(439, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(371, 239);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(365, 220);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnrandevuliste);
            this.groupBox6.Controls.Add(this.btnbranşpaneli);
            this.groupBox6.Controls.Add(this.btndoktorpaneli);
            this.groupBox6.Location = new System.Drawing.Point(13, 352);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(417, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnrandevuliste
            // 
            this.btnrandevuliste.Location = new System.Drawing.Point(279, 40);
            this.btnrandevuliste.Name = "btnrandevuliste";
            this.btnrandevuliste.Size = new System.Drawing.Size(103, 23);
            this.btnrandevuliste.TabIndex = 17;
            this.btnrandevuliste.Text = "Randevu Liste";
            this.btnrandevuliste.UseVisualStyleBackColor = true;
            this.btnrandevuliste.Click += new System.EventHandler(this.btnrandevuliste_Click);
            // 
            // btnbranşpaneli
            // 
            this.btnbranşpaneli.Location = new System.Drawing.Point(156, 40);
            this.btnbranşpaneli.Name = "btnbranşpaneli";
            this.btnbranşpaneli.Size = new System.Drawing.Size(105, 23);
            this.btnbranşpaneli.TabIndex = 16;
            this.btnbranşpaneli.Text = "Branş Paneli";
            this.btnbranşpaneli.UseVisualStyleBackColor = true;
            this.btnbranşpaneli.Click += new System.EventHandler(this.btnbranşpaneli_Click);
            // 
            // btndoktorpaneli
            // 
            this.btndoktorpaneli.Location = new System.Drawing.Point(27, 40);
            this.btndoktorpaneli.Name = "btndoktorpaneli";
            this.btndoktorpaneli.Size = new System.Drawing.Size(110, 23);
            this.btndoktorpaneli.TabIndex = 15;
            this.btndoktorpaneli.Text = "Doktor Paneli";
            this.btndoktorpaneli.UseVisualStyleBackColor = true;
            this.btndoktorpaneli.Click += new System.EventHandler(this.btndoktorpaneli_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(812, 469);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoy;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnduyuru;
        private System.Windows.Forms.RichTextBox rchduyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.CheckBox chechboxdurum;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnrandevuliste;
        private System.Windows.Forms.Button btnbranşpaneli;
        private System.Windows.Forms.Button btndoktorpaneli;
    }
}