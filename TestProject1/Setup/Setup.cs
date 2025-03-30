using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestProject1.Setup
{
    public class Setup
    {
        protected IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
