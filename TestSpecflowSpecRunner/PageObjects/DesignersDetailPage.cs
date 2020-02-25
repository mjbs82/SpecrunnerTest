using OpenQA.Selenium;

namespace PruebaSelenium.PageObjects
{
    class DesignersDetailPage
    {
        private IWebDriver _driver;

        public DesignersDetailPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickBackToDesignerList()
        {
            _driver.FindElement(By.Id("backButton")).Click();
        }

    }
}