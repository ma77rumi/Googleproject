using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTestDemo
{
    class Validate_search_functionality
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
            public void testSearch1()
            {
                driver.FindElement(By.Name("q")).SendKeys("mobiles");
                driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            }
            [Test]
            public void MouseHover1()
            {
                driver.FindElement(By.XPath("//*[text()='Electronics']"));
                IWebElement electr = driver.FindElement(By.XPath("//*[text()='Electronics']"));

                Actions act = new Actions(driver);
                act.MoveToElement(electr);
                act.Build().Perform();

                            }
            public void addtocart()
            {
                driver.FindElement(By.XPath("//*[text()='realme C21 (Cross Black, 32 GB)']")).Click();
                driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2U9uOA _3v1-ww']")).Click();
            }
        }
    }
}
