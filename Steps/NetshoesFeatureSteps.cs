using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest
{
    [Binding]
    public class NetshoesFeatureSteps
    {
        private MainPage MainPage;
        private BrowserNavigator navigator;
        public PageElement Map;
        private ValidatorPrice ValidatePrice;

        [Given(@"I have opened browser to access website")]
        public void GivenIHaveOpenedBrowserToAccessWebsite()
        {

            navigator = new BrowserNavigator();
            navigator.Start();

            ValidatePrice = new ValidatorPrice(navigator.Driver);
            MainPage = new MainPage(navigator.Driver);
            MainPage.Navigate();
        
        }
    
        
        [When(@"search the shoes for '(.*)' open the shoes")]
        public void WhenSearchTheShoesForOpenTheShoes(string name)
        {            
            MainPage.SearchProduct(name);
            MainPage.Waiting();
            MainPage.OpenShoes();
            MainPage.Waiting();
            
        }
        
        [When(@"when shoes opened compare if is the same '(.*)'")]
        public void WhenWhenShoesOpenedCompareIfIsTheSame(string value)
        {
            MainPage.ClickItem();
            ValidatePrice.ValidateShoesValue(value);
        }
        
        [Then(@"close browser")]
        public void ThenCloseBrowser()
        {
            navigator.Stop();
        }
    }
}
