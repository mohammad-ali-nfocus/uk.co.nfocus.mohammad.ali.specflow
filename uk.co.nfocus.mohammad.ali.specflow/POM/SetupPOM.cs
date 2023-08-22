using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace uk.co.nfocus.mohammad.ali.specflow.POM
{
    internal class SetupPOM
    {

        public IWebDriver _driver;


        public SetupPOM(IWebDriver driver)
        {
            _driver = driver;
            
        }

        // dismiss notice
        private IWebElement _notice => _driver.FindElement(By.LinkText("Dismiss"));

        public void Dismiss()
        {
            _notice.Click();
        }






    }
}
