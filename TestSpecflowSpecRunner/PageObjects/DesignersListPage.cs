using System.Collections;
using OpenQA.Selenium;

namespace PruebaSelenium.PageObjects
{
    class DesignersListPage
    {
        private IWebDriver _driver;

        public DesignersListPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public int GetDesignerCount()
        {
            var designersElements = _driver.FindElements(By.CssSelector("#designersGridTable tr"));
            return ((ICollection) designersElements).Count;
        }

        public IWebElement WaitForDesignerLoad()
        {
            return _driver.FindElement(By.CssSelector("#designersGridTable > table > tbody > tr:nth-child(1)"), 30);
        }

        public void ClickFirstDesigner()
        {
            _driver.FindElement(By.CssSelector("#designersGridTable > table > tbody > tr:nth-child(1)")).Click();
        }

        //public IWebElement DesignerListIcon()
        //{
        //    return driver.FindElement(By.CssSelector("#designersGridHeader > div.col-xs-4.no-padding.title > h3"), 30);
        //}

        //public IWebElement DesignerGridBody()
        //{
        //    return driver.FindElement(By.CssSelector("#designersGridTable > table > tbody"));
        //}

        //public IWebElement Spinner()
        //{
        //    return driver.FindElement(By.ClassName("spinner"));
        //}
    }
}