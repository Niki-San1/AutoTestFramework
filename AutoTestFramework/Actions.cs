using AutoTestFramework.Pages.TestScenariosPosts;
using OpenQA.Selenium.Chrome;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }

        public static void FillLogInForm(string Username, string Password, string RepeatPassword)
        {
            LoginFormPost Login = new LoginFormPost();

            Login.UsernameField.Clear();
            Login.UsernameField.SendKeys(Username);

            Login.PasswordField.Clear();
            Login.PasswordField.SendKeys(Password);

            Login.RepeatPasswordField.Clear();
            Login.RepeatPasswordField.SendKeys(RepeatPassword);

            Login.LoginButton.Click();
        }

        public static void FillRegistrationForm(string UserID, string Password, string Username, string Address, int Country, string Zip, string Email)
        {
            RegisterFormPost Reg = new RegisterFormPost();

            Reg.UserIdField.Clear();
            Reg.UserIdField.SendKeys(UserID);

            Reg.PasswordField.Clear();
            Reg.PasswordField.SendKeys(Password);

            Reg.NameField.Clear();
            Reg.NameField.SendKeys(Username);

            Reg.AddressField.Clear();
            Reg.AddressField.SendKeys(Address);

            switch (Country)
            {
                case 1:
                    Reg.DropDownOption1.Click();
                    break;

                case 2:
                    Reg.DropDownOption2.Click();
                    break;

                case 3:
                    Reg.DropDownOption3.Click();
                    break;

                case 4:
                    Reg.DropDownOption4.Click();
                    break;

                case 5:
                    Reg.DropDownOption5.Click();
                    break;

                case 6:
                    Reg.DropDownOption6.Click();
                    break;

                default:
                    break;
            }

            Reg.ZIPCodeField.Clear();
            Reg.ZIPCodeField.SendKeys(Zip);

            Reg.EmailField.Clear();
            Reg.EmailField.SendKeys(Email);

            Reg.RegisterButton.Click();
        }
    }
}
