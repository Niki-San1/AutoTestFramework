using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages
{
    public class SelectorsPage
    {
        public SelectorsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-111.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div > header > h3 > a")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-110.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div > header > h3 > a")]
        public IWebElement Id { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-109.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div > header > h3 > a")]
        public IWebElement XPath { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-108.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div > header > h3 > a")]
        public IWebElement CSSPath { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-107.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div > header > h3 > a")]
        public IWebElement ClassName { get; set; }
    }
}
