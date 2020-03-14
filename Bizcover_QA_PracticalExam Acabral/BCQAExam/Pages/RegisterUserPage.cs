using BCQAExam.Core;
using OpenQA.Selenium;

namespace BCQAExam.Pages
{
    public class RegisterUserPage : BasePage
    {
        private IWebElement Cust_FirstName => Driver.FindControl(By.Id("customer_firstname"), true);
        private IWebElement Cust_LastName => Driver.FindControl(By.Id("customer_lastname"), true);
        private IWebElement Cust_Email => Driver.FindControl(By.Id("email"), true);
        private IWebElement Cust_Password => Driver.FindControl(By.Id("passwd"), true);
        private IWebElement Addr_FirstName => Driver.FindControl(By.Id("firstname"), true);
        private IWebElement Addr_LastName => Driver.FindControl(By.Id("lastname"), true);
        private IWebElement Address => Driver.FindControl(By.Id("address"), true);
        private IWebElement City => Driver.FindControl(By.Id("city"), true);
        private IWebElement State => new Select(Driver.FindControl(By.Id("id_state")), true);
        private IWebElement ZipCode => Driver.FindControl(By.Id("postcode"), true);
        private IWebElement Mobile_Phone => Driver.FindControl(By.Id("phone_mobile"), true);
        private IWebElement Alias => Driver.FindControl(By.Id("alias"), true);
        private IWebElement RegisterButton => Driver.FindControl(By.Id("submitAccount"));

        public void RegisterUser(string[] args)
        {
            Random randomGen = new Random();
            int randomNum = randomGen.nextInt(200000);

            Cust_FirstName.SendKeys("First Name " + randomNum);
            Cust_LastName.SendKeys("Last Name " + randomNum);
            Cust_Password.SendKeys("test12345");
            Addr_FirstName.SendKeys(Cust_FirstName);
            Addr_LastName.SendKeys(Cust_LastName);
            Address.SendKeys("101 Street Address");
            City.SendKeys("Daly City");
            State.selectbyValue(2);
            ZipCode.SendKeys("90210");
            Mobile_Phone.SendKeys("05639457664");
            Alias.GetAttribute("value");
            RegisterButton.Click();
        }

        public void AccountName(string AcctName)
        {
            AcctName = Cust_FirstName + Cust_LastName;
            return AcctName;
        }

        public void EmailAdd(string EmailAdd)
        {
            EmailAdd = Cust_Email.GetAttribute("value");
            return EmailAdd;
        }

        public void Password(string Password) {
            Password = Cust_Password.GetAttribute("value");
            return Passsword;
        }
    }
}
