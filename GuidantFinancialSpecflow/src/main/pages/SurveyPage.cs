using GuidantFinancialSpecflow.src.main.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidantFinancialSpecflow.src.main.pages
{
    public class SurveyPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='survey_question']")]
        IWebElement divSurveyQuestion;

        public SurveyPage()
        {
            PageFactory.InitElements(TestEnvironment.webDriver, this);
        }

        public Boolean isSurveyPageDisplaying()
        {
            return (this.isObjectExisted(this.divSurveyQuestion));
        }
    }
}
