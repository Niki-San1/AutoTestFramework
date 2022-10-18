using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages.TestCasesPosts
{
    public class LoginButtonPost
    {
        public LoginButtonPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "testButton")]
        public IWebElement Button { get; set; }
    }
}
