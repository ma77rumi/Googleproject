using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_Console
{
    class PracticeForm
    {
        public void PraForm()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url= "https://demoqa.com/automation-practice-form";
            driver.Manage().Window.Maximize();
            //FirstName
            IWebElement fName = driver.FindElement(By.Id("firstName"));
            fName.SendKeys("Masuma");
            string value = fName.GetAttribute("value");
            Console.WriteLine(value);
            string pHolder = fName.GetAttribute("placeholder");
            Console.WriteLine(pHolder);
            //LastName
            IWebElement lName= driver.FindElement(By.Id("lastName"));
            lName.SendKeys("Mahmud");
            string value1 = lName.GetAttribute("value");
            Console.WriteLine(value1);
            string placeholder = lName.GetAttribute("placeholder");
            Console.WriteLine(placeholder);

            //Email
            IWebElement eMail = driver.FindElement(By.Id("userEmail"));
            eMail.SendKeys("ma77rumi@gmail.com");
            //Gender
            IWebElement gender = driver.FindElement(By.XPath("//*[@for='gender-radio-2']"));
            gender.Click();
            //Mobile Number
            IWebElement mNumber = driver.FindElement(By.Id("userNumber"));
            mNumber.SendKeys("6825539703");

            //Date of Birth. 
            //IWebElement dob1 = driver.FindElement(By.Id("dateOfBirthInput"));
            //dob1.Clear();
            //dob1.SendKeys("15 May 2021");

            //dob1.Click();
            //IWebElement dob = driver.FindElement(By.XPath("//*[@aria-label='Choose Friday, May 14th, 2021']"));
            //dob.Click();

            // Subject (Not working)
            //IWebElement subject = driver.FindElement(By.XPath("//div[@id='subjectsContainer']/div/div[1]/div"));
            //subject.Click();
          //  subject.SendKeys("Phy");
            

            // Hobbies CheckBox
            IWebElement sprots = driver.FindElement(By.XPath("//*[@for='hobbies-checkbox-1']"));
            sprots.Click();

            IWebElement reading = driver.FindElement(By.XPath("//*[@for='hobbies-checkbox-2']"));
            reading.Click();

            IWebElement music = driver.FindElement(By.XPath("//*[@for='hobbies-checkbox-3']"));
            music.Click();

            // State (Not working)
            IWebElement sCity = driver.FindElement(By.XPath("//*[@class=' css-yk16xz-control']"));
           sCity.Click();
            IWebElement sCity1 = driver.FindElement(By.XPath("//*[contains(text(),'Haryana')]"));
            sCity1.Click();


            //IWebElement sCity1 = driver.FindElement(By.XPath("(//*[@class=' css-1hwfws3'])[1]"));
            //sCity1.Click();

            Thread.Sleep(6000);
            // City (Not working)
            IWebElement sCity2 = driver.FindElement(By.XPath("//*[text()='Select City']"));
            sCity2.Click();
            IWebElement sCity3 = driver.FindElement(By.XPath("//*[contains(text(),'Karnal')]"));
            sCity3.Click();

            IWebElement submit = driver.FindElement(By.Id("submit"));
            submit.Click();

            
            

        }

    }
}
