using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTestDemo.Base
{
    public class BrowserFactory
    {

        public IWebDriver LaunchBrowser()
        {
           IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            return driver;
        }
    }
}
