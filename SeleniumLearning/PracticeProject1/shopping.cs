using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace PracticeProject1
{
    class shopping
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowsing()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.ajio.com/login";

        }
    }
}
