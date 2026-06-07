namespace HukukBurosuOtomasyon
{
    partial class FrmOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeler));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RichTxtEkstra = new System.Windows.Forms.RichTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.TxtSekreter = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAvukat = new DevExpress.XtraEditors.TextEdit();
            this.TxtMuvekkil = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.MaskedTxtSonOdeme = new System.Windows.Forms.MaskedTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDavaAdi = new DevExpress.XtraEditors.TextEdit();
            this.MaskedTxtOdemeTutari = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.MaskedTxtDurusmaSayisi = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSekreter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAvukat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMuvekkil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDavaAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(227, 369);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(74, 65);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(85, 369);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(67, 61);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(157, 372);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(69, 59);
            this.simpleButton4.TabIndex = 11;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(311, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1051, 565);
            this.gridControl1.TabIndex = 105;
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
            this.BtnKaydet.Location = new System.Drawing.Point(13, 367);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnKaydet.Size = new System.Drawing.Size(67, 72);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RichTxtEkstra
            // 
            this.RichTxtEkstra.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RichTxtEkstra.Location = new System.Drawing.Point(136, 296);
            this.RichTxtEkstra.Name = "RichTxtEkstra";
            this.RichTxtEkstra.Size = new System.Drawing.Size(159, 43);
            this.RichTxtEkstra.TabIndex = 8;
            this.RichTxtEkstra.Text = "";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(75, 297);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 19);
            this.labelControl3.TabIndex = 139;
            this.labelControl3.Text = "Ekstra :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(106, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 19);
            this.labelControl1.TabIndex = 119;
            this.labelControl1.Text = "Id : ";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(64, 205);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(65, 19);
            this.labelControl13.TabIndex = 137;
            this.labelControl13.Text = "Sekreter : ";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(137, 51);
            this.TxtId.Name = "TxtId";
            this.TxtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtId.Properties.Appearance.Options.UseFont = true;
            this.TxtId.Size = new System.Drawing.Size(159, 24);
            this.TxtId.TabIndex = 120;
            // 
            // TxtSekreter
            // 
            this.TxtSekreter.Location = new System.Drawing.Point(137, 202);
            this.TxtSekreter.Name = "TxtSekreter";
            this.TxtSekreter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSekreter.Properties.Appearance.Options.UseFont = true;
            this.TxtSekreter.Size = new System.Drawing.Size(159, 24);
            this.TxtSekreter.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(58, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 19);
            this.labelControl2.TabIndex = 121;
            this.labelControl2.Text = "Müvekkil : ";
            // 
            // TxtAvukat
            // 
            this.TxtAvukat.Location = new System.Drawing.Point(137, 172);
            this.TxtAvukat.Name = "TxtAvukat";
            this.TxtAvukat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAvukat.Properties.Appearance.Options.UseFont = true;
            this.TxtAvukat.Size = new System.Drawing.Size(159, 24);
            this.TxtAvukat.TabIndex = 4;
            // 
            // TxtMuvekkil
            // 
            this.TxtMuvekkil.Location = new System.Drawing.Point(137, 81);
            this.TxtMuvekkil.Name = "TxtMuvekkil";
            this.TxtMuvekkil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMuvekkil.Properties.Appearance.Options.UseFont = true;
            this.TxtMuvekkil.Size = new System.Drawing.Size(159, 24);
            this.TxtMuvekkil.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(26, 267);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(106, 19);
            this.labelControl4.TabIndex = 123;
            this.labelControl4.Text = "Ödeme Tutarı : ";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(68, 175);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(60, 19);
            this.labelControl15.TabIndex = 134;
            this.labelControl15.Text = " Avukat : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 142);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 19);
            this.labelControl5.TabIndex = 124;
            this.labelControl5.Text = "Duruşma Sayısı: ";
            // 
            // MaskedTxtSonOdeme
            // 
            this.MaskedTxtSonOdeme.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskedTxtSonOdeme.Location = new System.Drawing.Point(137, 232);
            this.MaskedTxtSonOdeme.Mask = "00/00/0000";
            this.MaskedTxtSonOdeme.Name = "MaskedTxtSonOdeme";
            this.MaskedTxtSonOdeme.Size = new System.Drawing.Size(159, 26);
            this.MaskedTxtSonOdeme.TabIndex = 6;
            this.MaskedTxtSonOdeme.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(40, 235);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(86, 19);
            this.labelControl10.TabIndex = 130;
            this.labelControl10.Text = "Son Ödeme :";
            // 
            // TxtDavaAdi
            // 
            this.TxtDavaAdi.Location = new System.Drawing.Point(136, 110);
            this.TxtDavaAdi.Name = "TxtDavaAdi";
            this.TxtDavaAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDavaAdi.Properties.Appearance.Options.UseFont = true;
            this.TxtDavaAdi.Size = new System.Drawing.Size(159, 24);
            this.TxtDavaAdi.TabIndex = 2;
            // 
            // MaskedTxtOdemeTutari
            // 
            this.MaskedTxtOdemeTutari.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskedTxtOdemeTutari.Location = new System.Drawing.Point(137, 264);
            this.MaskedTxtOdemeTutari.Mask = "0000000000000000";
            this.MaskedTxtOdemeTutari.Name = "MaskedTxtOdemeTutari";
            this.MaskedTxtOdemeTutari.Size = new System.Drawing.Size(159, 26);
            this.MaskedTxtOdemeTutari.TabIndex = 7;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(56, 113);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(74, 19);
            this.labelControl11.TabIndex = 128;
            this.labelControl11.Text = "Dava Adı : ";
            // 
            // MaskedTxtDurusmaSayisi
            // 
            this.MaskedTxtDurusmaSayisi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskedTxtDurusmaSayisi.Location = new System.Drawing.Point(137, 140);
            this.MaskedTxtDurusmaSayisi.Mask = "00000000000";
            this.MaskedTxtDurusmaSayisi.Name = "MaskedTxtDurusmaSayisi";
            this.MaskedTxtDurusmaSayisi.Size = new System.Drawing.Size(159, 26);
            this.MaskedTxtDurusmaSayisi.TabIndex = 3;
            this.MaskedTxtDurusmaSayisi.ValidatingType = typeof(int);
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1362, 564);
            this.Controls.Add(this.RichTxtEkstra);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtSekreter);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtAvukat);
            this.Controls.Add(this.TxtMuvekkil);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.MaskedTxtSonOdeme);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.TxtDavaAdi);
            this.Controls.Add(this.MaskedTxtOdemeTutari);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.MaskedTxtDurusmaSayisi);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.BtnKaydet);
            this.Name = "FrmOdemeler";
            this.ShowInTaskbar = false;
            this.Text = "ÖDEMELER";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSekreter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAvukat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMuvekkil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDavaAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RichTxtEkstra;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.TextEdit TxtSekreter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAvukat;
        private DevExpress.XtraEditors.TextEdit TxtMuvekkil;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.MaskedTextBox MaskedTxtSonOdeme;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit TxtDavaAdi;
        private System.Windows.Forms.MaskedTextBox MaskedTxtOdemeTutari;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.MaskedTextBox MaskedTxtDurusmaSayisi;
    }
}