using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelenıumWinform
{
    public class Sirket
    {
        public string SirketSektor { get; set; }
        public List<IWebElement> SirketAltSektorler { get; set; }
        public List<IWebElement> SirketSektorler { get; set; }
        public string SirketAltSektor { get; set; }
        public string SirketAdi { get; set; }
        public string SirketAciklama { get; set; }
        public string SirketAdresi { get; set; }
        public string SirketTel1{ get; set; }
        public string SirketTel2 { get; set; }
        public string SirketMail { get; set; }
        public string SirketSite { get; set; }

    }
}

