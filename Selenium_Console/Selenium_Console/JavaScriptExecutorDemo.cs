using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Console
{
    public class JavaScriptExecutorDemo
    {
        public void clickElement()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Url = "https://www.google.com";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            //driver.FindElement(By.LinkText("Sign in")).Click();
            //driver.FindElement(By.Id("identifierId")).SendKeys("abc@yahoo.com");
            IWebElement signIn = driver.FindElement(By.LinkText("Sign in"));
            //signIn.Click();
            //Click element using javascript executor
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", signIn);

            //Send keys using java script executor
            IWebElement email = driver.FindElement(By.Id("identifierId"));
            js.ExecuteScript("arguments[0].value=arguments[1]", email,"abctest@gmail.com");
        }
    }
}
