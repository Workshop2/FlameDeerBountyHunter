using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlameDeerBountyHunter.Domain;
using OpenQA.Selenium.Chrome;

namespace FlameDeerBountyHunter.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            const string username = "124";
            const string password = "4234";

            using (var webDriver = new ChromeDriver())
            {
                var loginPage = new LoginPage(webDriver);
                loginPage.Login(username, password);
            }
        }
    }
}
