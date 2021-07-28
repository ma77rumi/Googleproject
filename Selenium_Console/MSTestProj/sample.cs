using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestProj
{
    [TestClass]
    public class sample
    {
        IWebDriver driver=null;
        [TestMethod]
        public void SampleTest()
        {
            BrowserFactory br = new BrowserFactory();
            driver = br.launchBrowser();
            //IWebDriver driver = new ChromeDriver();

            BrowserActions ba = new BrowserActions();
            ba.NavigateUrl(driver);

            //driver.Url = "https://www.flipkart.com";
            //driver.Manage().Window.Maximize();

            By locator = By.XPath("//button[@class='_2KpZ6l _2doB4z']");
            ba.ClickObj(driver, locator);
            //driver.FindElement(locator).Click();

            By search = By.Name("q");
            ba.EnterText(driver, search, "Mobile");

            By searchClick = By.XPath("//body/div[@id='container']/div[1]/div[1]/div[1]/div[2]/div[2]/form[1]/div[1]/button[1]/*[1]");
            ba.ClickObj(driver, searchClick);
           
        }
    }
}
   
