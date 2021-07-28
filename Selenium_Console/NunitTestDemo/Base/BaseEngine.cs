using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTestDemo.Base
{
    public class BaseEngine
    {
        public IWebDriver driver;
        public AventStack.ExtentReports.ExtentReports report;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(@"C:\Users\Biplab\OneDrive\Documents\ExtentReport\report.html");

            report = new AventStack.ExtentReports.ExtentReports();
            report.AttachReporter(htmlReport);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            report.Flush();
        }
        [SetUp]
        public void Setup()
        {
            BrowserFactory factory = new BrowserFactory();
            driver = factory.LaunchBrowser();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
