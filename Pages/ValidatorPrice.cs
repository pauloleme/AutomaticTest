using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Windows.Input;
using OpenQA.Selenium.Chrome;

namespace SpecFlowTest
{
    public class ValidatorPrice
    {
        private readonly IWebDriver browser;

        public ValidatorPrice(IWebDriver browser)
        {
            this.browser = browser;
            
        }

        protected PageElement Map
        {
            get
                {
                    return new PageElement(browser);
                }
        }

        public void ValidateShoesValue(string value)
        {
            Assert.AreEqual(Map.ValueProduct.Text, value);

        }
    }
}
