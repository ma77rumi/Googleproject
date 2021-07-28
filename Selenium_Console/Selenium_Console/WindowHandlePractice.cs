using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Console
{
    public class WindowHandlePractice
    {
        public void WindowHandlePracticeDemo()
        {
            IWebDriver driver = new ChromeDriver();

            

            driver.Url = "https://www.flipkart.com";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2doB4z']")).Click();

            driver.FindElement(By.Name("q")).SendKeys("books");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            string parentWindow = driver.CurrentWindowHandle;
            driver.FindElement(By.XPath("//*[@class='s1Q9rs']")).Click();
            IList<String> window = driver.WindowHandles;
            string childWindow = window[1];
            driver.SwitchTo().Window(childWindow);
            driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2U9uOA _3v1-ww']"));
            driver.Close();
            driver.SwitchTo().Window(parentWindow);


            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys("Iphone");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);



        }

    }
    

    }
    

    

