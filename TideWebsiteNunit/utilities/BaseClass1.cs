using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using NUnit.Framework;
using AventStack.ExtentReports.Reporter;
using Serilog.Core;
using Serilog.Events;
using Serilog;

namespace TideWebsiteNunit
{
     public class BaseClass1
    {
        public static IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentTest test;
        [OneTimeSetUp]
        public void StartExtentReport()
        {
            extent = new ExtentReports();
            var report = new ExtentHtmlReporter(@"C:\Users\mindc1may01\source\repos\TideWebsiteNunit\reports\result.html");
            extent.AttachReporter(report);
            LoggingLevelSwitch data = new LoggingLevelSwitch(LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(levelSwitch: data).WriteTo.File(@"C:\Users\mindc1may01\source\repos\TideWebsiteNunit\reports\logfile",outputTemplate:"[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj} {NewLine} {Exception}").CreateLogger();



        }
        public void StartExtentReport1()
        {
            extent = new ExtentReports();
            var report = new ExtentHtmlReporter(@"C:\Users\mindc1may01\source\repos\TideWebsiteNunit\reports\result.html");
            extent.AttachReporter(report);
            LoggingLevelSwitch data = new LoggingLevelSwitch(LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(levelSwitch: data).WriteTo.File(@"C:\Users\mindc1may01\source\repos\TideWebsiteNunit\reports\logfile", outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj} {NewLine} {Exception}").CreateLogger();

        }
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [OneTimeTearDown]
        public void CloseExtentReport()
        {
            extent.Flush();
        }


    }
}
