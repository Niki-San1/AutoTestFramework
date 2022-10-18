using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages.PageElements
{
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
}
