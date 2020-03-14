using BCQAExam.Core;
using OpenQA.Selenium;
using System.Configuration;

namespace BCQAExam.Pages
{
    public class NavigationPage : BasePage
    {
        public void NavigateToHomePage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }

        public void NavigateToSignInPage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["Sign-in"]);
        }

        public void NavigateToRegisterAccountPage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["RegAcct"]);
        }

        private IWebElement SignInButton => Driver.FindControl(By.XPath("//a[@class='login']"));

        public void NavigateToLoginPage()
        {
            SignInButton.Click();
        }
    }
}
