using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YahooLoginTest
{
    class PasswordInputPageObject : LoginPageObject
    {
        private readonly By _passwordField = By.XPath("//input[@type='password']");
        private readonly By _submitButton = By.XPath("//button[@name='verifyPassword']");
        private readonly By _accountName = By.XPath("//span[@role='presentation']");
        private string _password = "TestDoc123";
        public PasswordInputPageObject(IWebDriver _webDriver) : base(_webDriver)
        {
        }


        public void PasswordInput()
        {
            Thread.Sleep(1000); //wait until element to be interactible
            _webDriver.FindElement(_passwordField).SendKeys(_password);
            _webDriver.FindElement(_submitButton).Click();
        }


    }
}
