using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Console
{
    class Megabus
    {
        public void MBus()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Url = "https://us.megabus.com/account-management/login";
            IWebElement signup = driver.FindElement(By.XPath("(//*[text()=' Sign up '])[1]"));
            signup.Click();
            // email 
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("ma77rumi@gmail.com");

            IWebElement conemail = driver.FindElement(By.Id("confirmEmail"));
            conemail.SendKeys("ma77rumi@gmail.com");
            IWebElement cpasswd = driver.FindElement(By.Id("choosePassword"));
            cpasswd.SendKeys("Bangladesh2020");
            IWebElement conpasswd = driver.FindElement(By.Id("confirmPassword"));
            conpasswd.SendKeys("Bangladesh2020");
            IWebElement checkbox = driver.FindElement(By.XPath("//label[@for='termsAndPrivacy']"));
            checkbox.Click();
        }
    }
}
            

            


    
        
    
    

