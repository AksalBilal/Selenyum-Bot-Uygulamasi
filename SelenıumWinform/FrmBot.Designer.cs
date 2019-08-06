namespace SelenıumWinform
{
    partial class FrmBot
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBot));
            this.btnSirketGetir = new DevExpress.XtraEditors.SimpleButton();
            this.CmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbSayfa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblIl = new System.Windows.Forms.Label();
            this.lblIlce = new System.Windows.Forms.Label();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.ImgResim = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSayfa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgResim.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            splashScreenManager.ClosingDelay = 500;
            // 
            // btnSirketGetir
            // 
            this.btnSirketGetir.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirketGetir.Appearance.Options.UseFont = true;
            this.btnSirketGetir.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirketGetir.AppearanceHovered.Options.UseFont = true;
            this.btnSirketGetir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSirketGetir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSirketGetir.ImageOptions.Image")));
            this.btnSirketGetir.Location = new System.Drawing.Point(287, 146);
            this.btnSirketGetir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSirketGetir.Name = "btnSirketGetir";
            this.btnSirketGetir.Size = new System.Drawing.Size(235, 75);
            this.btnSirketGetir.TabIndex = 31;
            this.btnSirketGetir.Text = "Şirketleri Tara";
            this.btnSirketGetir.Visible = false;
            this.btnSirketGetir.Click += new System.EventHandler(this.btnSirketGetir_Click);
            // 
            // CmbIl
            // 
            this.CmbIl.EditValue = "İl Seçiniz";
            this.CmbIl.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.CmbIl.Location = new System.Drawing.Point(287, 18);
            this.CmbIl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbIl.Name = "CmbIl";
            this.CmbIl.Properties.Appearance.BackColor = System.Drawing.Color.Gold;
            this.CmbIl.Properties.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CmbIl.Properties.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.CmbIl.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbIl.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.CmbIl.Properties.Appearance.Options.UseBackColor = true;
            this.CmbIl.Properties.Appearance.Options.UseBorderColor = true;
            this.CmbIl.Properties.Appearance.Options.UseFont = true;
            this.CmbIl.Properties.Appearance.Options.UseForeColor = true;
            this.CmbIl.Properties.AppearanceItemSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CmbIl.Properties.AppearanceItemSelected.Options.UseBackColor = true;
            this.CmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbIl.Properties.DropDownRows = 10;
            this.CmbIl.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.CmbIl.Properties.Items.AddRange(new object[] {
            "ADANA",
            "ADIYAMAN",
            "AFYON",
            "AĞRI",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "ISPARTA",
            "İÇEL(MERSİN)",
            "İSTANBUL",
            "İZMİR",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KOCAELİ",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "KAHRAMANMARAŞ",
            "MARDİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "RİZE",
            "SAKARYA",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "ŞANLIURFA",
            "UŞAK",
            "VAN",
            "YOZGAT",
            "ZONGULDAK",
            "AKSARAY",
            "BAYBURT",
            "KARAMAN",
            "KIRIKKALE",
            "BATMAN",
            "ŞIRNAK",
            "BARTIN",
            "ARDAHAN",
            "IĞDIR",
            "YALOVA",
            "KARABÜK",
            "KİLİS",
            "OSMANİYE",
            "DÜZCE"});
            this.CmbIl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CmbIl.Size = new System.Drawing.Size(235, 26);
            this.CmbIl.TabIndex = 36;
            this.CmbIl.SelectedIndexChanged += new System.EventHandler(this.CmbIl_SelectedIndexChanged);
            // 
            // CmbIlce
            // 
            this.CmbIlce.EditValue = "İlçe Seçiniz";
            this.CmbIlce.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.CmbIlce.Location = new System.Drawing.Point(287, 56);
            this.CmbIlce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbIlce.Name = "CmbIlce";
            this.CmbIlce.Properties.Appearance.BackColor = System.Drawing.Color.Gold;
            this.CmbIlce.Properties.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CmbIlce.Properties.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.CmbIlce.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbIlce.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.CmbIlce.Properties.Appearance.Options.UseBackColor = true;
            this.CmbIlce.Properties.Appearance.Options.UseBorderColor = true;
            this.CmbIlce.Properties.Appearance.Options.UseFont = true;
            this.CmbIlce.Properties.Appearance.Options.UseForeColor = true;
            this.CmbIlce.Properties.AppearanceItemSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CmbIlce.Properties.AppearanceItemSelected.Options.UseBackColor = true;
            this.CmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbIlce.Properties.DropDownRows = 10;
            this.CmbIlce.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.CmbIlce.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CmbIlce.Size = new System.Drawing.Size(235, 26);
            this.CmbIlce.TabIndex = 38;
            this.CmbIlce.Visible = false;
            this.CmbIlce.SelectedIndexChanged += new System.EventHandler(this.CmbIlce_SelectedIndexChanged);
            // 
            // cmbSayfa
            // 
            this.cmbSayfa.EditValue = "Sayfa Seçiniz";
            this.cmbSayfa.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.cmbSayfa.Location = new System.Drawing.Point(287, 94);
            this.cmbSayfa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSayfa.Name = "cmbSayfa";
            this.cmbSayfa.Properties.Appearance.BackColor = System.Drawing.Color.Gold;
            this.cmbSayfa.Properties.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbSayfa.Properties.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.cmbSayfa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSayfa.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmbSayfa.Properties.Appearance.Options.UseBackColor = true;
            this.cmbSayfa.Properties.Appearance.Options.UseBorderColor = true;
            this.cmbSayfa.Properties.Appearance.Options.UseFont = true;
            this.cmbSayfa.Properties.Appearance.Options.UseForeColor = true;
            this.cmbSayfa.Properties.AppearanceItemSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbSayfa.Properties.AppearanceItemSelected.Options.UseBackColor = true;
            this.cmbSayfa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSayfa.Properties.DropDownRows = 10;
            this.cmbSayfa.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.cmbSayfa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSayfa.Size = new System.Drawing.Size(235, 26);
            this.cmbSayfa.TabIndex = 42;
            this.cmbSayfa.Visible = false;
            this.cmbSayfa.SelectedIndexChanged += new System.EventHandler(this.cmbSayfa_SelectedIndexChanged);
            // 
            // lblIl
            // 
            this.lblIl.AutoSize = true;
            this.lblIl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIl.ForeColor = System.Drawing.Color.DarkRed;
            this.lblIl.Location = new System.Drawing.Point(52, 20);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(232, 23);
            this.lblIl.TabIndex = 43;
            this.lblIl.Text = "Başlangıç İlini Seçiniz :";
            // 
            // lblIlce
            // 
            this.lblIlce.AutoSize = true;
            this.lblIlce.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIlce.ForeColor = System.Drawing.Color.DarkRed;
            this.lblIlce.Location = new System.Drawing.Point(21, 58);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(263, 23);
            this.lblIlce.TabIndex = 44;
            this.lblIlce.Text = "Başlangıç İlçesini Seçiniz :";
            this.lblIlce.Visible = false;
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayfa.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSayfa.Location = new System.Drawing.Point(5, 96);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(279, 23);
            this.lblSayfa.TabIndex = 45;
            this.lblSayfa.Text = "Başlangıç Sayfasını Seçiniz :";
            this.lblSayfa.Visible = false;
            // 
            // ImgResim
            // 
            this.ImgResim.EditValue = ((object)(resources.GetObject("ImgResim.EditValue")));
            this.ImgResim.Location = new System.Drawing.Point(9, 122);
            this.ImgResim.Name = "ImgResim";
            this.ImgResim.Properties.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.ImgResim.Properties.Appearance.Options.UseBackColor = true;
            this.ImgResim.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImgResim.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImgResim.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.ImgResim.Size = new System.Drawing.Size(275, 123);
            this.ImgResim.TabIndex = 46;
            this.ImgResim.TabStop = true;
            this.ImgResim.Visible = false;
            // 
            // FrmBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(526, 248);
            this.Controls.Add(this.lblSayfa);
            this.Controls.Add(this.lblIlce);
            this.Controls.Add(this.lblIl);
            this.Controls.Add(this.cmbSayfa);
            this.Controls.Add(this.CmbIlce);
            this.Controls.Add(this.CmbIl);
            this.Controls.Add(this.btnSirketGetir);
            this.Controls.Add(this.ImgResim);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmBot";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Çekme Uygulaması";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CmbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSayfa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgResim.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSirketGetir;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIl;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSayfa;
        private System.Windows.Forms.Label lblIl;
        private System.Windows.Forms.Label lblIlce;
        private System.Windows.Forms.Label lblSayfa;
        private DevExpress.XtraEditors.PictureEdit ImgResim;
    }
}

