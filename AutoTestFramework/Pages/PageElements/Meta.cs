using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages.PageElements
{
    public class Meta
    {
        public Meta()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "mh-widget-title-inner")]
        public IWebElement Headline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(1) > a")]
        public IWebElement LogIn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(2) > a")]
        public IWebElement Entriesfeed { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(3) > a")]
        public IWebElement CommentsFeed { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(4) > a")]
        public IWebElement WordPress { get; set; }
    }
}
