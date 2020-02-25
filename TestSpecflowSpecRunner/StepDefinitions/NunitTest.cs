using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PruebaSelenium.PageObjects;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;



namespace PruebaSelenium.StepDefinitions
{
    [Binding]
    class NunitTest
    {
        private readonly ScenarioContext _scenarioContext;

        private IWebDriver _driver;
        private LoginPage _lp;
        private DesignersListPage _dlp;
        private DesignersDetailPage _ddp;

        public NunitTest(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        /**
        [BeforeTestRun]
        public static void StartBrowser()
        {
            _driver = new ChromeDriver((Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
            
            _lp = new LoginPage(_driver);
            _dlp = new DesignersListPage(_driver);
            _ddp = new DesignersDetailPage(_driver);
        }
            */
           
        
        [Given(@"I am on the Corazon login page")]
        public void IAmOnTheCorazonLoginPage()
        {
            //_driver = new ChromeDriver((Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
            //_driver.Url = "http://intranet/corazon/login";
            
        }
        [When(@"I login with wrong credentials")]
        public void ILoginWithWrongCredentials()
        {
           // _lp = new LoginPage(_driver);
           // _lp.TrySignIn("test", "");
        }
        [Then(@"the login is not successfully done")]
        public void TheLoginIsNotSuccessful()
        {
            //Assert.AreEqual("Password is required", _lp.LoginError().Text);
        }
        /**
        [Test]
        public void Test_01_Invalid_Login_Empty_Password()
        {
            _lp.TrySignIn("test", "");
            Assert.AreEqual("Password is required", _lp.LoginError().Text);

        }
        */

        /**
    [Test]
    public void Test_02_Valid_Login_and_Navigation()
    {

        //lp.TrySignIn("Corazon.Test", "secret2017");

        //Set valid credentials
        _lp.TrySignIn("manuel.jimenez", "XX");

        _dlp.WaitForDesignerLoad();
        var designerCount = _dlp.GetDesignerCount();
        Console.WriteLine(designerCount);

        Assert.IsTrue(designerCount > 0);
        
        _dlp.ClickFirstDesigner();
        _ddp.ClickBackToDesignerList();
        
        _dlp.WaitForDesignerLoad();
        designerCount = _dlp.GetDesignerCount();
        Console.WriteLine(designerCount);

        Assert.IsTrue(designerCount > 0);
        
    }
*//**
        [AfterTestRun]
        public static void CloseBrowser()
        {
            _driver.Dispose();
        }
    */
    }
}