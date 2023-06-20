﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace IdlingComplaintTest.Models.Base
{
    internal class BaseModel
    {
        protected readonly IWebDriver Driver;

        protected BaseModel()
        {
            this.Driver = CreateDriver("chrome");
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
