﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Drawing;
using IdlingComplaintTest.Pages.Login;

namespace IdlingComplaintTest.Setup
{
    internal abstract class DriverSetup
    {
        private IWebDriver iWebDriver;

        protected IWebDriver GetDriver()
        {
            return iWebDriver;
        }

        protected void SetDriver(IWebDriver driver)
        {
            iWebDriver = driver;
        }

        [SetUp]
        public virtual void SetUp()
        {
            iWebDriver = CreateDriver("chrome");
            iWebDriver.Manage().Window.Size = new Size(1920, 1200);
        }

        [TearDown]
        public void TearDown()
        {
            iWebDriver.Quit();
        }
        protected IWebDriver CreateDriver(string browserName)
        {
            switch (browserName.ToLowerInvariant())
            {
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    //chromeOptions.AddArguments(GetBrowserArguments());
                    return new ChromeDriver(chromeOptions);
                case "firefox":
                    var firefoxOptions = new FirefoxOptions();
                    //firefoxOptions.AddArguments(GetBrowserArguments());
                    return new FirefoxDriver(firefoxOptions);
                case "edge":
                    var edgeOptions = new EdgeOptions();
                    //edgeOptions.AddArguments(GetBrowserArguments());
                    return new EdgeDriver(edgeOptions);
                default:
                    throw new Exception("Provided browser is not supported.");
            }
        }
    }
}
