using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > header > h1")]
        public IWebElement Headline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(1) > a > img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(2)")]
        public IWebElement Paragraph1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(3)")]
        public IWebElement Paragraph2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(4)")]
        public IWebElement Paragraph3 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(5)")]
        public IWebElement Paragraph4 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(6)")]
        public IWebElement Paragraph5 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(7)")]
        public IWebElement Paragraph6 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(8)")]
        public IWebElement Paragraph7 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(9)")]
        public IWebElement Paragraph8 { get; set; }
    }
}
