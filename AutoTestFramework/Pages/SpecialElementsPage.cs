using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages
{
    public class SpecialElementsPage
    {
        public SpecialElementsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-119.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-special-elements > div > header > h3 > a")]
        public IWebElement AlertBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-59.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-special-elements > div > header > h3 > a")]
        public IWebElement TextInputField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-33.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-special-elements > div > header > h3 > a")]
        public IWebElement CheckButtonTest { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-10.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-special-elements > div > header > h3 > a")]
        public IWebElement RadioButtonTest { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-6.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-special-elements > div > header > h3 > a")]
        public IWebElement DropDownMenuTest { get; set; }
    }
}
