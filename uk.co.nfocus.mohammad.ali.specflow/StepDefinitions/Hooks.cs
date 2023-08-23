using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;
using uk.co.nfocus.mohammad.ali.specflow.POM;

namespace uk.co.nfocus.mohammad.ali.specflow.StepDefinitions
{
    [Binding]
    public class Hooks
	{
		
		public static IWebDriver _driver;
		
		[Before]
		public void SetUp()
		{
			_driver = new ChromeDriver();
			_driver.Manage().Window.Maximize();
            _driver.Url = "https://www.edgewordstraining.co.uk/demo-site/my-account/";
		

		}

		[After]
		public void TearDown()
		{
			Thread.Sleep(2000);

            LogoutPOM LogOut = new LogoutPOM(_driver);
            LogOut.Logout();
            LogOut.Logout2();
            // to see what is happening 
            _driver.Quit();
		}

	}

}
