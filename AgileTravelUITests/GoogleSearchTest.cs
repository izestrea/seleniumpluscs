using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace AgileTravelUITests
{
    [TestClass]
    public class GoogleSearchTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // susing Firefox Driver
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.google.com");

            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Hello Selenium WebDriver!");
            element.Submit();
            driver.Close();

            // using Chrome Driver
            IWebDriver cdriver = new ChromeDriver();

            // using IE Driver
            IWebDriver idriver = new InternetExplorerDriver();
        }
    }
}
