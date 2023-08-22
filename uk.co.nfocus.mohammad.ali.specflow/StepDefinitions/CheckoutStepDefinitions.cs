using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;
using uk.co.nfocus.mohammad.ali.specflow.POM;
using static uk.co.nfocus.mohammad.ali.specflow.StepDefinitions.Hooks;

namespace uk.co.nfocus.mohammad.ali.specflow.StepDefinitions
{
    [Binding]
    public class CheckoutStepDefinitions
    {
        [Given(@"I am logged in and have added items in my cart")]
        public void GivenIHaveAddedItemsInMyCart()
        {
            _driver.Url = "https://www.edgewordstraining.co.uk/demo-site/my-account/";
            LoginPOM Login = new LoginPOM(_driver);
            Login.Username();
            Login.Password();
            Login.Submit();

            ItemPOM AddItem = new ItemPOM(_driver);
            AddItem.Shop();
            AddItem.Item();
            AddItem.ItemCart();
            AddItem.ViewCart();

            SetupPOM home = new SetupPOM(_driver);
            home.Dismiss();

        }

        [Given(@"I click checkout")]
        public void GivenIClickCheckout()
        {
            //scroll down 
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("window.scrollBy(0,500)", "");

            //check out
            CheckoutPOM CheckOut = new CheckoutPOM(_driver);
            CheckOut.CheckoutButton();

        }

        [When(@"I enter my shipping and payment information")]
        public void WhenIEnterMyShippingAndPaymentInformation()
        {
            CheckoutPOM CheckOut = new CheckoutPOM(_driver);
            CheckOut.Checkout();
        }

        [When(@"I click the complete order button")]
        public void WhenIClickTheCompleteOrderButton()
        {

            CheckoutPOM CheckOut = new CheckoutPOM(_driver);
            CheckOut.PlaceOrder();
        }

        [Then(@"I should see a confirmation page with my order details")]
        public void ThenIShouldSeeAConfirmationPageWithMyOrderDetails()
        {
            CheckoutPOM CheckOut = new CheckoutPOM(_driver);
            CheckOut.OrderNumCheck();
        }
    }
}
