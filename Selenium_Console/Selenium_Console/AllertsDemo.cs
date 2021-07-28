using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Console
{
    public class AllertsDemo
    {
        public void HandleAllerts()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/test/delete_customer.php";
            driver.Manage().Window.Maximize();

            //driver.FindElement(By.Name("cusid")).SendKeys("100");
            //driver.FindElement(By.Name("submit")).Click();


            //string text  =driver.SwitchTo().Alert().Text;
            //Console.WriteLine(text);
            //Ok
            //driver.SwitchTo().Alert().Accept();
            //driver.SwitchTo().Alert().Accept();
            //Cancel
            //driver.SwitchTo().Alert().Dismiss();


        }
    }
}
