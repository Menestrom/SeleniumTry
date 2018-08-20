using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_try
{
    public class BrowserTests
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Evgeniy\\Documents\\Visual Studio 2015\\Projects\\Tests_try\\packages\\Selenium.WebDriver.ChromeDriver.2.41.0\\driver\\win32");
            driver.Url = "https://fantlab.ru/";
            IWebElement emailTextBox = driver.FindElement(By.XPath("/html/body/div[4]/div/header/div[2]/aside/div/div[2]/form/div[1]/input"));
            IWebElement passwordTextBox = driver.FindElement(By.XPath("/html/body/div[4]/div/header/div[2]/aside/div/div[2]/form/div[2]/input"));
            IWebElement singUpButton = driver.FindElement(By.XPath("/html/body/div[4]/div/header/div[2]/aside/div/div[2]/form/div[3]/button"));

            driver.Manage().Window.Maximize();
            emailTextBox.SendKeys("tarnavskiu@bigmir.net");
            passwordTextBox.SendKeys("pizdec");
            singUpButton.Click();
        }
        [Test]
        public void Profile_changes()
        {
            IWebElement profile = driver.FindElement(By.Id("pf-link"));
            profile.Click();
            IWebElement profile_settings = driver.FindElement(By.LinkText("Правка профиля"));
            profile_settings.Click();
            IWebElement password_checkbox = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/main/form/table/tbody/tr[3]/td[2]/input"));
            password_checkbox.Click();
            IWebElement password = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/main/form/table/tbody/tr[4]/td[2]/input"));
            IWebElement password_one_more_time = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/main/form/table/tbody/tr[5]/td[2]/input"));
            password.SendKeys("pizdec123");
            password_one_more_time.SendKeys("pizdec123");

            IWebElement sex = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/main/form/table/tbody/tr[12]/td[2]/select"));
            IWebElement selectElement = new SelectElement(sex);

        }
        [TearDown]
        public void closeBrowser()
        {
            // driver.Close();
        }

    }
}
