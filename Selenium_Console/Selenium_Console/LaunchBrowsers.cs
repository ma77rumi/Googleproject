using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_Console
{
    public class LaunchBrowsers
    {
        public void LaunchBrowserChrome()
        {
            // Launch chrome browser
            // IWebDriver driver= new ChromeDriver(@"C:\Users\Biplab\Downloads\chromedriver_win32");
            
            IWebDriver driver = new ChromeDriver();

            //Implicit wait
            //This is global time, once you decalre then same applicable for all user actions.

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);


            //Explicit wait
            // Explicit wait for applicable for particular element, based conditions.
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));


            //Fluent wait
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);//line1
            /* Ignore the exception - NoSuchElementException that indicates that the element is not present */
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));//line 2
            fluentWait.Message = "Element to be searched not found";

            //Navigate Url
            driver.Url = "https://www.google.com";

            //Maximize the browser
            driver.Manage().Window.Maximize();

            IWebElement ele= driver.FindElement(By.Name("q"));//40
            //IWebElement ele = driver.FindElement(By.XPath("//input[@type='text' and @title='Search']"));
            ele.SendKeys("Selenium");

            //IWebElement ele1 = driver.FindElement(By.LinkText("Sign in"));//.Click();
            // IWebElement ele1 = driver.FindElement(By.PartialLinkText("Sign"));
            IWebElement ele1 = driver.FindElement(By.XPath("//*[text()='Sign in']"));
            ele1.Click();

            IWebElement createAcct = driver.FindElement(By.XPath("//*[text()='Create account']"));
            createAcct.Click();
            //Thread.Sleep(2000);

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[text()='For myself']")));
            
            IWebElement forMyself = driver.FindElement(By.XPath("//*[text()='For myself']"));
            forMyself.Click();

            //Thread.Sleep(3000);//3 sec

            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("firstName")));
            IWebElement firstNa = driver.FindElement(By.Id("firstName"));
            //IWebElement firstName = driver.FindElement(By.XPath("//input[@name='firstName']"));
            firstNa.SendKeys("Masuma");
            IWebElement lastName = driver.FindElement(By.XPath("//input[@name='lastName']"));
            lastName.SendKeys("Mahmud");
            IWebElement userName = driver.FindElement(By.XPath("//input[@type='email']"));
            userName.SendKeys("masumam758");
            IWebElement passWord = driver.FindElement(By.Name("Passwd"));
            passWord.SendKeys("123456");

            IWebElement conpassWord = driver.FindElement(By.Name("ConfirmPasswd"));
            conpassWord.SendKeys("123456");
            IWebElement checkBox = driver.FindElement(By.XPath("//input[@type='checkbox']"));
            checkBox.Click();

           

            //fluentWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("firstName")));

            //driver.Quit();
        }
    }
}
