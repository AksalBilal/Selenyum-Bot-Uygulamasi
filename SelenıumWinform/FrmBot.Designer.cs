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
            this.chTaramaSayisi = new DevExpress.XtraEditors.CheckEdit();
            this.cmbSayfa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSayfa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTaramaSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSayfa.Properties)).BeginInit();
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
            this.btnSirketGetir.Location = new System.Drawing.Point(391, 202);
            this.btnSirketGetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSirketGetir.Name = "btnSirketGetir";
            this.btnSirketGetir.Size = new System.Drawing.Size(227, 65);
            this.btnSirketGetir.TabIndex = 31;
            this.btnSirketGetir.Text = "Şirketleri Tara";
            this.btnSirketGetir.Visible = false;
            this.btnSirketGetir.Click += new System.EventHandler(this.btnSirketGetir_Click);
            // 
            // lblSirketSayi
            // 
            this.lblSirketSayi.AutoSize = true;
            this.lblSirketSayi.BackColor = System.Drawing.Color.Transparent;
            this.lblSirketSayi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketSayi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSirketSayi.Location = new System.Drawing.Point(272, 271);
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
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Başlangıç İlini Seçiniz : ";
            // 
            // CmbIl
            // 
            this.CmbIl.EditValue = "İl Seçiniz";
            this.CmbIl.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.CmbIl.Location = new System.Drawing.Point(391, 18);
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
            this.CmbIl.SelectedIndexChanged += new System.EventHandler(this.CmbIl_SelectedIndexChanged);
            // 
            // CmbIlce
            // 
            this.CmbIlce.EditValue = "İlçe Seçiniz";
            this.CmbIlce.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.CmbIlce.Location = new System.Drawing.Point(391, 68);
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
            this.CmbIlce.SelectedIndexChanged += new System.EventHandler(this.CmbIlce_SelectedIndexChanged);
            // 
            // lblIlce
            // 
            this.lblIlce.BackColor = System.Drawing.Color.Transparent;
            this.lblIlce.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblIlce.Location = new System.Drawing.Point(12, 63);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(335, 33);
            this.lblIlce.TabIndex = 37;
            this.lblIlce.Text = "Başlangıç İlçesini Seçiniz :";
            this.lblIlce.Visible = false;
            // 
            // chTaramaSayisi
            // 
            this.chTaramaSayisi.Location = new System.Drawing.Point(313, 160);
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
            // cmbSayfa
            // 
            this.cmbSayfa.EditValue = "Sayfa Seçiniz";
            this.cmbSayfa.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.cmbSayfa.Location = new System.Drawing.Point(391, 122);
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
            this.cmbSayfa.Size = new System.Drawing.Size(227, 30);
            this.cmbSayfa.TabIndex = 42;
            this.cmbSayfa.Visible = false;
            this.cmbSayfa.SelectedIndexChanged += new System.EventHandler(this.cmbSayfa_SelectedIndexChanged);
            // 
            // lblSayfa
            // 
            this.lblSayfa.BackColor = System.Drawing.Color.Transparent;
            this.lblSayfa.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSayfa.Location = new System.Drawing.Point(12, 118);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(373, 33);
            this.lblSayfa.TabIndex = 41;
            this.lblSayfa.Text = "Başlangıç Sayfasını Seçiniz :";
            this.lblSayfa.Visible = false;
            // 
            // FrmBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 317);
            this.Controls.Add(this.cmbSayfa);
            this.Controls.Add(this.lblSayfa);
            this.Controls.Add(this.chTaramaSayisi);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbSayfa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSirketGetir;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIl;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIlce;
        private System.Windows.Forms.Label lblIlce;
        private DevExpress.XtraEditors.CheckEdit chTaramaSayisi;
        public System.Windows.Forms.Label lblSirketSayi;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSayfa;
        private System.Windows.Forms.Label lblSayfa;
    }
}

