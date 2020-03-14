using BCQAExam.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BCQAExam.Pages
{
    public class MyAccountPage:BasePage
    {
        private IWebElement AccountName => Driver.FindControl(By.XPath("//a[@title='View my customer account']"));
        private IWebElement MyAccountTab => Driver.FindControl(By.XPath("//span[@class='navigation_page']"));

        public void AssertAccountName()
        {
            RegisterUserPage R = new RegisterUserPage();
            string AccountName = R.AccountName;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(AccountName, AccountName.Text);
                Assert.AreEqual("My account", MyAccountTab.Text);
            });
        }
    }
}
