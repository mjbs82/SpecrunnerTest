using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSelenium.PageObjects
{
    class LoginPage
    {
        private const string sbodom = "SB";
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //public IWebDriver getDriver() => driver;

        public IWebElement Username()
        {
            return _driver.FindElement(By.CssSelector("#userName"), 30);
        }

        public IWebElement Password()
        {
            return _driver.FindElement(By.CssSelector("#userPassword"), 30);
        }

        public IWebElement LoginError()
        {
            return _driver.FindElement(By.ClassName("help-block"), 30);
        }

        public IWebElement DomainCombo()
        {
            return _driver.FindElement(By.CssSelector("#mainContainer > login > div > div > form > div:nth-child(1) > div > select"), 30);
        }

        public void SelectComboElementByValue(string value)
        {
            DomainCombo().SendKeys(value + Keys.Enter);
        }
        public IWebElement SignIn()
        {
            return _driver.FindElement(By.ClassName("primaryButton"));
        }

        public void TrySignIn(string username, string password)
        {
            SelectComboElementByValue(sbodom);
            Username().SendKeys(username);
            Password().SendKeys(password);
            SignIn().Click();

        }
    }
}