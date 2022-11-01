using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutoTestFramework.Tests.Cases
{
    public class LoginValid
    {
        IAlert Alert;

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginPost();
        }

        [Test]
        public void ValidLogIn()
        {
            Actions.FillLogInForm(Config.Credentials.Valid.UserID, Config.Credentials.Valid.PasswordLogin, Config.Credentials.Valid.RepeatPassword);

            Alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertBoxMessages.LoginSuccessful, Alert.Text);

            Alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
