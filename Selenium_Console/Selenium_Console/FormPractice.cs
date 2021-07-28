using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_Console
{
    public class FormPractice
    {
        public void HandleForm()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/automation-practice-form";
            driver.Manage().Window.Maximize();

           IWebElement ele = driver.FindElement(By.Id("firstName"));
                       ele.SendKeys("Smith");
            string  value =ele.GetAttribute("value");

            string placeholder = ele.GetAttribute("placeholder");
            Console.WriteLine(placeholder);

            Thread.Sleep(3000);
            IWebElement gender = driver.FindElement(By.Name("gender"));
            bool b = gender.Selected;
            Console.WriteLine(b);//false

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//label[@for='gender-radio-1']")).Click();

            bool bb= gender.Selected;
            Console.WriteLine(bb);//true
        }
    }
}
