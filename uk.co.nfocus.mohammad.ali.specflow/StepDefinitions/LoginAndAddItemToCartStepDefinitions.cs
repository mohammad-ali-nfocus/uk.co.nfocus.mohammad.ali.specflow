using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using uk.co.nfocus.mohammad.ali.specflow.POM;
using static uk.co.nfocus.mohammad.ali.specflow.StepDefinitions.Hooks;
namespace uk.co.nfocus.mohammad.ali.specflow.StepDefinitions
{
    [Binding]
    public class LoginAndAddItemToCartStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        public LoginAndAddItemToCartStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I should be logged in")]
        public void GivenIShouldBeLoggedIn()
        {
            _driver.Url = "https://www.edgewordstraining.co.uk/demo-site/my-account/";
            LoginPOM Login = new LoginPOM(_driver);
            Login.Username();
            Login.Password();
            Login.Submit();
           
        }

        [Given(@"I am on the Shop page")]
        public void GivenIAmOnTheShopPage()
        {
            ItemPOM AddItem = new ItemPOM(_driver);
            AddItem.Shop();
        }


        [When(@"I select a item")]
        public void WhenISelectAItem()
        {
            ItemPOM AddItem = new ItemPOM(_driver);
            AddItem.Item();
           
        }

        [When(@"I add it to the cart")]
        public void WhenIAddItToTheCart()
        {
            ItemPOM AddItem = new ItemPOM(_driver);
            AddItem.ItemCart();
        }

        [Then(@"When i view the cart the item should be there")]
        public void ThenWhenIViewTheCartTheItemShouldBeThere()
        {
            ItemPOM AddItem = new ItemPOM(_driver);
            AddItem.ViewCart();

          
        }
    }
}
