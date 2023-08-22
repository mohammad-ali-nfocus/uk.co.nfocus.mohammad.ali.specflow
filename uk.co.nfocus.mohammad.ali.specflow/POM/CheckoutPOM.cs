using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uk.co.nfocus.mohammad.ali.specflow.POM
{
    internal class CheckoutPOM
    {
        public IWebDriver _driver;

        public CheckoutPOM(IWebDriver driver)
        {
            _driver = driver;
        }


        private IWebElement _button => _driver.FindElement(By.ClassName("wc-proceed-to-checkout"));
        private IWebElement _fname => _driver.FindElement(By.Id("billing_first_name"));
        private IWebElement _lname => _driver.FindElement(By.Id("billing_last_name"));
        private IWebElement _address => _driver.FindElement(By.Id("billing_address_1"));
        private IWebElement _city => _driver.FindElement(By.Id("billing_city"));
        private IWebElement _postcode => _driver.FindElement(By.Id("billing_postcode"));
        private IWebElement _phone => _driver.FindElement(By.Id("billing_phone"));
        private IWebElement _ordernum => _driver.FindElement(By.CssSelector(".order > strong"));
        private IWebElement _ordernum2 => _driver.FindElement(By.CssSelector("#post-7 > div > div > div > table > tbody > tr:nth-child(1) > td.woocommerce-orders-table__cell.woocommerce-orders-table__cell-order-number > a"));
        public void CheckoutButton()
        {
            _button.Click();
            Thread.Sleep(2000);
        }
        public void Checkout()
        {
            //check out
          

            _fname.Clear();
            _fname.SendKeys("Mohammad");

            _lname.Clear();
            _lname.SendKeys("Ali");

            _address.Clear();
            _address.SendKeys("New Street");

            _city.Clear();
            _city.SendKeys("London");

            _postcode.Clear();
            _postcode.SendKeys("HA9 6SQ");

            _phone.Clear();
            _phone.SendKeys("07411111111");
        }

        public void PlaceOrder()
        {
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("place_order")).Click();
        }

        public void OrderNumCheck()
        {
            Thread.Sleep(2000);
            // Get order number from the first page
            string orderNum = _ordernum.Text;

            // Go to My Account page
            _driver.FindElement(By.LinkText("My account")).Click();

            // Go to Orders page
            _driver.FindElement(By.LinkText("Orders")).Click();

            // Get order number from the Orders page
            string orderNum2 = _ordernum2.Text;

            // Remove "#" symbol from orderNum2
            orderNum2 = orderNum2.Replace("#", "");

            // Assert that both order numbers match
            Assert.AreEqual(orderNum, orderNum2, $"Order numbers are not the same");
        }




    }
}
