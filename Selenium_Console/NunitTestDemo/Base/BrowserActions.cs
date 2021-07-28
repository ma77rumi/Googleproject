using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTestDemo.Base
{
    public class BrowserActions
    {
        public void NavigateUrl(IWebDriver driver, ExtentTest test)
        {
            try
            {
                driver.Url = "https://www.flipkart.com";
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                Console.WriteLine("Successfully navigate url");
                test.Log(Status.Pass, "Successfully navigate url");
            }
            catch
            {
                Console.WriteLine("Failure to navigate url");
                test.Log(Status.Fail, "Failure to navigate url");
            }
            
        }

        public void ClickElement(IWebDriver driver, By locator,string msg, ExtentTest test)
        {
            try
            {
                WaitForEle(driver, locator);
                driver.FindElement(locator).Click();
                Console.WriteLine("Successfully click element "+msg);
                test.Log(Status.Pass, "Successfully click element " + msg);
            }
            catch
            {
                Console.WriteLine("Failure to click element "+msg);
                test.Log(Status.Fail, "Failure to click element " + msg);
            }
            
        }

        public void EnterText(IWebDriver driver, By locator, string input, string msg, ExtentTest test)
        {
            try
            {
                WaitForEle(driver, locator);
                driver.FindElement(locator).SendKeys(input);
                Console.WriteLine("Successfully enter text "+msg);
                test.Log(Status.Pass, "Successfully enter text " + msg);
            }
            catch
            {
                Console.WriteLine("Failure enter text "+msg);
                test.Log(Status.Fail, "Failure enter text " + msg);
            }
            
        }
        public void WaitForEle(IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch
            {
               ///? Where is the catch option ?
            }

        }

        public void PressEnterKey(IWebDriver driver, By locator)
        {
            try
            {
                driver.FindElement(locator).SendKeys(Keys.Enter);
                Console.WriteLine("Successfully press enter button");
            }
            catch
            {
                Console.WriteLine("Failure to press enter button");
            }
            
        }

        public void DisplayDemo(IWebDriver driver)
        {
            if (driver.FindElement(By.XPath("//a[@class='_2Kn22P gBNbID']")).Displayed)
            {
                Console.WriteLine("Successfully item added to cart");
            }
            else
            {
                Console.WriteLine("Failure to add item to cart");
            }

            Assert.IsTrue(driver.FindElement(By.XPath("//a[@class='_2Kn22P gBNbID123']")).Displayed);
        }
    }
    }

