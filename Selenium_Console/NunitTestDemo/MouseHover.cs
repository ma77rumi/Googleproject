using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTestDemo
{
    class MouseHover
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
            public void MouseHover1()
            {
                driver.FindElement(By.XPath("//*[text()='Electronics']"));
                IWebElement electr = driver.FindElement(By.XPath("//*[text()='Electronics']"));

                Actions act = new Actions(driver);
                act.MoveToElement(electr);
                act.Build().Perform();
            }
        }
    }
}
