using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1
{
    public class SeleniumFirstTest
    {
        IWebDriver driver;


        [SetUp]
        public void StartBrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
           //driver = new EdgeDriver();
            driver.Manage().Window.Maximize();


        }


        [Test]
        public void Test1()
        {
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
            //driver.Close();//Only close window opened by chrome driver
            //driver.Quit();//quit all the windows


        }



    }
}
