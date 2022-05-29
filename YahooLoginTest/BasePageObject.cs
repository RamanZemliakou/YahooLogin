using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooLoginTest
{
    class BasePageObject
    {
        protected IWebDriver _webDriver;
        public static readonly string url = "https://www.yahoo.com/";
        private readonly By _signInButton = By.XPath("//a[@class='_yb_w9vif']");
        private readonly By _accountName = By.XPath("//span[@role='presentation']");
        private readonly string _loggedUser = "Raman";
        public BasePageObject(IWebDriver webDriver)
        {
            this._webDriver = webDriver;
        }

        public void NavigateToSignIn()
        {
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(url);
            _webDriver.FindElement(_signInButton).Click();
        }

        public string ReadName()
        {
            string LoggedName = _webDriver.FindElement(_accountName).Text;
            return LoggedName;
        }
        public string UserNameToCompare()
        {
            string userNameToCompare = _loggedUser;
            return userNameToCompare;
        }
    }
}
