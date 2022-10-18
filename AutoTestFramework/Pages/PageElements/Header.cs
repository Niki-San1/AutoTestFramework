using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages.PageElements
{
    internal class Header
    {
        public Header()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "mh-header-title")]
        public IWebElement Headline { get; set; }

        [FindsBy(How = How.ClassName, Using = "mh-header-tagline")]
        public IWebElement SubHeadline { get; set; }
    }
}
