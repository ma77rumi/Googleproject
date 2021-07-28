using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTestDemo.Repository
{
    public class HomePage
    {
        public static  By ele_close = By.XPath("//button[@class='_2KpZ6l _2doB4z']");
        public static  By txt_Search = By.Name("q");
        public static By ele_SearchResult = By.XPath("//div[@class='_4rR01T']");


        public void ValidateSearchFunctionality(IWebDriver driver)
        {
            IList<IWebElement> iphones = driver.FindElements(ele_SearchResult);

            foreach (IWebElement iphone in iphones)
            {
                if (iphone.Text.Contains("iPhone"))
                {
                    Console.WriteLine("Search functionality working as expected " + iphone.Text);
                }
                else
                {
                    Console.WriteLine("Search functionality not working as expected " + iphone.Text);
                }
            }
        }
    }
}
