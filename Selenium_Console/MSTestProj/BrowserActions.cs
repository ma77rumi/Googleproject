using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestProj
{
    class BrowserActions
    {
        public void NavigateUrl(IWebDriver driver)
        {
            driver.Url = "https://www.flipkart.com";
            driver.Manage().Window.Maximize();
        }

        public void ClickObj(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }
        public void EnterText(IWebDriver driver, By locator, String text)
        {
            driver.FindElement(locator).SendKeys(text);
        }

    }
}
