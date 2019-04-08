using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidantFinancialSpecflow.src.main.utilities
{
    public class TestEnvironment
    {
        public static IWebDriver webDriver;
        
        public static void initWebDriver()
        {
            String driverType = ConfigurationManager.AppSettings["driverType"].Trim().ToLower();
            String libFolder = Helper.getLibFolder();
            Console.WriteLine("Driver type: " + driverType);
            switch (driverType)
            {
                case "chrome":
                    webDriver = new ChromeDriver(libFolder);
                    break;
                case "firefox":
                    webDriver = new FirefoxDriver(libFolder);
                    break;

            }
        }

    }
}
