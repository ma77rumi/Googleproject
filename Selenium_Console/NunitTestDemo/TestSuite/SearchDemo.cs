using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NunitTestDemo.Base;
using NunitTestDemo.Repository;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NunitTestDemo.Tests
{
    [TestFixture]
    public class SearchDemo : BaseEngine
    {
        /*
           IWebDriver driver;
           AventStack.ExtentReports.ExtentReports report;

          [OneTimeSetUp]
           public void OneTimeSetup()
           {
               ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(@"C:\Users\Biplab\OneDrive\Documents\ExtentReport\report.html");

               report = new AventStack.ExtentReports.ExtentReports();
               report.AttachReporter(htmlReport);
           }

           [OneTimeTearDown]
           public void OneTimeTearDown()
           {
               report.Flush();
           }
           [SetUp]
           public void Setup()
           {
               BrowserFactory factory = new BrowserFactory();
               driver = factory.LaunchBrowser();
           }
           [TearDown]
           public void TearDown()
           {
               driver.Quit();
           }*/

        [Test]
        public void Search()
        {
            ExtentTest test = report.CreateTest("Search");
            //driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            //driver.Url = "https://www.flipkart.com";
            BrowserActions actions = new BrowserActions();


            actions.NavigateUrl(driver, test);



            //actions.ClickElement(driver, By.XPath("//button[@class='_2KpZ6l _2doB4z']"));
            actions.ClickElement(driver, By.XPath("//button[@class='_2KpZ6l _2doB4z']"), "close icon", test);

            //driver.FindElement(By.Name("q")).SendKeys("iPhone");
            actions.EnterText(driver, By.Name("q"), "iPhone", "Search field", test);
            actions.PressEnterKey(driver, By.Name("q"));

            //driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2doB4z']")).Click();
            //driver.Manage().Window.Maximize();

            //driver.FindElement(By.Name("q")).SendKeys("iPhone");
            //driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            IList<IWebElement> iphones = driver.FindElements(By.XPath("//div[@class='_4rR01T']"));

            foreach (IWebElement iphone in iphones)
            {
                if (iphone.Text.Contains("iPhone"))
                {
                    Console.WriteLine("Search functionality working as expected " + iphone.Text);
                }
                else
                {
                    Console.WriteLine("Search functionality not working as expected " + iphone.Text);
                }
            }

            //HomePage homePage = new HomePage();
            //homePage.ValidateSearchFunctionality(driver);
        }

        [Test]
        public void AddItemTocart()
        {
            ExtentTest test = report.CreateTest("AddItemTocart");
            BrowserActions actions = new BrowserActions();
            actions.NavigateUrl(driver, test);

            //actions.ClickElement(driver, By.XPath("//button[@class='_2KpZ6l _2doB4z']"));
            actions.ClickElement(driver, By.XPath("//button[@class='_2KpZ6l _2doB4z']"), "close icon", test);
            //Thread.Sleep(2000);
            actions.EnterText(driver, By.Name("q"), "iPhone", "Search field", test);
            actions.PressEnterKey(driver, By.Name("q"));
            //Thread.Sleep(2000);
            actions.ClickElement(driver, By.XPath("//div[@class='_4rR01T']"), "select mobile", test);
            //Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            actions.ClickElement(driver, By.XPath("//*[text()='ADD TO CART']"), "Add to cart", test);

            Thread.Sleep(5000);
            /*if(driver.FindElement(By.XPath("//a[@class='_2Kn22P gBNbID']")).Displayed)
            {
                Console.WriteLine("Successfully item added to cart");
            }
            else
            {
                Console.WriteLine("Failure to add item to cart");
            }

            Assert.IsTrue(driver.FindElement(By.XPath("//a[@class='_2Kn22P gBNbID123']")).Displayed);
        }*/
            actions.DisplayDemo(driver);

        }
    }
}
