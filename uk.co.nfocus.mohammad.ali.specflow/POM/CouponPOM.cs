using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uk.co.nfocus.mohammad.ali.specflow.POM
{
    internal class CouponPOM
    {

        public IWebDriver _driver;

        public CouponPOM(IWebDriver driver)
        {
            _driver = driver;
        }

        // Apply the coupon
        private IWebElement _coupon =>
           _driver.FindElement(By.Id("coupon_code"));

        public void Coupon()
        {
            _coupon.SendKeys("edgewords");
        }

        private IWebElement _coupon2 =>
          _driver.FindElement(By.CssSelector("#post-5 > div > div > form > table > tbody > tr:nth-child(2) > td > div > button"));

        public void Coupon2()
        {
            _coupon2.Click();
            Thread.Sleep(2000);
        }

        public double GetPriceValue()
        {
            IWebElement priceElement = _driver.FindElement(By.CssSelector("#post-5 > div > div > div.cart-collaterals > div > table > tbody > tr.cart-subtotal > td > span > bdi"));
            string priceText = priceElement.Text;
            priceText = priceText.Replace("£", ""); // Remove the "£" symbol
            double price = Convert.ToDouble(priceText); // Convert to double
            return price;
        }

        public double GetTotalValue()
        {
            IWebElement totalElement = _driver.FindElement(By.CssSelector("#post-5 > div > div > div.cart-collaterals > div > table > tbody > tr.order-total > td > strong > span > bdi"));
            string totalText = totalElement.Text;
            totalText = totalText.Replace("£", ""); // Remove the "£" symbol
            double total = Convert.ToDouble(totalText); // Convert to double
            return total;
        }

        public void TotalIs15PercentLessThanPrice()
        {
            double price = GetPriceValue();
            double total = GetTotalValue();

            // Calculate 15% of the price
            double fifteenPercentOfPrice = price * 0.15;

            // Use NUnit's Assert.That to make the assertion
            Assert.That(total + fifteenPercentOfPrice, Is.EqualTo(price + 3.95),$"Coupon is not 15% off");
        }












    }
}
