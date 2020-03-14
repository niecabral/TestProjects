using BCQAExam.Core;
using OpenQA.Selenium;

namespace BCQAExam.Pages
{
    public class CreateAccountPage : BasePage
    {
        private IWebElement Email => Driver.FindControl(By.Id("email_create"), true);

        private IWebElement SubmitButton => Driver.FindControl(By.Id("SubmitCreate"));

        public void CreateAccount(string email = null)
        {
            Email.Clear();
            Random randomGen = new Random();
            int randomNum = randomGen.nextInt(200000);
            Email.SendKeys("testuser_"+randomNum+"@bizcover.com.au");
            SubmitButton.Click();
        }
    }
}
