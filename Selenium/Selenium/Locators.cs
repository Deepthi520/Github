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
    class Locators
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowsing()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            //implicit wait 5sec can be declared globally
            //3 sec

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";

        }
        [Test]
        public void LocatorsIdentification()
        {
            driver.FindElement(By.Id("username")).SendKeys("PottiKanna");
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("PottiKanna");
            driver.FindElement(By.Name("password")).SendKeys("potti520");
            //css selector and xpath
            //tagname[attribute ='value']
            // #id   #terms - class name -> css.classname
            //driver.FindElement("input[value='Sign In')")).click();

            //       //tagName[@attribute = 'value']

            // CSS - .text-info span:nth-child(1) input
            //xpath-  //label[@class='text-info']/span/input

            driver.FindElement(By.XPath("//div[@class='form-group'][5]/label/span/input")).Click();

            driver.FindElement(By.CssSelector("input[value='Sign In']")).Click();
            //driver.FindElement(By.XPath("//input[@)value='Sign In']")).Click();

            //Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan. FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
           .TextToBePresentInElementValue(driver.FindElement(By.Id("signInBtn")), "Sign In"));
                
            String errorMessage = driver.FindElement(By.ClassName("alert-danger")).Text;
            TestContext.Progress.WriteLine(errorMessage);

            IWebElement link = driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));
            //grab the text in one variable i.e IWebelement 
            String hrefAttr = link.GetAttribute("href");
            String expectedUrl = "https://rahulshettyacademy.com/documents-request";
            Assert.AreEqual(expectedUrl, hrefAttr);
            
            //validate epected and actual value
             

        }

        private TimeSpan FromSeconds(int v)
        {
            throw new NotImplementedException();
        }
    }
}
