using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestProj
{
    [TestClass]
    public class GoogleTest
    {
        IWebDriver driver;

       [TestInitialize]
        public void BeforeMethod()
        {
            driver = new ChromeDriver();
            driver.Url = "https://google.com";
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void AfterMethod()
        {
            driver.Quit();
        }

        [TestMethod]
        public void GoogleSearch()
        {         

            driver.FindElement(By.Name("q")).SendKeys("Selenium");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            string text = driver.FindElement(By.XPath("//h3[@class='LC20lb DKV0Md']")).Text;
            if (text.Contains("Selenium"))
            {
                Console.WriteLine("Search functionality working as expected");
            }
            else{
                Console.WriteLine("Search functionality not working as expected");
            }

            
        }

        [TestMethod]
        public void GoogleSearch1()
        {

            driver.FindElement(By.Name("q")).SendKeys("Selenium");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            string text = driver.FindElement(By.XPath("//h3[@class='LC20lb DKV0Md']")).Text;
            if (text.Contains("Selenium"))
            {
                Console.WriteLine("Search functionality working as expected");
            }
            else
            {
                Console.WriteLine("Search functionality not working as expected");
            }


        }
    }
}
