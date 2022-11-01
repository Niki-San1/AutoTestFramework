using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.Pages.TestScenariosPosts
{
    public class RegisterFormPost
    {
        public RegisterFormPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "userid")]
        public IWebElement UserIdField { get; set; }

        [FindsBy(How = How.Name, Using = "passid")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement NameField { get; set; }

        [FindsBy(How = How.Name, Using = "address")]
        public IWebElement AddressField { get; set; }

        [FindsBy(How = How.Name, Using = "country")]
        public IWebElement CountryDropDownMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(1)")]
        public IWebElement DropDownOption1 { get; set; } //Default

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(2)")]
        public IWebElement DropDownOption2 { get; set; } //Australia

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(3)")]
        public IWebElement DropDownOption3 { get; set; } //Canada

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(4)")]
        public IWebElement DropDownOption4 { get; set; } //India

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(5)")]
        public IWebElement DropDownOption5 { get; set; } //Russia

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(6)")]
        public IWebElement DropDownOption6 { get; set; } //Usa

        [FindsBy(How = How.Name, Using = "zip")]
        public IWebElement ZIPCodeField { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(16) > input[type=radio]")]
        public IWebElement MaleRadioButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(17) > input[type=radio]")]
        public IWebElement FemaleRadioButton { get; set; }

        [FindsBy(How = How.Name, Using = "languageQuestion")]
        public IWebElement EnglishCheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "desc")]
        public IWebElement AboutField { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement RegisterButton { get; set; }
    }
}
