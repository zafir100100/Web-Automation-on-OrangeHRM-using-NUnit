using TestProject1.Pages;

namespace TestProject1.TestRunners
{
    public class LoginTestRunner : Setup.Setup
    {
        private LandingPage? landingPage;

        [Test, Order(1)]
        public void LoginWithValidCredentials()
        {
            landingPage = new LandingPage(driver);
            landingPage.NavigateToLandingPage();
            landingPage.DoLogin("Admin", "admin123");
            landingPage.VerifyValidLogin();
        }
    }
}
