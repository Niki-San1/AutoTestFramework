using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages.PageElements
{
    public class Search
    {
        public Search()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "search-field")]
        public IWebElement SearchBar { get; set; }
    }
}
