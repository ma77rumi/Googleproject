using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTestDemo.TestSuite
{
    [TestFixture]
    public class ExtentDemo
    {
        [Test]
        public void GenerateDemo()
        {
            ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(@"C:\Users\Biplab\OneDrive\Documents\ExtentReport\report.html");

            AventStack.ExtentReports.ExtentReports report = new AventStack.ExtentReports.ExtentReports();
            report.AttachReporter(htmlReport);

            ExtentTest test = report.CreateTest("Test1");

            test.Log(Status.Pass, "Success log");
            test.Log(Status.Fail, "Failure log");
            test.Log(Status.Info, "info log");

            report.Flush();
        }
    }
}
