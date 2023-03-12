namespace Kitaplık_Proje_AccesVeritabanı
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combotur = new System.Windows.Forms.ComboBox();
            this.txtkitapid = new System.Windows.Forms.TextBox();
            this.txtkitapad = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.radiosıfır = new System.Windows.Forms.RadioButton();
            this.radioikinciel = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.txtara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btndetaylı = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tür :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sayfa :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Durum :";
            // 
            // combotur
            // 
            this.combotur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotur.FormattingEnabled = true;
            this.combotur.Items.AddRange(new object[] {
            "Roman",
            "Hikayet",
            "Şiir",
            "Tiyatro"});
            this.combotur.Location = new System.Drawing.Point(110, 152);
            this.combotur.Name = "combotur";
            this.combotur.Size = new System.Drawing.Size(147, 31);
            this.combotur.TabIndex = 6;
            // 
            // txtkitapid
            // 
            this.txtkitapid.Enabled = false;
            this.txtkitapid.Location = new System.Drawing.Point(110, 4);
            this.txtkitapid.Name = "txtkitapid";
            this.txtkitapid.Size = new System.Drawing.Size(147, 31);
            this.txtkitapid.TabIndex = 7;
            // 
            // txtkitapad
            // 
            this.txtkitapad.Location = new System.Drawing.Point(110, 41);
            this.txtkitapad.Name = "txtkitapad";
            this.txtkitapad.Size = new System.Drawing.Size(147, 31);
            this.txtkitapad.TabIndex = 8;
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(110, 78);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(147, 31);
            this.txtyazar.TabIndex = 9;
            // 
            // txtsayfa
            // 
            this.txtsayfa.Location = new System.Drawing.Point(110, 115);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(147, 31);
            this.txtsayfa.TabIndex = 10;
            // 
            // radiosıfır
            // 
            this.radiosıfır.AutoSize = true;
            this.radiosıfır.Location = new System.Drawing.Point(110, 189);
            this.radiosıfır.Name = "radiosıfır";
            this.radiosıfır.Size = new System.Drawing.Size(58, 27);
            this.radiosıfır.TabIndex = 11;
            this.radiosıfır.TabStop = true;
            this.radiosıfır.Text = "Sıfır";
            this.radiosıfır.UseVisualStyleBackColor = true;
            this.radiosıfır.CheckedChanged += new System.EventHandler(this.radiosıfır_CheckedChanged);
            // 
            // radioikinciel
            // 
            this.radioikinciel.AutoSize = true;
            this.radioikinciel.Location = new System.Drawing.Point(171, 189);
            this.radioikinciel.Name = "radioikinciel";
            this.radioikinciel.Size = new System.Drawing.Size(86, 27);
            this.radioikinciel.TabIndex = 12;
            this.radioikinciel.TabStop = true;
            this.radioikinciel.Text = "İkinci El";
            this.radioikinciel.UseVisualStyleBackColor = true;
            this.radioikinciel.CheckedChanged += new System.EventHandler(this.radioikinciel_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 182);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(320, 22);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(125, 31);
            this.btnlistele.TabIndex = 14;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(320, 132);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(125, 31);
            this.btngüncelle.TabIndex = 15;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(320, 95);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(125, 31);
            this.btnsil.TabIndex = 16;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(320, 58);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(125, 31);
            this.btnkaydet.TabIndex = 17;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(529, 214);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(111, 31);
            this.btnara.TabIndex = 18;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(594, 177);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(155, 31);
            this.txtara.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kitap Ad :";
            // 
            // btndetaylı
            // 
            this.btndetaylı.Location = new System.Drawing.Point(656, 214);
            this.btndetaylı.Name = "btndetaylı";
            this.btndetaylı.Size = new System.Drawing.Size(111, 31);
            this.btndetaylı.TabIndex = 21;
            this.btndetaylı.Text = "DETAYLI";
            this.btndetaylı.UseVisualStyleBackColor = true;
            this.btndetaylı.Click += new System.EventHandler(this.btndetaylı_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 455);
            this.Controls.Add(this.btndetaylı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioikinciel);
            this.Controls.Add(this.radiosıfır);
            this.Controls.Add(this.txtsayfa);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.txtkitapad);
            this.Controls.Add(this.txtkitapid);
            this.Controls.Add(this.combotur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Kitaplık proje Acces";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combotur;
        private System.Windows.Forms.TextBox txtkitapid;
        private System.Windows.Forms.TextBox txtkitapad;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.RadioButton radiosıfır;
        private System.Windows.Forms.RadioButton radioikinciel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btndetaylı;
    }
}

