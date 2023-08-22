using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uk.co.nfocus.mohammad.ali.specflow.POM
{
    internal class LoginPOM
    {

        private IWebDriver _driver;

        public LoginPOM(IWebDriver driver)
        {
            _driver = driver;
        }

        // Login username
        private IWebElement _login =>
           _driver.FindElement(By.Id("username"));

        public void Username()
        {
            _login.SendKeys("mohammad.ali");
        }

        // Login Password
        private IWebElement _login1 =>
           _driver.FindElement(By.Id("password"));

        public void Password()
        {
            _login1.SendKeys("Alimanni786");
        }

        // Login Click button
        private IWebElement _login2 =>
           _driver.FindElement(By.CssSelector("button.woocommerce-button:nth-child(4)"));

        public void Submit()
        {
            _login2.Click();
        }

    }
}
