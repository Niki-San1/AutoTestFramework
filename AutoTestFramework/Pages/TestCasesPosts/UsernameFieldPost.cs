using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages.TestCasesPosts
{
    public class UsernameFieldPost
    {
        public UsernameFieldPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > figure > img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }
    }
}
