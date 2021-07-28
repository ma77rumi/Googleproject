using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_Console
{
    public class HandleDropDowns
    {
        public void DropDown()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            driver.Url = "http://demo.guru99.com/test/newtours/register.php";
            //3 wasy to handle dropdowns
            //1. By index
            //2. By Value
            //3. By Text

            IWebElement country = driver.FindElement(By.Name("country"));

           
            SelectElement select = new SelectElement(country);

            //1. By index
            select.SelectByIndex(1);
            Thread.Sleep(10000);
            //2. By Value
            select.SelectByValue("AMERICAN SAMOA");
            Thread.Sleep(10000);

            //3. By Text
            select.SelectByText("ARGENTINA");
        }
    } 
}
