using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageFactoryDemo
{
    class CreateAccountPage
    {
        private IWebDriver driver;


        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement txt_firstname { get; set; }


        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement txt_lastName { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement txt_username { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='Passwd']")]
        public IWebElement txt_password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ConfirmPasswd']")]
        public IWebElement txt_confirmpassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@jsname='CeL6Qc']")]
        public IWebElement txt_showpassword { get; set; }

        [FindsBy(How = How.XPath, Using = " //div[@jsname='V67aGc']")]
        public IWebElement txt_next { get; set; }



       


    }
}
