using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;


namespace Selenium_try
{
    class BrowserTests
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\yevhenta\\.nuget\\packages\\Selenium.WebDriver.ChromeDriver\\2.41.0\\driver\\win32");
        }
        [Test]
        public void test()
        {
            driver.Url = "https://m-guccibingo-qa3.test.bingosys.net/#/Login";
            // driver.Manage().Window.Maximize();
            IWebElement emailTextBox = driver.FindElement(By.Id("user-name"));
            IWebElement passwordTextBox = driver.FindElement(By.Id("password"));
            IWebElement singUpButton = driver.FindElement(By.Id("login-button"));

            var actions = new Actions(driver);
            actions.MoveToElement(emailTextBox);
            emailTextBox.SendKeys("CashierTest1");
            actions.MoveToElement(passwordTextBox);
            passwordTextBox.SendKeys("Qwerty1");
            singUpButton.Click();

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
        
    }
}
