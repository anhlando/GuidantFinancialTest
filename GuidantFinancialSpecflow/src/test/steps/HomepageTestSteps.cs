using GuidantFinancialSpecflow.src.main.pages;
using GuidantFinancialSpecflow.src.main.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace GuidantFinancialSpecflow
{
    [Binding]
    public class HomepageTestSteps
    {
        HomePage homePage;

        public HomepageTestSteps()
        {
            this.homePage = new HomePage();
        }

        [BeforeTestRun]
        public static void startTest()
        {
            TestEnvironment.initWebDriver();
            Console.WriteLine("Start testing...");

        }

        [Given(@"I go to url: (.*)")]
        public void go_to_url(String url)
        {
            Console.WriteLine("URL: " + url);
            TestEnvironment.webDriver.Navigate().GoToUrl("https://buyer-stg.guidantfinancial.com/");
            
        }

        [When(@"I submit form with: (.*) , (.*) , (.*) , (.*)")]
        public void submit_homepage_with(String fname, String lname, String email, String phone)
        {
            this.homePage.submitForm(fname, lname, email, phone);
        }
        
        [Then(@"I see error message displays")]
        public void is_error_message_displaying()
        {
            Assert.True(this.homePage.isFormValid());
        }

        [Then(@"I see Survey page displays")]
        public void is_survey_page_displaying()
        {
            try
            {
                BasePage.waitUntilElementExists(By.XPath("//div[@class='survey_question']"), 10);
                Assert.True(true);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.True(false);
            }
        }

        [AfterTestRun]
        public static void cleanUp()
        {
            TestEnvironment.webDriver.Close();
            Console.WriteLine("Test finished, driver is closed!!!");
        }
    }
}
