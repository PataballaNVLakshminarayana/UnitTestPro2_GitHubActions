using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTestPro2_GitHubActions
{
    [TestClass]
    public class GitHubActions
    {
        public static IWebDriver _driver;
        [TestMethod]
        public void TestMethod1()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            _driver.FindElement(By.Id("username")).SendKeys("nagalakshmin");
            _driver.FindElement(By.Id("password")).SendKeys("l@kshmin");
            _driver.FindElement(By.Id("login")).Submit();
            Thread.Sleep(10000);
            _driver.Quit();
        }
    }
}
