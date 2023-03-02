using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class E2E
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
        public void EndToEndFlow()
        {
            String[] expectedproducts = { "iphone x", "Blackberry" };
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Name("password")).SendKeys("learning");
            driver.FindElement(By.XPath("//div[@class='form-group'][5]/label/span/input")).Click();
            driver.FindElement(By.XPath("//input[@id='signInBtn']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("Checkout")));

            IList<IWebElement> products = driver.FindElements(By.TagName("app-card"));//to enter into list

            foreach (IWebElement product in products)//for picking each product from products list
            {
                TestContext.Progress.WriteLine(product.FindElement(By.CssSelector(".card-title a")).Text);
            }
            //driver.FindElement(By.PartialLinkText("Checkout")).Click();

        }
    }
}

