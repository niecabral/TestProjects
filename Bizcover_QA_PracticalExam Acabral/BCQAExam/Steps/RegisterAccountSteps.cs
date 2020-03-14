using BCQAExam.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BCQAExam.Steps
{
    [Binding]
    public class CreateAccountSteps : BaseStepDefinition
    {
        private NavigationPage NavigationPage = new NavigationPage();
        private CreateAccountPage CreateAccountPage = new CreateAccountPage();
        private RegisterUserPage RegisterUserPage = new RegisterUserPage();
        private dynamic _ScenarioData;

        [Given(@"Given I am in the sign-in page of the system")]
        public void GivenIAmInTheSignInPageOfTheSystem()
        {
            NavigationPage.NavigateToSignInPage();
        }

        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            NavigationPage.NavigateToLoginPage();
            CreateAccountPage.CreateAccount();
        }

        [Then(@"I should be redirected to Register Account Page")]
        public void ThenIShouldBeRedirectedToRegisterAccountPage()
        {
            NavigationPage.NavigateToRegisterAccountPage();
        }
    }
}