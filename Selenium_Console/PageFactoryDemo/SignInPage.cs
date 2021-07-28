using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageFactoryDemo
{
    class SignInPage
    {
        private IWebDriver driver;


        [FindsBy(How = How.XPath, Using = "//*[text()='Create account']")]
        public IWebElement lnk_create { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[text()='For myself']")]
        public IWebElement lnk_MySelf { get; set; }
        
    }

}
