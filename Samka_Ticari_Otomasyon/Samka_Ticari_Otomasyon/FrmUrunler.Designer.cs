namespace Samka_Ticari_Otomasyon
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ÜRÜNLER = new DevExpress.XtraEditors.GroupControl();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.mskadet = new System.Windows.Forms.MaskedTextBox();
            this.richdetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtsatısfıyatı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtalısfıyatı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.mskyıl = new System.Windows.Forms.MaskedTextBox();
            this.txtmodel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtmarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txturun = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ÜRÜNLER)).BeginInit();
            this.ÜRÜNLER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatısfıyatı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalısfıyatı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmodel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1009, 465);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // ÜRÜNLER
            // 
            this.ÜRÜNLER.Controls.Add(this.btnsil);
            this.ÜRÜNLER.Controls.Add(this.btnkaydet);
            this.ÜRÜNLER.Controls.Add(this.btnguncelle);
            this.ÜRÜNLER.Controls.Add(this.mskadet);
            this.ÜRÜNLER.Controls.Add(this.richdetay);
            this.ÜRÜNLER.Controls.Add(this.labelControl9);
            this.ÜRÜNLER.Controls.Add(this.txtsatısfıyatı);
            this.ÜRÜNLER.Controls.Add(this.labelControl8);
            this.ÜRÜNLER.Controls.Add(this.txtalısfıyatı);
            this.ÜRÜNLER.Controls.Add(this.labelControl7);
            this.ÜRÜNLER.Controls.Add(this.labelControl6);
            this.ÜRÜNLER.Controls.Add(this.labelControl5);
            this.ÜRÜNLER.Controls.Add(this.mskyıl);
            this.ÜRÜNLER.Controls.Add(this.txtmodel);
            this.ÜRÜNLER.Controls.Add(this.labelControl4);
            this.ÜRÜNLER.Controls.Add(this.txtmarka);
            this.ÜRÜNLER.Controls.Add(this.labelControl3);
            this.ÜRÜNLER.Controls.Add(this.txturun);
            this.ÜRÜNLER.Controls.Add(this.labelControl2);
            this.ÜRÜNLER.Controls.Add(this.txtid);
            this.ÜRÜNLER.Controls.Add(this.labelControl1);
            this.ÜRÜNLER.Location = new System.Drawing.Point(1015, 0);
            this.ÜRÜNLER.Name = "ÜRÜNLER";
            this.ÜRÜNLER.Size = new System.Drawing.Size(343, 465);
            this.ÜRÜNLER.TabIndex = 1;
            this.ÜRÜNLER.Text = "ÜRÜNLER";
            this.ÜRÜNLER.Paint += new System.Windows.Forms.PaintEventHandler(this.ÜRÜNLER_Paint);
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsil.ImageOptions.SvgImage")));
            this.btnsil.Location = new System.Drawing.Point(247, 381);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(70, 37);
            this.btnsil.TabIndex = 20;
            this.btnsil.Text = "SİL";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnkaydet.ImageOptions.SvgImage")));
            this.btnkaydet.Location = new System.Drawing.Point(21, 381);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(85, 37);
            this.btnkaydet.TabIndex = 19;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnguncelle.ImageOptions.SvgImage")));
            this.btnguncelle.Location = new System.Drawing.Point(122, 381);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(105, 37);
            this.btnguncelle.TabIndex = 21;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // mskadet
            // 
            this.mskadet.Location = new System.Drawing.Point(110, 183);
            this.mskadet.Mask = "00000";
            this.mskadet.Name = "mskadet";
            this.mskadet.Size = new System.Drawing.Size(157, 21);
            this.mskadet.TabIndex = 22;
            this.mskadet.ValidatingType = typeof(int);
            // 
            // richdetay
            // 
            this.richdetay.Location = new System.Drawing.Point(110, 271);
            this.richdetay.Name = "richdetay";
            this.richdetay.Size = new System.Drawing.Size(157, 83);
            this.richdetay.TabIndex = 18;
            this.richdetay.Text = "";
            this.richdetay.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(52, 274);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 18);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "DETAY :";
            // 
            // txtsatısfıyatı
            // 
            this.txtsatısfıyatı.Location = new System.Drawing.Point(110, 241);
            this.txtsatısfıyatı.Name = "txtsatısfıyatı";
            this.txtsatısfıyatı.Properties.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsatısfıyatı.Properties.Appearance.Options.UseFont = true;
            this.txtsatısfıyatı.Size = new System.Drawing.Size(157, 24);
            this.txtsatısfıyatı.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(13, 244);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(91, 18);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "SATIŞ FİYATI :";
            // 
            // txtalısfıyatı
            // 
            this.txtalısfıyatı.Location = new System.Drawing.Point(110, 211);
            this.txtalısfıyatı.Name = "txtalısfıyatı";
            this.txtalısfıyatı.Properties.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtalısfıyatı.Properties.Appearance.Options.UseFont = true;
            this.txtalısfıyatı.Size = new System.Drawing.Size(157, 24);
            this.txtalısfıyatı.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(21, 214);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(83, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "ALIŞ FİYATI :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(61, 187);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "ADET :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(76, 159);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "YIL :";
            // 
            // mskyıl
            // 
            this.mskyıl.Location = new System.Drawing.Point(110, 156);
            this.mskyıl.Mask = "0000";
            this.mskyıl.Name = "mskyıl";
            this.mskyıl.Size = new System.Drawing.Size(157, 21);
            this.mskyıl.TabIndex = 8;
            this.mskyıl.ValidatingType = typeof(int);
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(110, 125);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Properties.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmodel.Properties.Appearance.Options.UseFont = true;
            this.txtmodel.Size = new System.Drawing.Size(157, 24);
            this.txtmodel.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(48, 128);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "MODEL :";
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(110, 95);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Properties.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmarka.Properties.Appearance.Options.UseFont = true;
            this.txtmarka.Size = new System.Drawing.Size(157, 24);
            this.txtmarka.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(47, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "MARKA :";
            // 
            // txturun
            // 
            this.txturun.Location = new System.Drawing.Point(110, 65);
            this.txturun.Name = "txturun";
            this.txturun.Properties.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturun.Properties.Appearance.Options.UseFont = true;
            this.txturun.Size = new System.Drawing.Size(157, 24);
            this.txturun.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(31, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "ÜRÜN ADI :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(110, 35);
            this.txtid.Name = "txtid";
            this.txtid.Properties.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Properties.Appearance.Options.UseFont = true;
            this.txtid.Size = new System.Drawing.Size(157, 24);
            this.txtid.TabIndex = 1;
            this.txtid.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID NUMARASI :";
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ÜRÜNLER);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUrunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ÜRÜNLER)).EndInit();
            this.ÜRÜNLER.ResumeLayout(false);
            this.ÜRÜNLER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatısfıyatı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalısfıyatı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmodel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl ÜRÜNLER;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox richdetay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtsatısfıyatı;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtalısfıyatı;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.MaskedTextBox mskyıl;
        private DevExpress.XtraEditors.TextEdit txtmodel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtmarka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txturun;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private System.Windows.Forms.MaskedTextBox mskadet;
    }
}