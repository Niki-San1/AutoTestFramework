using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages.PageElements
{
    public class RightSideBar
    {
        public RightSideBar()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "search-field")]
        public IWebElement SearchBar { get; set; }

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

        public class DropDownMenu
        {
            public DropDownMenu()
            {
                PageFactory.InitElements(Driver.driver, this);
            }

            [FindsBy(How = How.Name, Using = "cat")]
            public IWebElement Menu { get; set; }

            [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(1)")]
            public IWebElement Option1 { get; set; } //Select Category

            [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(2)")]
            public IWebElement Option2 { get; set; } //Actions

            [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(3)")]
            public IWebElement Option3 { get; set; } //Selectors

            [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(4)")]
            public IWebElement Option4 { get; set; } //Special Elements

            [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(5)")]
            public IWebElement Option5 { get; set; } //Tabs and Windows

            [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(6)")]
            public IWebElement Option6 { get; set; } //Test Cases

            [FindsBy(How = How.CssSelector, Using = "#cat > option:nth-child(7)")]
            public IWebElement Option7 { get; set; } //Test Scenarios
        }

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
}
