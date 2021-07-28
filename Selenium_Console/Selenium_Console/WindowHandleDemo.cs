using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Console
{
    public class WindowHandleDemo
    {
        public void WindowHandleTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            driver.Url = "https://www.flipkart.com";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2doB4z']")).Click();

            driver.FindElement(By.Name("q")).SendKeys("Mobile");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            string parentWindow = driver.CurrentWindowHandle;
            

            IList<string> windows = driver.WindowHandles;

           string childWindow = windows[1];

            driver.SwitchTo().Window(childWindow);

            driver.FindElement(By.XPath("//*[text()='ADD TO CART']")).Click();
            driver.Close();

            driver.SwitchTo().Window(parentWindow);

          







        }
    }
}
