using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using  excel=Microsoft.Office.Interop.Excel;

namespace SelenıumWinform
{
    public partial class FrmBot : Form
    {
        public FrmBot()
        {
            InitializeComponent();
        }
        IWebDriver driver;//Chrome Driver
        List<IWebElement> ilceler;//İlçe listesi
        List<IWebElement> sirketler;//Şirket Listesi
        List<string> sirketler_ = new List<string>();//Şirket Listesi
        List<string> ilceler_ = new List<string>();//ilce Listesi
        int sayfasayisi, sayfasayisi2 = 0, sayac = 0, SirketSayisi = 0, Sayfa2Baslangic, CokSayfa, satir = 1, sutun = 1, sayim = 0;//değişkenler
        public int ToplamSirketSayisi = 0;
        string il,Il,il_,ilce,Ilce;//İl ilçe adları
        string sirketUrl, yonlendirme;
        bool sayfaKontrol = false, sayfaKontrol2 = false;
        
        private void cmbSayfa_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSirketGetir.Visible = true;
        }

        private void CmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
                CmbIlce.Properties.Items.Clear();
                cmbSayfa.Properties.Items.Clear();
                CmbIlce.SelectedIndex = -1;
                SplashScreenManager.ShowForm(typeof(IlceScreen)); //Bekleme Efekti
                if (CmbIlce.Properties.Items != null)
                {
                    CmbIlce.Properties.Items.Clear();
                }
            try
            {
                string link = @"https://www.find.com.tr/Search";
                driver.Navigate().GoToUrl(link);
            }
            catch (Exception)
            {
                driver.Quit();
                GirisYap(3000);
                string link = @"https://www.find.com.tr/Search";
                driver.Navigate().GoToUrl(link);
            }
                
                for (int i = CmbIl.SelectedIndex + 1; i <= 81;)//İL Sayısı kadar döngü
                {
                    if (i <= 9)//9 dan küçük id li iller için yapılacaklar
                    {
                        ilceler = driver.FindElements(By.XPath("//*[@id=0" + i + "]/ol/li/a")).ToList();//İlçe listesi
                        foreach (var item in ilceler)
                        {
                            string[] ilceBul = item.Text.Split(' ');
                            string[] sayfaBul = item.Text.Replace(")", "(").Split('(');


                            CmbIlce.Properties.Items.Add(ilceBul[0]);
                        }
                    }
                    else
                    {//9 dan büyük id li iller için yapılacaklar
                        ilceler = driver.FindElements(By.XPath("//*[@id=" + i + "]/ol/li/a")).ToList();//İlçe listesi
                        foreach (var item in ilceler)
                        {
                            string[] ilceBul = item.Text.Split(' ');
                            CmbIlce.Properties.Items.Add(ilceBul[0]);
                        }
                    }
                    break;
                }
                CmbIlce.Visible = true;
                lblIlce.Visible = true;
               
                SplashScreenManager.CloseForm();//Bekleme Efekti bitiş
           
        }

        private void CmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSayfa.Properties.Items.Clear();
            cmbSayfa.SelectedIndex = -1;
            lblSayfa.Visible = true;
            cmbSayfa.Visible = true;
            string[] sayfaBul=  ilceler[CmbIlce.SelectedIndex].Text.Replace(")", "(").Split('(');
            string ToplamUrun_ = sayfaBul[1];//Yazıdaki toplam ürün adedi
            if (ToplamUrun_.Contains("."))
            {
                string[] SayiBirlestir = ToplamUrun_.Split('.');//Yazıyı istediğim biçimde birleştirmek için ayırdım
                ToplamUrun_ = SayiBirlestir[0] + SayiBirlestir[1];//yazıyı tekrar birleştirdim
                if (Convert.ToInt32(ToplamUrun_) % 20 == 0)
                {
                    sayfasayisi2 = (Convert.ToInt32(ToplamUrun_) / 20);
                }
                else
                {
                    sayfasayisi2 = (Convert.ToInt32(ToplamUrun_) / 20) + 1;//toplam sayfa sayısını buldum
                }
            }//sayıyı int e çevirme ToplamUrun_>999
            else
            {
                if (Convert.ToInt32(ToplamUrun_) % 20 == 0)
                { sayfasayisi2 = (Convert.ToInt32(ToplamUrun_) / 20); }
                else
                {
                    sayfasayisi2 = (Convert.ToInt32(ToplamUrun_) / 20) + 1;//toplam sayfa sayısını buldum
                }
            }//ToplamUrun_<999"
            for (int i = 1; i <= sayfasayisi2; i++)
            {
                cmbSayfa.Properties.Items.Add(i);
            }

        }

        bool telKontrol = false;
       
        List<string> sutunAdlari = new List<string>();//Excel tablosu için sutun adları
        private void Form1_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(LoginScreen)); //Bekleme Efekti
            Thread.Sleep(2000);
            try
             {
                 GirisYap(4000);
             }
             catch (Exception)
             {
                 GirisYap(8000);
             }
           SplashScreenManager.CloseForm();//Bekleme Efekti bitiş
        }
        public void GirisYap(int beklemeSuresi)
        {//İlk başta sisteme login yapan fonksiyon
            string login = @"https://www.find.com.tr/User/UserLogin?";//Login için url
            var options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddAdditionalCapability("useAutomationExtension", false);
            options.AddArguments("--no-sandbox");
            options.AddArguments("--disable-infobars"); 
            options.AddArguments("--disable-dev-shm-usage");
            options.AddArguments("--disable-browser-side-navigation"); 
            options.AddArguments("--disable-gpu");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl(login);
            Thread.Sleep(beklemeSuresi);
            driver.FindElement(By.XPath("//*[@id='LoginUsername']")).SendKeys("findlogin@hotmail.com");//Mail
            driver.FindElement(By.XPath("//*[@id='LoginPassword']")).SendKeys("aYMUCJpg2CNj2Eh");//Şifre
            driver.FindElement(By.Id("LoginButton")).Click();
        }
        private void VeriCek(Sirket sirket)//Şirket detay sayfasından verileri çeken fonksiyon
        {
            sirket.SirketAdi = driver.FindElement(By.XPath("//html/body/div[3]/section/div[1]/div/div/div[2]/div[1]/div[1]/h1")).Text;//Şirket adı
            sirket.SirketAciklama = driver.FindElement(By.XPath("//*[@id='About']/div[2]/div")).Text;//Şirket Açıklaması
            sirket.SirketSektorler = driver.FindElements(By.XPath("/html/body/div[3]/section/div[1]/div/div/div[2]/div[2]/ul[1]/li/a/span")).ToList();//Şirket Sektörleri
            sirket.SirketAltSektorler = driver.FindElements(By.XPath("/html/body/div[3]/section/div[1]/div/div/div[2]/div[2]/ul[2]/li")).ToList();//Şirket alt sektorleri
            foreach (var item in sirket.SirketSektorler)//Sektörlerin birleştirilmesi
            {
                if (sirket.SirketSektorler.Count==1)
                {                    sirket.SirketSektor = item.Text;                }
                else if (item != sirket.SirketSektorler[0])
                {                    sirket.SirketSektor += item.Text + "-";                }
            }
            foreach (var item in sirket.SirketAltSektorler)//Alt Sektörlerin birleştirilmesi
            {
                if (sirket.SirketAltSektorler.Count == 1)
                {                    sirket.SirketAltSektor = item.Text;                }
                else if (item != sirket.SirketAltSektorler[0])
                {                    sirket.SirketAltSektor += item.Text + "-";            }

            }
            sirket.SirketAdresi = driver.FindElement(By.XPath("//html/body/div[3]/section/div[1]/div/div/div[2]/div[1]/div[1]/div[1]/h2")).Text;//Şirket Adresi
            try
            {  
                sirket.SirketTel1 = driver.FindElement(By.XPath("//html/body/div[3]/section/div[1]/div/div/div[3]/div/ul/li[2]/a")).Text;//Şirket Tel
                if (sirket.SirketTel1 == "Mesaj Gönder")
                {         sirket.SirketTel1 = "-";        }
                else if (sirket.SirketTel1.Contains("@"))
                {
                   
                    sirket.SirketMail = sirket.SirketTel1;
                    sirket.SirketTel1 = "00";
                    telKontrol = true;
                }
            }
            catch (Exception)
            {
                try
                {
                    sirket.SirketTel1 = driver.FindElement(By.XPath("//html/body/div[3]/section/div[2]/div/div/aside/div/div[3]/div[2]/ul/li[1]/a/span/span")).Text;//Şirket Tel
                }
                catch (Exception)
                {                   sirket.SirketTel1 = "-";              }
            }
            try
            {
                sirket.SirketTel2 = driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div/div/aside/div/div[5]/div[2]/ul/li[2]/a/span/span")).Text;//Şirket Tel
            }
            catch (Exception)
            {                sirket.SirketTel2 = "-";            }

            try
            {
                sirket.SirketSite = driver.FindElement(By.XPath("//html/body/div[3]/section/div[1]/div/div/div[3]/div/ul/li[3]/a/text()")).Text;//Şirket Site
            }
            catch (Exception)
            {                sirket.SirketSite = "-";            }
            if (telKontrol==false)
            {
                try
                {
                    sirket.SirketMail = driver.FindElement(By.XPath("//html/body/div[3]/section/div[1]/div/div/div[3]/div/ul/li[2]/a/text()")).Text;//Şirket Mail
                                                                                                                                                    //html/body/div[3]/section/div[2]/div/div/aside/div/div[5]/div[2]/ul/li[3]/a/span
                }
                catch (Exception)
                {
                    try
                    {
                        sirket.SirketMail = driver.FindElement(By.XPath("//html/body/div[3]/section/div[2]/div/div/aside/div/div[5]/div[2]/ul/li[3]/a/span")).Text;
                    }
                    catch (Exception)
                    { sirket.SirketMail = " - "; }
                } 
                }
            telKontrol = false;
        }
        private string StringReplace(string text)
        {//Türkçe karakterlerin ve bazı noktalama işaretlerinin düzeltilmesi için yazılmış fonksiyon
            text = text.Replace("İ", "I");
            text = text.Replace("ı", "i");
            text = text.Replace("Ğ", "G");
            text = text.Replace("ğ", "g");
            text = text.Replace("Ö", "O");
            text = text.Replace("ö", "o");
            text = text.Replace("Ü", "U");
            text = text.Replace("ü", "u");
            text = text.Replace("Ş", "S");
            text = text.Replace("ş", "s");
            text = text.Replace("Ç", "C");
            text = text.Replace("ç", "c");
            text = text.Replace(" ", "");
            text = text.Replace("-", "");
            text = text.Replace(".", "");
            text = text.Replace("/", "");
            text = text.Replace("(", "");
            text = text.Replace(")", "");
            return text;
        }
        private void btnSirketGetir_Click(object sender, EventArgs e)
        {
            if (CmbIlce.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen Bir ilçe seçiniz");
            }
            else 
            {
                MessageBox.Show("Bot Çalışırken açılan uygulamaları kapatmayın!","Bilgilendirme Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Information);
               
                SplashScreenManager.ShowForm(typeof(WaitForm1)); //Bekleme Efekti
                excel.Application exceldosya = new excel.Application();// Excel işlemleri için
                exceldosya.Visible = true;
                object Missing = Type.Missing;// Excel işlemleri için
                Workbook Sirketler = exceldosya.Workbooks.Add(Missing);// Excel işlemleri için
                Worksheet Sayfa1 = (Worksheet)Sirketler.Sheets[1];// Excel işlemleri için
                for (int i = CmbIl.SelectedIndex+1; i <= 81; i++)//İL Sayısı kadar döngü
                {
                    if (ilceler != null)//listeyi temizleme
                    {
                        ilceler.Clear();
                        ilceler_.Clear();
                    }
                    if (i <= 9)//9 dan küçük id li iller için yapılacaklar
                    {
                        il_ = driver.FindElement(By.XPath("//*[@id=0" + i + "]/a")).Text;
                        string[] il_2 = il_.Split(' ');
                        il = StringReplace(il_2[0].ToLower());
                        Il = il_2[0].ToUpper();
                        ilceler = driver.FindElements(By.XPath("//*[@id=0" + i + "]/ol/li/a")).ToList();//İlçe listesi
                        foreach (var item in ilceler)
                        {
                            ilceler_.Add(item.Text);
                        }
                        if (i== CmbIl.SelectedIndex + 1)
                        {
                           sayim = CmbIlce.SelectedIndex;
                        }
                        else
                        {
                            sayim = 0;
                        }
                        for (int j= sayim; j < ilceler.Count; j++)//İlçe sayısı kadar dönen döngü
                        {
                            string ilceyazisi = ilceler_[j].Replace(")", "(");//toplam ürünün bulunması
                            string[] yazi = ilceyazisi.Split('(');//yazıdaki sayının çekilmesi için bölünmesi
                            string[] ilce_ = ilceler_[j].Split(' ');//url bulmak için ilçeyi bulma
                            ilce = StringReplace(ilce_[0].ToLower());//ilçe
                           
                            Ilce = ilce_[0].ToUpper();//ilçe
                            string ToplamUrun_ = yazi[1];//Yazıdaki toplam ürün adedi
                            if (ToplamUrun_.Contains("."))
                            {
                                string[] SayiBirlestir = ToplamUrun_.Split('.');//Yazıyı istediğim biçimde birleştirmek için ayırdım
                                ToplamUrun_ = SayiBirlestir[0] + SayiBirlestir[1];//yazıyı tekrar birleştirdim
                                if (Convert.ToInt32(ToplamUrun_) % 20 == 0)
                                {
                                    sayfasayisi = (Convert.ToInt32(ToplamUrun_) / 20);
                                }
                                else
                                {
                                    sayfasayisi = (Convert.ToInt32(ToplamUrun_) / 20) + 1;//toplam sayfa sayısını buldum
                                }
                            }//sayıyı int e çevirme ToplamUrun_>999
                            else
                            {
                                if (Convert.ToInt32(ToplamUrun_) % 20 == 0)
                                { sayfasayisi = (Convert.ToInt32(ToplamUrun_) / 20); }
                                else
                                {
                                    sayfasayisi = (Convert.ToInt32(ToplamUrun_) / 20) + 1;//toplam sayfa sayısını buldum
                                }
                            }//ToplamUrun_<999"
                            try
                            {
                                yonlendirme = "https://www.find.com.tr/List/TumKategoriler/" + ilce + "-" + il + "?Page=" + 1;
                                driver.Navigate().GoToUrl(yonlendirme);
                                SayfaGez(Sayfa1, Sirketler);//Sayfa içerisinde bulunan şirketleri gezen fonksiyon
                                string sayfaurl2 = "https://www.find.com.tr/Search";
                                driver.Navigate().GoToUrl(sayfaurl2);
                            }
                            catch (Exception)
                            {
                                driver.Quit();
                                GirisYap(3000);
                                yonlendirme = "https://www.find.com.tr/List/TumKategoriler/" + ilce + "-" + il + "?Page=" + 1;
                                driver.Navigate().GoToUrl(yonlendirme);
                                SayfaGez(Sayfa1, Sirketler);//Sayfa içerisinde bulunan şirketleri gezen fonksiyon
                                string sayfaurl2 = "https://www.find.com.tr/Search";
                                driver.Navigate().GoToUrl(sayfaurl2);
                            }
                           
                           
                        }
                        
                    }
                    else
                    {//9 dan büyük id li iller için yapılacaklar
                        il_ = driver.FindElement(By.XPath("//*[@id=" + i + "]/a")).Text;
                        string[] il_2 = il_.Split(' ');
                        il = StringReplace(il_2[0].ToLower());
                        Il = il_2[0].ToUpper();
                        ilceler = driver.FindElements(By.XPath("//*[@id=" + i + "]/ol/li/a")).ToList();//İlçe listesi
                        foreach (var item in ilceler)
                        {
                            ilceler_.Add(item.Text);
                        }
                        if (i == CmbIl.SelectedIndex + 1)
                        {
                            sayim = CmbIlce.SelectedIndex;
                        }
                        else
                        {
                            sayim = 0;
                        }
                        for (int j = sayim; j < ilceler.Count; j++)//İlçe sayısı kadar dönen döngü
                        {
                            string ilceyazisi = ilceler_[j].Replace(")", "(");//toplam ürünün bulunması
                            string[] yazi = ilceyazisi.Split('(');//yazıdaki sayının çekilmesi için bölünmesi
                            string[] ilce_ = ilceler_[j].Split(' ');//url bulmak için ilçeyi bulma
                            ilce = StringReplace(ilce_[0].ToLower());//ilçe
                            Ilce = ilce_[0].ToUpper();//ilçe
                            string ToplamUrun_ = yazi[1];//Yazıdaki toplam ürün adedi
                            if (ToplamUrun_.Contains("."))
                            {
                                string[] SayiBirlestir = ToplamUrun_.Split('.');//Yazıyı istediğim biçimde birleştirmek için ayırdım
                                ToplamUrun_ = SayiBirlestir[0] + SayiBirlestir[1];//yazıyı tekrar birleştirdim
                                if (Convert.ToInt32(ToplamUrun_) % 20 == 0)
                                {
                                    sayfasayisi = (Convert.ToInt32(ToplamUrun_) / 20);
                                }
                                else
                                {
                                    sayfasayisi = (Convert.ToInt32(ToplamUrun_) / 20) + 1;//toplam sayfa sayısını buldum
                                }

                            }//sayıyı int e çevirme ToplamUrun_>999
                            else//ToplamUrun_<999
                            {
                                if (Convert.ToInt32(ToplamUrun_) % 20 == 0)
                                { sayfasayisi = (Convert.ToInt32(ToplamUrun_) / 20); }
                                else
                                {
                                    sayfasayisi = (Convert.ToInt32(ToplamUrun_) / 20) + 1;//toplam sayfa sayısını buldum
                                }
                            }
                            try
                            {
                                yonlendirme = "https://www.find.com.tr/List/TumKategoriler/" + ilce + "-" + il + "?Page=" + 1;
                                driver.Navigate().GoToUrl(yonlendirme);
                                SayfaGez(Sayfa1, Sirketler);//Sayfa içerisinde bulunan şirketleri gezen fonksiyon
                                string sayfaurl2 = "https://www.find.com.tr/Search";
                                driver.Navigate().GoToUrl(sayfaurl2);
                            }
                            catch (Exception)
                            {
                                driver.Quit();
                                GirisYap(3000);
                                yonlendirme = "https://www.find.com.tr/List/TumKategoriler/" + ilce + "-" + il + "?Page=" + 1;
                                driver.Navigate().GoToUrl(yonlendirme);
                                SayfaGez(Sayfa1, Sirketler);//Sayfa içerisinde bulunan şirketleri gezen fonksiyon
                                string sayfaurl2 = "https://www.find.com.tr/Search";
                                driver.Navigate().GoToUrl(sayfaurl2);
                            }
                            
                        }
                    }
                }
                SplashScreenManager.CloseForm();//Bekleme Efekti bitiş
            }
            
        }
        public void SayfaGez(Worksheet Sayfa1, Workbook Sirketler) {
            int baslangic = Convert.ToInt32(cmbSayfa.Text);
            if (sayfasayisi == 1)
            {
                if (sirketler != null)
                {
                    sirketler.Clear();
                    sirketler_.Clear();
                }
                sirketler = driver.FindElements(By.XPath("//html/body/div[3]/section/div/div[2]/div[2]/div/div[2]/div/div/div/div[2]/div/h2/a")).ToList();//Şirket listesi
                foreach (var item in sirketler)
                {
                    sirketler_.Add(item.Text);
                }
                sayac = 0;
                SirketSayisi = sirketler.Count;
                for (int k = 0; k < SirketSayisi; k++)//Şirket sayısı kadar dönen döngü
                {
                    try
                    {
                        ToplamSirketSayisi++;
                        Sirket sirket = new Sirket();// Sirket classı //Excele şirketleri eklemek için
                        sirketUrl = "https://www.find.com.tr/Company/" + StringReplace(sirketler_[sayac].ToLower());//Her şirketin url si
                        driver.Navigate().GoToUrl(sirketUrl);
                        sayac++;
                        try
                        {
                            VeriCek(sirket);//Sirketin Verilerini Çeken fonksiyon
                        }
                        catch (Exception)
                        {
                            sirket.SirketTel1 = "-";
                            sirket.SirketTel2 = "-";
                        }
                        if (sirket.SirketTel1 == "-" || sirket.SirketTel2 == "-" || sirket.SirketTel2.Contains("X")) { }//İşe yaramayan şirketlerin elenmesi
                        else
                        {
                            string no1 = "" + sirket.SirketTel1[0] + sirket.SirketTel1[1];//Şirket telefon no kontrolu
                            string no2 = "" + sirket.SirketTel2[0] + sirket.SirketTel2[1];//Şirket telefon no kontrolu
                            if (no1 == "05" || no2 == "05")//İşe yarayan şirketlerin alınması için kontrol
                            {
                                ExcelDoldur(sirket, Sayfa1, Sirketler);//Verileri excele aktaran fonksiyon
                            }
                        }
                    }
                    catch (Exception)
                    {
                        driver.Quit();
                        GirisYap(3000);
                        ToplamSirketSayisi++;
                      
                        Sirket sirket = new Sirket();// Sirket classı //Excele şirketleri eklemek için
                        sirketUrl = "https://www.find.com.tr/Company/" + StringReplace(sirketler_[sayac].ToLower());//Her şirketin url si
                        driver.Navigate().GoToUrl(sirketUrl);
                        sayac++;
                        try
                        {
                            VeriCek(sirket);//Sirketin Verilerini Çeken fonksiyon
                        }
                        catch (Exception)
                        {
                            sirket.SirketTel1 = "-";
                            sirket.SirketTel2 = "-";
                        }
                        if (sirket.SirketTel1 == "-" || sirket.SirketTel2 == "-" || sirket.SirketTel2.Contains("X")) { }//İşe yaramayan şirketlerin elenmesi
                        else
                        {
                            string no1 = "" + sirket.SirketTel1[0] + sirket.SirketTel1[1];//Şirket telefon no kontrolu
                            string no2 = "" + sirket.SirketTel2[0] + sirket.SirketTel2[1];//Şirket telefon no kontrolu
                            if (no1 == "05" || no2 == "05")//İşe yarayan şirketlerin alınması için kontrol
                            {
                                ExcelDoldur(sirket, Sayfa1, Sirketler);//Verileri excele aktaran fonksiyon
                            }
                        }
                    }
                    
                }

            }
            else if (sayfasayisi == 2)// 2 sayfa olunca yapılacaklar
            {
                if (sayfaKontrol==false)
                {
                    Sayfa2Baslangic = baslangic;
                    sayfaKontrol = true;
                    sayfaKontrol2 = true;
                }
                else
                {
                     Sayfa2Baslangic =1;
                }
                for (int m = Sayfa2Baslangic; m <= sayfasayisi; m++)
                {
                    if (sirketler != null)
                    {
                        sirketler.Clear();
                        sirketler_.Clear();
                    }
                     sirketler = driver.FindElements(By.XPath("//html/body/div[3]/section/div/div[2]/div[2]/div/div[2]/div/div/div/div[2]/div/h2/a")).ToList();//Şirket listesi
                    foreach (var item in sirketler)//şirket adlarını bi arraye alma
                    {
                        sirketler_.Add(item.Text);
                    }
                    sayac = 0;
                    for (int t = 0; t < sirketler.Count; t++)//şirket sayısı kadar döngü
                    {
                        try
                        {
                            ToplamSirketSayisi++;
                            
                            Sirket sirket = new Sirket();//Yeni şirket nesnesi
                            sirketUrl = "https://www.find.com.tr/Company/" + StringReplace(sirketler_[sayac].ToLower());//Her şirketin url si
                            driver.Navigate().GoToUrl(sirketUrl);
                            sayac++;
                            try
                            {
                                VeriCek(sirket);//Sirketin Verilerini Çeken fonksiyon
                            }
                            catch (Exception)
                            {
                                sirket.SirketTel1 = "-";
                                sirket.SirketTel2 = "-";
                            }
                            if (sirket.SirketTel1 == "-" || sirket.SirketTel2 == "-" || sirket.SirketTel2.Contains("X")) { }
                            else
                            {
                                string no1 = "" + sirket.SirketTel1[0] + sirket.SirketTel1[1];//Şirket telefon no kontrolu
                                string no2 = "" + sirket.SirketTel2[0] + sirket.SirketTel2[1];//Şirket telefon no kontrolu
                                if (no1 == "05" || no2 == "05")//İşe yarayan şirketlerin alınması için kontrol
                                {
                                    ExcelDoldur(sirket, Sayfa1, Sirketler);//Verileri excele aktaran fonksiyon
                                }
                            }
                        }
                        catch (Exception)
                        {
                            driver.Quit();
                            GirisYap(3000);
                            ToplamSirketSayisi++;
                         
                            Sirket sirket = new Sirket();//Yeni şirket nesnesi
                            sirketUrl = "https://www.find.com.tr/Company/" + StringReplace(sirketler_[sayac].ToLower());//Her şirketin url si
                            driver.Navigate().GoToUrl(sirketUrl);
                            sayac++;
                            try
                            {
                                VeriCek(sirket);//Sirketin Verilerini Çeken fonksiyon
                            }
                            catch (Exception)
                            {
                                sirket.SirketTel1 = "-";
                                sirket.SirketTel2 = "-";
                            }
                            if (sirket.SirketTel1 == "-" || sirket.SirketTel2 == "-" || sirket.SirketTel2.Contains("X")) { }
                            else
                            {
                                string no1 = "" + sirket.SirketTel1[0] + sirket.SirketTel1[1];//Şirket telefon no kontrolu
                                string no2 = "" + sirket.SirketTel2[0] + sirket.SirketTel2[1];//Şirket telefon no kontrolu
                                if (no1 == "05" || no2 == "05")//İşe yarayan şirketlerin alınması için kontrol
                                {
                                    ExcelDoldur(sirket, Sayfa1, Sirketler);//Verileri excele aktaran fonksiyon
                                }
                            }
                        }
                    }
                    Thread.Sleep(200);
                    if (m == 1)//Sayfa Değiştirme işlemi
                    {
                        try
                        {
                            string url = "https://www.find.com.tr/List/TumKategoriler/" + ilce + "-" + il + "?Page=2";//Sayfa Değiştirme urlsi
                            driver.Navigate().GoToUrl(url);
                        }
                        catch (Exception)
                        {
                            driver.Quit();
                            GirisYap(4000);
                            string url = "https://www.find.com.tr/List/TumKategoriler/" + ilce + "-" + il + "?Page=2";//Sayfa Değiştirme urlsi
                            driver.Navigate().GoToUrl(url);
                        }
                       
                    }
                }
            }
            else
            {
                if (sayfaKontrol2==false)
                {
                 CokSayfa = baslangic;
                 sayfaKontrol2 = true;
                 sayfaKontrol = true;
                }
                else
                {
                    CokSayfa = 1;
                }
                for (int a = CokSayfa; a <= sayfasayisi; a++)
                {
                    if (sirketler != null)
                    {
                        sirketler.Clear();
                        sirketler_.Clear();
                    }
                    sirketler = driver.FindElements(By.XPath("//html/body/div[3]/section/div/div[2]/div[2]/div/div[2]/div/div/div/div[2]/div/h2/a")).ToList();//Şirket listesi
                    foreach (var item in sirketler)
                    {
                        sirketler_.Add(item.Text);
                    }

                    sayac = 0;
                    for (int z = 0; z < sirketler.Count; z++)//Şirket sayısı kadar dönen döngü
                    {
                        ToplamSirketSayisi++;
                       
                        try
                        {
                            Sirket sirket = new Sirket();
                            sirketUrl = @"https://www.find.com.tr/Company/" + StringReplace(sirketler_[sayac].ToLower());//Her şirketin url si
                            driver.Navigate().GoToUrl(sirketUrl);

                            sayac++;
                            try
                            {
                                VeriCek(sirket);//Sirketin Verilerini Çeken fonksiyon
                            }
                            catch (Exception)
                            {
                                sirket.SirketTel1 = "-";
                                sirket.SirketTel2 = "-";
                            }
                            if (sirket.SirketTel1 == "-" || sirket.SirketTel2 == "-" || sirket.SirketTel2.Contains("X")) { }
                            else
                            {
                                string no1 = "" + sirket.SirketTel1[0] + sirket.SirketTel1[1];//Şirket telefon no kontrolu
                                string no2 = "" + sirket.SirketTel2[0] + sirket.SirketTel2[1];//Şirket telefon no kontrolu
                                if (no1 == "05" || no2 == "05")//İşe yarayan şirketlerin alınması için kontrol
                                {
                                    ExcelDoldur(sirket, Sayfa1, Sirketler);//Verileri excele aktaran fonksiyon
                                }

                            }
                        }
                        catch (Exception)
                        {
                            driver.Quit();
                            GirisYap(3000);
                            Sirket sirket = new Sirket();
                            sirketUrl = @"https://www.find.com.tr/Company/" + StringReplace(sirketler_[sayac].ToLower());//Her şirketin url si
                            driver.Navigate().GoToUrl(sirketUrl);
                            sayac++;
                            try
                            {
                                VeriCek(sirket);//Sirketin Verilerini Çeken fonksiyon
                            }
                            catch (Exception)
                            {
                                sirket.SirketTel1 = "-";
                                sirket.SirketTel2 = "-";
                            }
                            if (sirket.SirketTel1 == "-" || sirket.SirketTel2 == "-" || sirket.SirketTel2.Contains("X")) { }
                            else
                            {
                                string no1 = "" + sirket.SirketTel1[0] + sirket.SirketTel1[1];//Şirket telefon no kontrolu
                                string no2 = "" + sirket.SirketTel2[0] + sirket.SirketTel2[1];//Şirket telefon no kontrolu
                                if (no1 == "05" || no2 == "05")//İşe yarayan şirketlerin alınması için kontrol
                                {
                                    ExcelDoldur(sirket, Sayfa1, Sirketler);//Verileri excele aktaran fonksiyon
                                }

                            }
                            continue;
                        }
                    }
                    if (a != sayfasayisi)//Sayfa Değiştirme işlemi
                    {
                        try
                        {
                            string sayfaurl = "https://www.find.com.tr/List/TumKategoriler/" + ilce + "-" + il + "?Page=" + (a + 1);//Sayfa Değiştirme urlsi
                            driver.Navigate().GoToUrl(sayfaurl);
                        }
                        catch (Exception)
                        {
                            driver.Quit();
                            GirisYap(100);
                            string sayfaurl = "https://www.find.com.tr/List/TumKategoriler/" + ilce + "-" + il + "?Page=" + (a + 1);//Sayfa Değiştirme urlsi
                            driver.Navigate().GoToUrl(sayfaurl);
                        }
                        
                    }
                    
                }
            }
        }
        public void ExcelDoldur(Sirket sirket,Worksheet sayfa1, Workbook Sirketler)//Şirketleri excel tablosuna aktarmak için kullanılan fonksiyon
        {
                sutunAdlari.Add("İl");//il kolonu
                sutunAdlari.Add("İlçe");//İlçe kolonu
                sutunAdlari.Add("Şirket Sektör");//Sektor kolonu
                sutunAdlari.Add("Şirket Alt Sektör");//Alt sektor kolonu
                sutunAdlari.Add("Şirket Adı");//Şirket Adı kolonu
                sutunAdlari.Add("Şirket Tel - 1");//Şirket Tel kolonu
                sutunAdlari.Add("Şirket Tel-2");//Şirket Tel kolonu
                sutunAdlari.Add("Şirket Mail");//Mail kolonu
                sutunAdlari.Add("Şirket WebSite");//WebSite kolonu
                sutunAdlari.Add("Şirket Adresi");//Adresi kolonu
                sutunAdlari.Add("Şirket Açıklaması");//Şirket Açıklaması kolonu
                if (satir == 1)//Excel için ilk sütunları doldurma işlemi
                {
                    for (int s = 0; s < 11; s++)
                    {
                        Range rangeSutun = (Range)sayfa1.Cells[satir, sutun + s];//Sutun Atlama işlemi
                        rangeSutun.Value = sutunAdlari[s];//Sutun adlarını doldurma işlemi
                    }
                    satir++;
                }
                Range range = (Range)sayfa1.Cells[satir, 1];//Sutun Atlama işlemi
                range.Value = Il;//şirketin bulundugu ilin eklenmesi
                range = (Range)sayfa1.Cells[satir, 2];//Sutun Atlama işlemi
                range.Value = Ilce;//şirketin bulundugu Ilcenin eklenmesi
                range = (Range)sayfa1.Cells[satir, 3];//Sutun Atlama işlemi
                range.Value = sirket.SirketSektor;//Şirket sektörünün eklenmesi
                range = (Range)sayfa1.Cells[satir, 4];//Sutun Atlama işlemi
                range.Value = sirket.SirketAltSektor;//Şirket alt sektörünün eklenmesi
                range = (Range)sayfa1.Cells[satir, 5];//Sutun Atlama işlemi
                range.Value = sirket.SirketAdi;//Şirket adının eklenmesi
                range = (Range)sayfa1.Cells[satir, 6];//Sutun Atlama işlemi
                 if (sirket.SirketTel1== "00")
                 {
                range.Value = "-";
                 }
                 else
                 {
                range.Value = sirket.SirketTel1;//Şirket telinin eklenmesi;
                 }
                range = (Range)sayfa1.Cells[satir, 7];//Sutun Atlama işlemi
                range.Value = sirket.SirketTel2;//Şirket telinin eklenmesi
                range = (Range)sayfa1.Cells[satir, 8];//Sutun Atlama işlemi
                range.Value = sirket.SirketMail;//Şirket mailinin eklenmesi
                range = (Range)sayfa1.Cells[satir, 9];//Sutun Atlama işlemi
                range.Value = sirket.SirketSite;//Şirket sitesinin eklenmesi
                range = (Range)sayfa1.Cells[satir, 10];//Sutun Atlama işlemi
                range.Value = sirket.SirketAdresi;//Şirket Adresinin eklenmesi
                range = (Range)sayfa1.Cells[satir, 11];//Sutun Atlama işlemi
                range.Value = sirket.SirketAciklama;//Şirket açıklamasının eklenmesi
                satir++;
                Sirketler.Save();//Eklenenlerin Kaydedilmesi
            }
    }
}
