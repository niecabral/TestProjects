using BCQAExam.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BCQAExam.Steps
{
    [Binding]
    public class RegisterUserSteps : BaseStepDefinition
    {
        private NavigationPage NavigationPage = new NavigationPage();
        private RegisterUserPage RegisterUserPage = new RegisterUserPage();
        private LoginPage LoginPage = new LoginPage();
        private dynamic _ScenarioData;

        [Given(@"I am in the registration page of the system")]
        public void GivenIAmInTheRegistrationPageOfTheSystem()
        {
            NavigationPage.NavigateToRegisterAccountPage();
        }

        [When(@"I enter my personal information and address")]
        public void WhenIEnterPersonalInfoAndAddress()
        {
            RegisterUserPage.RegisterUser();
        }

        [Then(@"I should be registered and able to login")]
        public void ThenIShouldBeAbletoLogin(table table)
        {
            NavigationPage.NavigateToHomePage();
            NavigationPage.NavigateToLoginPage();
            _ScenarioData = table.CreateDynamicInstance();
            RegisterUserPage.RegisterUser((string)_ScenarioData.EmailAdd, (string)_ScenarioData.Password);
        }
    }
}
