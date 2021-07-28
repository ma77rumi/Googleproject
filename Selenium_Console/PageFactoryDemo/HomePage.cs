using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageFactoryDemo
{
   public class HomePage
    {
       
        private IWebDriver driver;

       
        [FindsBy(How = How.LinkText, Using= "Sign in")]
        public IWebElement btn_SignIn { get; set; }
    }
}
