using GuidantFinancialSpecflow.src.main.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidantFinancialSpecflow.src.main.pages
{
    public class BasePage
    {
        public void clickObject(IWebElement obj)
        {
            obj.Click();
        }

        public void enterText(IWebElement obj, String text)
        {
            obj.Clear();
            obj.SendKeys(text);
        }

        public Boolean isObjectExisted(IWebElement obj)
        {
            return (obj != null);
        }

        public void refresh()
        {
            PageFactory.InitElements(TestEnvironment.webDriver, this);
        }

        public static IWebElement waitUntilElementExists(By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(TestEnvironment.webDriver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementExists(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
    }
}
