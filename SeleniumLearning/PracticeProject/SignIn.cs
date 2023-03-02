using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
    public class SignIn
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




    }
}
