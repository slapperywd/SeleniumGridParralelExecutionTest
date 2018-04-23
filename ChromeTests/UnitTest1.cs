using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace ChromeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChromeTest1()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");

            IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chromeOptions.ToCapabilities());
            driver.Url = "https://videoportal.epam.com/video/6Rndg4ar";

        }
    }
}
