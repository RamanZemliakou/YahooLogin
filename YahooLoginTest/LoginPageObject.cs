using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooLoginTest
{
    class LoginPageObject : BasePageObject
    {
        private readonly By _loginNameField = By.XPath("//input[@id='login-username']");
        private readonly By _nextButton = By.XPath("//input[@id='login-signin']");
        

        private string _username = "dr.ramanzemliakou";
       

        public LoginPageObject(IWebDriver _webDriver) : base(_webDriver)
        {
        }

        public void UsernameInput()
        {
            _webDriver.FindElement(_loginNameField).SendKeys(_username);
            _webDriver.FindElement(_nextButton).Click();

            
        }
    }
}
