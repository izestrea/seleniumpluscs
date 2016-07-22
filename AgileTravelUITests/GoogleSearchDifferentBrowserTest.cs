using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace AgileTravelUITests
{
    [TestClass]
    public class GoogleSearchDifferentBrowserTest
    {
        [TestMethod]
        public void TestInIE()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://testwisely.com/demo");
            System.Threading.Thread.Sleep(1000);
            driver.Quit();
        }
        [TestMethod]
        public void TestInFirefox()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://testwisely.com/demo");
            System.Threading.Thread.Sleep(1000);
            driver.Quit();
        }
        [TestMethod]
        public void TestInChrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testwisely.com/demo");
            System.Threading.Thread.Sleep(1000);
            driver.Quit();
        }

    }
}
