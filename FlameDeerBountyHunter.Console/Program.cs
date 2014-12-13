using FlameDeerBountyHunter.Console.Properties;
using FlameDeerBountyHunter.Domain;

namespace FlameDeerBountyHunter.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Settings.Default.Username;
            string password = Settings.Default.Password;

            using (var webDriver = ChromeDriverFactory.CreateDriver())
            {
                var loginPage = new LoginPage(webDriver);
                loginPage.Login(username, password);
            }
        }
    }
}
