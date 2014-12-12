using OpenQA.Selenium;

namespace FlameDeerBountyHunter.Domain
{
    public class LoginPage
    {
        private readonly IWebDriver _webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void Login(string username, string password)
        {
            
        }
    }
}