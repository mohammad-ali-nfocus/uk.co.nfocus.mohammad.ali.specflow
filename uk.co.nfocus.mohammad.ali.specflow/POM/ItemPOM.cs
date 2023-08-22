using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uk.co.nfocus.mohammad.ali.specflow.POM
{
    internal class ItemPOM
    {

        public IWebDriver _driver;

        public ItemPOM(IWebDriver driver)
        {
            _driver = driver;
        }

        // Add item to cart
        private IWebElement _shop =>
           _driver.FindElement(By.LinkText("Shop"));

        public void Shop()
        {
            _shop.Click();
        }

        private IWebElement _item =>
        _driver.FindElement(By.CssSelector("#main > ul > li.product.type-product.post-29.status-publish.last.instock.product_cat-accessories.has-post-thumbnail.sale.shipping-taxable.purchasable.product-type-simple > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link > img"));

        public void Item()
        {
            _item.Click();
        }

        private IWebElement _itemCart =>
        _driver.FindElement(By.CssSelector("#product-29 > div.summary.entry-summary > form > button"));

        public void ItemCart()
        {
            _itemCart.Click();
        }
        // View the cart

        private IWebElement _viewCart =>
        _driver.FindElement(By.CssSelector("#site-header-cart > li:nth-child(1) > a > span.woocommerce-Price-amount.amount"));

        public void ViewCart()
        {
            Thread.Sleep(1000);
            _viewCart.Click();
        }
    }
}
