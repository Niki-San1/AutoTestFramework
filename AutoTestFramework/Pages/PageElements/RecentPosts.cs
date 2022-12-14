using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages.PageElements
{
    public class RecentPosts
    {
        public RecentPosts()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(1) > a")]
        public IWebElement DragAndDrop { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(2) > a")]
        public IWebElement NewTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(3) > a")]
        public IWebElement AlertBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(4) > a")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(5) > a")]
        public IWebElement ID { get; set; }
    }
}
