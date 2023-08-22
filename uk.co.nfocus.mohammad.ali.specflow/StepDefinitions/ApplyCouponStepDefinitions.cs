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
    public class ApplyCouponStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        public ApplyCouponStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have items in my cart")]
        public void GivenIHaveItemsInMyCart()
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

            SetupPOM home = new SetupPOM(_driver);
            home.Dismiss();
        }

        [Given(@"I am on the checkout page")]
        public void GivenIAmOnTheCheckoutPage()
        {
            ItemPOM AddItem = new ItemPOM(_driver);
            AddItem.ViewCart();
        }

        [When(@"I enter a valid coupon code for (.*)% off")]
        public void WhenIEnterAValidCouponCodeForOff(int p0)
        {
            CouponPOM AddCoupon = new CouponPOM(_driver);
            AddCoupon.Coupon();
        }

        [When(@"I click the apply button")]
        public void WhenIClickTheApplyButton()
        {
            CouponPOM AddCoupon = new CouponPOM(_driver);
            AddCoupon.Coupon2();
        }

        [Then(@"I should see the discount applied to my total")]
        public void ThenIShouldSeeTheDiscountAppliedToMyTotal()
        {
            CouponPOM AddCoupon = new CouponPOM(_driver);
            AddCoupon.TotalIs15PercentLessThanPrice();

        }
    }
}
