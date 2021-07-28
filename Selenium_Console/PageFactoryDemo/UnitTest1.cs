using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace PageFactoryDemo
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
           
           Common co = new Common();
           driver = co.LaunchBrowser();
           co.NavigateURL(driver);

            //IWebDriver driver = new ChromeDriver();
            //driver.Url = "https://google.com";


            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);

            //driver.FindElement(By.LinkText("Sign in")).Click();
            //homePage.btn_SignIn.Click();
            co.Click_obj(homePage.btn_SignIn,"Sign In");

            SignInPage create = new SignInPage();
            PageFactory.InitElements(driver, create);
            //create.lnk_create.Click();
            //create.lnk_MySelf.Click();

            co.Click_obj(create.lnk_create,"Create");
            co.Click_obj(create.lnk_MySelf,"My self");

            CreateAccountPage cr = new CreateAccountPage();
            PageFactory.InitElements(driver, cr);
            //cr.txt_firstname.SendKeys("firstname");
            co.EnterText(cr.txt_firstname, "Smith","First Name");
            //cr.txt_lastName.SendKeys("lastName");
            co.EnterText(cr.txt_lastName, "John","Last Name");
           // cr.txt_username.SendKeys("abc123");
            co.EnterText(cr.txt_username, "abc123","User NAme");
            //cr.txt_password.SendKeys("abc123456");
            co.EnterText(cr.txt_password, "abc123456","Password");
            //cr.txt_confirmpassword.SendKeys("abc123456");
            co.EnterText(cr.txt_confirmpassword, "abc123456","Cnf password");
            //cr.txt_showpassword.Click();
            co.Click_obj(cr.txt_showpassword,"Password");

           // cr.txt_next.Click();
            co.Click_obj(cr.txt_next,"Next");

        }
    }
}