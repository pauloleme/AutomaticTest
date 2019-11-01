using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Interactions;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace SpecFlowTest
{
   public class BrowserNavigator
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        public IWebElement CheckTest (By by, string elementName)
        {
            WebDriverWait _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            try
            {
                _wait.Until(c => c.FindElement(by));
                return Driver.FindElement(by);
            }

            catch (Exception)
            {
                throw new Exception("Element:" + elementName + "" + @by + "" + "is ont found");
            }
        }

        public void Start()
        {
            Driver = new ChromeDriver(@"C:\Users\pojn\source\repos\AumatedPriceGame\AumatedPriceGame\bin\Debug\netcoreapp2.2");
            Driver.Manage().Window.Maximize();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
        }

        public void Stop()
        {
            Driver.Close();
            Driver.Quit();
            Driver.Dispose();
        }

    }
}
