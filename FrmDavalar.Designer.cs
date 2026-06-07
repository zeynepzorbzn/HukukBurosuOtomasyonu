namespace HukukBurosuOtomasyon
{
    partial class FrmDavalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDavalar));
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.TxtDavaDurumu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDavaAvukati = new DevExpress.XtraEditors.TextEdit();
            this.TxtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMahkeme = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.MaskedTxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDavaAdi = new DevExpress.XtraEditors.TextEdit();
            this.MaskedTxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.TxtDavaTuru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.RichTxtDetay = new System.Windows.Forms.RichTextBox();
            this.TxtDosyaNo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDavaDurumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDavaAvukati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMahkeme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDavaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDavaTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDosyaNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(95, 441);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(67, 61);
            this.simpleButton3.TabIndex = 70;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(167, 444);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(69, 59);
            this.simpleButton4.TabIndex = 69;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(332, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1026, 565);
            this.gridControl1.TabIndex = 48;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(24, 436);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnKaydet.Size = new System.Drawing.Size(67, 72);
            this.BtnKaydet.TabIndex = 68;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(131, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 19);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Id : ";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(56, 229);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(100, 19);
            this.labelControl13.TabIndex = 67;
            this.labelControl13.Text = "Dava Durumu : ";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(162, 48);
            this.TxtId.Name = "TxtId";
            this.TxtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtId.Properties.Appearance.Options.UseFont = true;
            this.TxtId.Size = new System.Drawing.Size(159, 24);
            this.TxtId.TabIndex = 44;
            // 
            // TxtDavaDurumu
            // 
            this.TxtDavaDurumu.Location = new System.Drawing.Point(162, 228);
            this.TxtDavaDurumu.Name = "TxtDavaDurumu";
            this.TxtDavaDurumu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDavaDurumu.Properties.Appearance.Options.UseFont = true;
            this.TxtDavaDurumu.Size = new System.Drawing.Size(159, 24);
            this.TxtDavaDurumu.TabIndex = 66;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(143, 19);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Müvekkil Ad Soyad : ";
            // 
            // TxtDavaAvukati
            // 
            this.TxtDavaAvukati.Location = new System.Drawing.Point(162, 198);
            this.TxtDavaAvukati.Name = "TxtDavaAvukati";
            this.TxtDavaAvukati.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDavaAvukati.Properties.Appearance.Options.UseFont = true;
            this.TxtDavaAvukati.Size = new System.Drawing.Size(159, 24);
            this.TxtDavaAvukati.TabIndex = 65;
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(162, 78);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdSoyad.Properties.Appearance.Options.UseFont = true;
            this.TxtAdSoyad.Size = new System.Drawing.Size(159, 24);
            this.TxtAdSoyad.TabIndex = 46;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(33, 323);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(124, 19);
            this.labelControl14.TabIndex = 63;
            this.labelControl14.Text = "Dava Mahkemesi : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(76, 292);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 19);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "Dava Bitiş : ";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(59, 199);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(97, 19);
            this.labelControl15.TabIndex = 64;
            this.labelControl15.Text = "Dava Avukatı : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(37, 139);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(114, 19);
            this.labelControl5.TabIndex = 49;
            this.labelControl5.Text = "Dava Dosya No :";
            // 
            // TxtMahkeme
            // 
            this.TxtMahkeme.Location = new System.Drawing.Point(162, 322);
            this.TxtMahkeme.Name = "TxtMahkeme";
            this.TxtMahkeme.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMahkeme.Properties.Appearance.Options.UseFont = true;
            this.TxtMahkeme.Size = new System.Drawing.Size(159, 24);
            this.TxtMahkeme.TabIndex = 62;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(69, 169);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 19);
            this.labelControl6.TabIndex = 50;
            this.labelControl6.Text = "Dava Türü : ";
            // 
            // MaskedTxtBaslangic
            // 
            this.MaskedTxtBaslangic.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskedTxtBaslangic.Location = new System.Drawing.Point(162, 258);
            this.MaskedTxtBaslangic.Mask = "00/00/0000";
            this.MaskedTxtBaslangic.Name = "MaskedTxtBaslangic";
            this.MaskedTxtBaslangic.Size = new System.Drawing.Size(159, 26);
            this.MaskedTxtBaslangic.TabIndex = 61;
            this.MaskedTxtBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(40, 260);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(116, 19);
            this.labelControl10.TabIndex = 60;
            this.labelControl10.Text = "Dava Başlangıç : ";
            // 
            // TxtDavaAdi
            // 
            this.TxtDavaAdi.Location = new System.Drawing.Point(161, 107);
            this.TxtDavaAdi.Name = "TxtDavaAdi";
            this.TxtDavaAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDavaAdi.Properties.Appearance.Options.UseFont = true;
            this.TxtDavaAdi.Size = new System.Drawing.Size(159, 24);
            this.TxtDavaAdi.TabIndex = 52;
            // 
            // MaskedTxtBitis
            // 
            this.MaskedTxtBitis.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskedTxtBitis.Location = new System.Drawing.Point(162, 290);
            this.MaskedTxtBitis.Mask = "00/00/0000";
            this.MaskedTxtBitis.Name = "MaskedTxtBitis";
            this.MaskedTxtBitis.Size = new System.Drawing.Size(159, 26);
            this.MaskedTxtBitis.TabIndex = 54;
            this.MaskedTxtBitis.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(81, 110);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(74, 19);
            this.labelControl11.TabIndex = 55;
            this.labelControl11.Text = "Dava Adı : ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(237, 441);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(74, 65);
            this.simpleButton2.TabIndex = 71;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // TxtDavaTuru
            // 
            this.TxtDavaTuru.Location = new System.Drawing.Point(162, 168);
            this.TxtDavaTuru.Name = "TxtDavaTuru";
            this.TxtDavaTuru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDavaTuru.Properties.Appearance.Options.UseFont = true;
            this.TxtDavaTuru.Size = new System.Drawing.Size(159, 24);
            this.TxtDavaTuru.TabIndex = 72;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(66, 355);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 19);
            this.labelControl3.TabIndex = 73;
            this.labelControl3.Text = "Dava Detay :";
            // 
            // RichTxtDetay
            // 
            this.RichTxtDetay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RichTxtDetay.Location = new System.Drawing.Point(162, 353);
            this.RichTxtDetay.Name = "RichTxtDetay";
            this.RichTxtDetay.Size = new System.Drawing.Size(159, 43);
            this.RichTxtDetay.TabIndex = 74;
            this.RichTxtDetay.Text = "";
            // 
            // TxtDosyaNo
            // 
            this.TxtDosyaNo.Location = new System.Drawing.Point(162, 138);
            this.TxtDosyaNo.Name = "TxtDosyaNo";
            this.TxtDosyaNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDosyaNo.Properties.Appearance.Options.UseFont = true;
            this.TxtDosyaNo.Size = new System.Drawing.Size(159, 24);
            this.TxtDosyaNo.TabIndex = 75;
            // 
            // FrmDavalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1362, 564);
            this.Controls.Add(this.TxtDosyaNo);
            this.Controls.Add(this.RichTxtDetay);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtDavaTuru);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtDavaDurumu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtDavaAvukati);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TxtMahkeme);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.MaskedTxtBaslangic);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.TxtDavaAdi);
            this.Controls.Add(this.MaskedTxtBitis);
            this.Controls.Add(this.labelControl11);
            this.Name = "FrmDavalar";
            this.Text = "DAVALAR";
            this.Load += new System.EventHandler(this.FrmDavalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDavaDurumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDavaAvukati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMahkeme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDavaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDavaTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDosyaNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.TextEdit TxtDavaDurumu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtDavaAvukati;
        private DevExpress.XtraEditors.TextEdit TxtAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtMahkeme;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.MaskedTextBox MaskedTxtBaslangic;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit TxtDavaAdi;
        private System.Windows.Forms.MaskedTextBox MaskedTxtBitis;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit TxtDavaTuru;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RichTextBox RichTxtDetay;
        private DevExpress.XtraEditors.TextEdit TxtDosyaNo;
    }
}