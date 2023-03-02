using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class FunctionalTest
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowsing()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();//initilze chrome brwsr
            //implicit wait 5sec can be declared globally
            //3 sec

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();//maximize
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";//hits the url

        }
        [Test]
        public void dropdown()
        {
            IWebElement dropdown =driver.FindElement(By.CssSelector("select.form-control"));
            SelectElement s = new SelectElement(dropdown);
            s.SelectByText("Teacher");
            Thread.Sleep(1000);
            s.SelectByValue("consult");
            s.SelectByIndex(2);

            IList<IWebElement> rdos=driver.FindElements(By.CssSelector("input[type = 'radio']"));
            //IList is an interface thats come from collections utility
            foreach ( IWebElement radioButton in rdos)
            {

                if (radioButton.GetAttribute("value").Equals("user"))
                    {
                    radioButton.Click();
                    }

            }
            Thread.Sleep(1000);
            driver.FindElement(By.Id("okayBtn")).Click();
            
            Boolean result = driver.FindElement(By.Id("usertype")).Selected;

        }

    }
}
