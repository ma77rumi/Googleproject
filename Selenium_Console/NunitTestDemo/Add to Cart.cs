using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NunitTestDemo
{
    class Add_to_Cart
    {
        [TestFixture]
        public class Testsearch
        {
            IWebDriver driver;
            [SetUp]
            public void testSearch()
            {
                driver = new OpenQA.Selenium.Chrome.ChromeDriver();
                driver.Url = "https://www.flipkart.com";
                driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2doB4z']")).Click();
                driver.Manage().Window.Maximize();

            }
            [TearDown]
            public void testCleanup()
            {
                //driver.Quit();
            }
            [Test]
            public void addtocart()
            {
                driver.FindElement(By.Name("q")).SendKeys("mobiles");
                driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//div[@class='_4rR01T']")).Click();
                driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2U9uOA _3v1-ww']")).Click();
            }
        }
    }
}
