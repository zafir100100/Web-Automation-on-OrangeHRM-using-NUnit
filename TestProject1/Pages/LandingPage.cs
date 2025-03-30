using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class LandingPage
    {
        private readonly IWebDriver driver;
        private readonly string baseUrl = "https://opensource-demo.orangehrmlive.com";
        private readonly By txtUserName = By.Name("username");
        private readonly By txtPassword = By.Name("password");
        private readonly By btnSubmit = By.CssSelector("[type=submit]");

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToLandingPage()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void DoLogin(string userName, string password)
        {
            driver.FindElement(txtUserName).SendKeys(userName);
            driver.FindElement(txtPassword).SendKeys(password);
            driver.FindElement(btnSubmit).Click();
        }

        public void VerifyValidLogin()
        {
            Assert.That(
                driver.Url,
                Does.Contain("dashboard"),
                "Login verification failed: URL does not contain 'dashboard'"
            );
        }
    }
}
