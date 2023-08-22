using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uk.co.nfocus.mohammad.ali.specflow.POM
{
    internal class LogoutPOM
    {


        public IWebDriver _driver;

        public LogoutPOM(IWebDriver driver)
        {
            _driver = driver;
        }

        // logout
        private IWebElement _logout =>
           _driver.FindElement(By.LinkText("My account"));


        public void Logout()
        {
            _logout.Click();
            Thread.Sleep(2000);
        }

        private IWebElement _logout2 =>
           _driver.FindElement(By.CssSelector("#post-7 > div > div > div > p:nth-child(2) > a"));


        public void Logout2()
        {
            _logout2.Click();
        }


    }
}
