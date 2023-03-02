using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    class Locators
    {
        //locators like css,Xpath,name,tag name,id
        IWebDriver driver;

        public IWebElement IWebElement { get; private set; }

        [SetUp]
        public void StartBrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            //driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";


        }


        [Test]
        public void LocatorsIdentification()
        {
            driver.FindElement(By.Id("username")).SendKeys("DeepuPotti");
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("PottiKanna");
            driver.FindElement(By.Name("password")).SendKeys("Potti520");
            //driver.FindElement(By.CssSelector("input[value='Sign In']")).Click();
            driver.FindElement(By.XPath("//input[@value='Sign In']")).Click();//element of the web and performing the action of click

            Thread.Sleep(3000);
            String errorMessage = driver.FindElement(By.ClassName("alert-danger")).Text;//element of the web and performs text 
            TestContext.Progress.WriteLine(errorMessage);//to get error message in output

            IWebElement link = driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));//I is an inteface
            String hrefAttr = link.GetAttribute("href");
            String expectedUrl = "https://rahulshettyacademy.com/documents-request";
            Assert.AreEqual(expectedUrl, hrefAttr);//validate URL of the link text


        }



    }
}
