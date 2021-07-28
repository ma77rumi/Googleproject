using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NunitTestDemo
{
    [TestFixture]
    public class Tests1
    {
        IWebDriver driver;

        [SetUp]
        public void testInit()
        {
            driver = new ChromeDriver();
            driver.Url = "https://google.com";
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void testCleanup()
        {
            driver.Quit();
        }

        [Test]
        public void Test1()
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