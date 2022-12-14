using AventStack.ExtentReports;
using OpenQA.Selenium;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using TideWebsiteNunit;

namespace TideWebsiteNunit.pom
{
     public class Userlogin:BaseClass1
    {

        public void openurl()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(4000);
            driver.Navigate().GoToUrl("https://tide.com/en-us");
            driver.Manage().Window.Maximize();
            Log.Information("It will open url successfully");
            test.Log(Status.Info, "It will open url successfully");
            driver.FindElement(By.XPath("//a[@class = 'lilo3746-close-link lilo3746-close-icon']")).Click();

        }
        public void log()
        {
            driver.FindElement(By.XPath("//a[text()='Register']")).Click();
            int scroll = driver.FindElement(By.XPath("//a[@href='https://twitter.com/tide']")).Location.Y;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, " + scroll + ")", "");
            driver.FindElement(By.XPath("//button[@class = 'sticker_close']")).Click();
            driver.FindElement(By.XPath("//a[text()='Sign up now']")).Click();
            System.Collections.ObjectModel.ReadOnlyCollection<string> switchTabs = driver.WindowHandles;
            int count = switchTabs.Count;
            foreach (string tab in switchTabs)
            {
                driver.SwitchTo().Window(tab);
            }
            driver.FindElement(By.XPath("//button[@class='underline text-primaryCta lg:text-base leading-light font-montserratSemiBold font-semibold']")).Click();

            driver.FindElement(By.XPath("//input[@id='login-email']")).SendKeys("email");
            driver.FindElement(By.XPath("//input[@id='login-password']")).SendKeys("password");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            ((ITakesScreenshot)BaseClass1.driver).GetScreenshot().SaveAsFile
                (@"C:\Users\mindc1may01\source\repos\TideWebsiteNunit\screenshots\login.png");

            driver.Quit();
        }

        
    }
}
