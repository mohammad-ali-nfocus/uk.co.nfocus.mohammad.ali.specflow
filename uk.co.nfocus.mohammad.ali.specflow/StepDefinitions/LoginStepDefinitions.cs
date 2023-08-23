using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using uk.co.nfocus.mohammad.ali.specflow.POM;
using static uk.co.nfocus.mohammad.ali.specflow.StepDefinitions.Hooks;

namespace uk.co.nfocus.mohammad.ali.specflow.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        public LoginStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            // navigate to page
           _driver.Url = "https://www.edgewordstraining.co.uk/demo-site/my-account/";
        }

        [When(@"I enter my valid username and password")]
        public void WhenIEnterMyValidUsernameAndPassword()
        {
            // Login
            LoginPOM Login = new LoginPOM(_driver);
            Login.Username();
            Login.Password();
          
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            LoginPOM Login = new LoginPOM(_driver);
            Login.Submit();
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeRedirectedToTheHomepage()
        {
            // page automatically loads to logged in page
        }

        
    }
}
