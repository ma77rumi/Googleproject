using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_Console
{
    public class Validation_Practice
    {
        public void clickElements()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.flipkart.com/";
            driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2doB4z']")).Click();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            //validate menu items in home page

            IWebElement topOffers = driver.FindElement(By.XPath("//*[text()='Top Offers']"));
            IJavaScriptExecutor ps = (IJavaScriptExecutor)driver;
            ps.ExecuteScript("arguments[0].click()", topOffers);
            Thread.Sleep(3000);
            
            //validate mouse hover functionality in electronics
          IWebElement elect = driver.FindElement(By.XPath("//*[contains(text(),'Electronics')]"));
            Actions act = new Actions(driver);
            act.MoveToElement(elect);
            act.Build().Perform();
            IWebElement camera = driver.FindElement(By.XPath("//*[contains(text(),'Samsung')]"));
            camera.Click();

            // validate search functinality
            IWebElement search = driver.FindElement(By.Name("q"));
            //ps.ExecuteScript("arguments[0].value=arguments[1]", search, "iPhone");
            // Question, How can we use Search button OR Enter key using JavaScriptExcutor???

            search.SendKeys("iPhone");//
            search.SendKeys(Keys.Enter);

            // validate item name price cart
            driver.FindElement(By.XPath("//*[text()='APPLE iPhone 11 (Black, 64 GB)']")).Click();
            string parentWindow = driver.CurrentWindowHandle;
            IList<string> win = driver.WindowHandles;
            string childWindow = win[1];

            driver.SwitchTo().Window(childWindow);
            driver.FindElement(By.XPath("//*[text()='ADD TO CART']")).Click();

            // Validate + and - functionality
            driver.FindElement(By.XPath("(//button[@class='_23FHuj'])[2]")).Click();

            // How can I add more than 1 item in my cart by using for loop
            driver.FindElement(By.XPath("(//button[@class='_23FHuj'])[2]")).Click();
            //driver.FindElement(By.XPath("(//button[@class='_23FHuj'])[1]"));

            // Validate Remove link functionality
            driver.FindElement(By.XPath("//*[text()='Remove']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[text()='Cancel']")).Click();

            driver.Close();
            driver.SwitchTo().Window(parentWindow);

            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys("women dresses");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);


        }
    }
}