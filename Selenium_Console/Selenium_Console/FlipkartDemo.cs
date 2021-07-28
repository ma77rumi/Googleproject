using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Console
{
    public class FlipkartDemo
    {
        public void MouseHoverDemo()
        {
            IWebDriver driver = new ChromeDriver();
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            driver.Url = "https://www.flipkart.com";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2doB4z']")).Click();
           IWebElement fashion =  driver.FindElement(By.XPath("//div[@class='xtXmba' and text()='Fashion']"));
          
            //Mouse hover
            /*Actions action = new Actions(driver);
            action.MoveToElement(fashion);
            action.Build().Perform();

            IWebElement ele = driver.FindElement(By.XPath("//*[contains(text(),'Kids')]"));
            ele.Click();*/

            //electronics 
            driver.FindElement(By.XPath("//*[text()='Electronics']"));
            IWebElement electr = driver.FindElement(By.XPath("//*[text()='Electronics']"));
            
            Actions act = new Actions(driver);
            act.MoveToElement(electr);
            act.Build().Perform();

            IWebElement elect = driver.FindElement(By.XPath("//*[contains(text(),'Gaming')]"));

            elect.Click();
        }


        
    }
}
