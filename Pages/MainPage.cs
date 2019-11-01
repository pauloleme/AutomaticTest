using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SpecFlowTest
{
    public class MainPage
    {
        private readonly IWebDriver browser;
        public PageElement Map;

        private readonly string url = @"https://www.netshoes.com.br";

        public MainPage(IWebDriver browser)
        {
            this.browser = browser;
            this.Map = new PageElement(browser);
        }
                    

        public void Navigate()
        {
            browser.Navigate().GoToUrl(url);
        }

        public void Waiting()
        {
            Thread.Sleep(9000);
        }

        public void SearchProduct(string name)
        {
            Map.SearchProduct.Click();
            
            Map.SearchProduct.SendKeys(name);           

        }

        public void OpenShoes()
        {
            Map.SearchButton.Click();
        }
        public void ClickItem()
        {
            Map.FirstProduct.Click();
        }
    }
}
