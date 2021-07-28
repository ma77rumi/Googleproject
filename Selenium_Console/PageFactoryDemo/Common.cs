using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageFactoryDemo
{
    public class Common
    {
        public IWebDriver LaunchBrowser()
        {
            IWebDriver driver = new ChromeDriver();            
            return driver;
        }
        
      public void NavigateURL(IWebDriver driver)
        {
            driver.Url = "https://google.com";
        }

        public void Click_obj(IWebElement element, string msg)
        {
            try
            {
                element.Click();
                Console.WriteLine("Successfully click element "+msg);
            }
            catch
            {
                //FAilure log
                Console.WriteLine("Failure click element");
            }
            
        }

        public void EnterText(IWebElement element, string input, string msg)
        {
            try
            {
                element.SendKeys(input);
                Console.WriteLine("Successfully enter text "+msg);
            }
            catch
            {
                Console.WriteLine("Failure to enter text "+msg);
            }
           
        }
    }
}
