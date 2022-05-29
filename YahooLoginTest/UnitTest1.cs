using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace YahooLoginTest
{
    public class Tests
    {
        DriverProvider driverProvider;

        [SetUp]
        public void Setup()
        {
            driverProvider = new DriverProvider();
        }

        [Test]
        public void Test1()
        {
            var basePageObject = new BasePageObject(driverProvider.GetDriver());
            var loginPageObject = new LoginPageObject(driverProvider.GetDriver());
            var passwordInputPageObject = new PasswordInputPageObject(driverProvider.GetDriver());
            basePageObject.NavigateToSignIn();
            loginPageObject.UsernameInput();
            passwordInputPageObject.PasswordInput();
            string usernameResult = basePageObject.ReadName();
            string expectedUsername = basePageObject.UserNameToCompare();
            Assert.AreEqual(expectedUsername, usernameResult);
        }
    }
}