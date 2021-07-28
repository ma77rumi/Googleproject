using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestProj
{
    class BrowserFactory
    {
        public IWebDriver launchBrowser()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }
    }
}
