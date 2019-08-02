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
            this.lblSirketSayi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblIlce = new System.Windows.Forms.Label();
            this.btnIlceGetir = new DevExpress.XtraEditors.SimpleButton();
            this.chTaramaSayisi = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTaramaSayisi.Properties)).BeginInit();
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
            this.btnSirketGetir.Location = new System.Drawing.Point(273, 182);
            this.btnSirketGetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSirketGetir.Name = "btnSirketGetir";
            this.btnSirketGetir.Size = new System.Drawing.Size(227, 65);
            this.btnSirketGetir.TabIndex = 31;
            this.btnSirketGetir.Text = "Şirketleri Getir";
            this.btnSirketGetir.Visible = false;
            this.btnSirketGetir.Click += new System.EventHandler(this.btnSirketGetir_Click);
            // 
            // lblSirketSayi
            // 
            this.lblSirketSayi.AutoSize = true;
            this.lblSirketSayi.BackColor = System.Drawing.Color.Transparent;
            this.lblSirketSayi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketSayi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSirketSayi.Location = new System.Drawing.Point(189, 251);
            this.lblSirketSayi.Name = "lblSirketSayi";
            this.lblSirketSayi.Size = new System.Drawing.Size(278, 32);
            this.lblSirketSayi.TabIndex = 32;
            this.lblSirketSayi.Text = "Gezilen Şirket Sayısı :";
            this.lblSirketSayi.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Başlangıç İlini Seçiniz : ";
            // 
            // CmbIl
            // 
            this.CmbIl.EditValue = "İl Seçiniz";
            this.CmbIl.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.CmbIl.Location = new System.Drawing.Point(273, 14);
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
            this.CmbIl.Size = new System.Drawing.Size(227, 30);
            this.CmbIl.TabIndex = 36;
            // 
            // CmbIlce
            // 
            this.CmbIlce.EditValue = "İlçe Seçiniz";
            this.CmbIlce.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.CmbIlce.Location = new System.Drawing.Point(273, 107);
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
            this.CmbIlce.Size = new System.Drawing.Size(227, 30);
            this.CmbIlce.TabIndex = 38;
            this.CmbIlce.Visible = false;
            // 
            // lblIlce
            // 
            this.lblIlce.BackColor = System.Drawing.Color.Transparent;
            this.lblIlce.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblIlce.Location = new System.Drawing.Point(16, 104);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(335, 33);
            this.lblIlce.TabIndex = 37;
            this.lblIlce.Text = "Başlangıç İlçesini Seçiniz :";
            this.lblIlce.Visible = false;
            // 
            // btnIlceGetir
            // 
            this.btnIlceGetir.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlceGetir.Appearance.Options.UseFont = true;
            this.btnIlceGetir.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlceGetir.AppearanceHovered.Options.UseFont = true;
            this.btnIlceGetir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnIlceGetir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIlceGetir.ImageOptions.Image")));
            this.btnIlceGetir.Location = new System.Drawing.Point(273, 51);
            this.btnIlceGetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIlceGetir.Name = "btnIlceGetir";
            this.btnIlceGetir.Size = new System.Drawing.Size(227, 49);
            this.btnIlceGetir.TabIndex = 39;
            this.btnIlceGetir.Text = "İlçeleri Getir";
            this.btnIlceGetir.Click += new System.EventHandler(this.btnIlceGetir_Click);
            // 
            // chTaramaSayisi
            // 
            this.chTaramaSayisi.Location = new System.Drawing.Point(260, 143);
            this.chTaramaSayisi.Name = "chTaramaSayisi";
            this.chTaramaSayisi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.chTaramaSayisi.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chTaramaSayisi.Properties.Appearance.Options.UseFont = true;
            this.chTaramaSayisi.Properties.Appearance.Options.UseForeColor = true;
            this.chTaramaSayisi.Properties.Caption = "Taranan Sayısını Göster";
            this.chTaramaSayisi.Size = new System.Drawing.Size(305, 35);
            this.chTaramaSayisi.TabIndex = 40;
            this.chTaramaSayisi.Visible = false;
            // 
            // FrmBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 288);
            this.Controls.Add(this.chTaramaSayisi);
            this.Controls.Add(this.btnIlceGetir);
            this.Controls.Add(this.CmbIlce);
            this.Controls.Add(this.lblIlce);
            this.Controls.Add(this.CmbIl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSirketSayi);
            this.Controls.Add(this.btnSirketGetir);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBot";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Çekme Uygulaması";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CmbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTaramaSayisi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSirketGetir;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIl;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIlce;
        private System.Windows.Forms.Label lblIlce;
        private DevExpress.XtraEditors.SimpleButton btnIlceGetir;
        private DevExpress.XtraEditors.CheckEdit chTaramaSayisi;
        public System.Windows.Forms.Label lblSirketSayi;
    }
}

