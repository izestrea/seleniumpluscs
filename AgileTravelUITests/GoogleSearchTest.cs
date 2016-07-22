using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AgileTravelUITests
{
    [TestClass]
    public class GoogleSearchTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.google.com");

            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Hello Selenium WebDriver!");
            element.Submit();
            driver.Close();
        }
    }
}
