using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FlameDeerBountyHunter.Console
{
    public static class ChromeDriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            return new ChromeDriver(chromeOptions);
        }
    }
}