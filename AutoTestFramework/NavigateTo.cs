using AutoTestFramework.Pages;
using AutoTestFramework.Pages.PageElements;

namespace AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginPost()
        {
            Menu menu = new Menu();
            menu.TestScenarios.Click();

            TestScenariosPage TSPage = new TestScenariosPage();
            TSPage.LoginForm.Click();
        }

        public static void RegisterPost()
        {
            Menu menu = new Menu();
            menu.TestScenarios.Click();

            TestScenariosPage TSPage = new TestScenariosPage();
            TSPage.RegisterForm.Click();
        }

        public static void LoginButtonPost()
        {
            Menu menu = new Menu();
            menu.TestCases.Click();

            TestCasesPage TCPage = new TestCasesPage();
            TCPage.LoginButtonInLoginForm.Click();
        }
    }
}
