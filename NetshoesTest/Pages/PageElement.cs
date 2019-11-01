using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;

namespace SpecFlowTest
{
    public class PageElement : BrowserNavigator
    {
        public IWebDriver browser;

        public PageElement(IWebDriver browser)

        {
            this.browser = browser;
            PageFactory.InitElements(browser, this);
        }

        [FindsByAll]
        public IWebElement SearchProduct
        {
            get
            {
                By by = By.XPath("/html//input[@id='search-input']");
                return CheckTest(by, "SearchProduct");
            }
        }

        //[FindsBy(How = How.XPath, Using = "/html//input[@id='search-input']")]
        //public IWebElement SearchProduct { get; set; }

        public IWebElement SearchButton
        {
            get
            {
                By by = By.XPath("//div[@id='header-content']//section[@class='search']/section[@class='search-field']/form[@action='/busca']//button[@alt='Buscar']");
                return CheckTest(by, "SearchButton");
            }
        }

        public IWebElement FirstProduct
        {
            get
            {
                By by = By.XPath("//div[@id='item-list']/div[@class='wrapper']/div[1]");
                return CheckTest(by, "FirstProduct");
            }
        }

        public IWebElement ValueProduct
        {
            get
            {
                By by = By.CssSelector("[data-page-seller] [itemprop='price']");
                return CheckTest(by, "ValueProduct");
            }
        }





    }

}
