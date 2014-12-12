using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.WebDriver.Extensions;

namespace FlameDeerBountyHunter.Domain
{
    public class LoginPage
    {
        private const string LOGIN_URL = "https://www.hotukdeals.com/login";
        private readonly IWebDriver _webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void Login(string username, string password)
        {
            _webDriver.Navigate().GoToUrl(LOGIN_URL);

            EnterUsername(username);
            EnterPassword(password);
            SubmitLogin();
        }

        private void EnterUsername(string username)
        {
            IWebElement usernameInput = _webDriver.FindElement(InputByName("username"));
            Assert.That(usernameInput, Is.Not.Null);
            usernameInput.SendKeys(username);
        }

        private void EnterPassword(string password)
        {
            IWebElement passwordInput = _webDriver.FindElement(InputByName("password"));
            Assert.That(passwordInput, Is.Not.Null);
            passwordInput.SendKeys(password);
        }

        private void SubmitLogin()
        {
            IWebElement button = _webDriver.FindElement(InputById("submit-join"));
            Assert.That(button, Is.Not.Null);
            button.Click();
        }

        private JQuerySelector InputByName(string name)
        {
            return InputBySelector(string.Format("input[name={0}]", name));
        }

        private JQuerySelector InputById(string id)
        {
            return InputBySelector(string.Format("#{0}", id));
        }

        private JQuerySelector InputBySelector(string selector)
        {
            string jquerySelector = string.Format(".content-layout-container {0}", selector);
            return new JQuerySelector(jquerySelector);
        }
    }
}