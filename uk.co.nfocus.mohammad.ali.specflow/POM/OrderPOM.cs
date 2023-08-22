using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uk.co.nfocus.mohammad.ali.specflow.POM
{
    internal class OrderPOM
    {


        private IWebDriver _driver;

        public OrderPOM(IWebDriver driver)
        {
            _driver = driver;
        }

        // check order
        private IWebElement _notice =>
           _driver.FindElement(By.XPath("/html/body/p/a"));

        public void Dismiss()
        {
            _notice.Click();
        }

    }
}
