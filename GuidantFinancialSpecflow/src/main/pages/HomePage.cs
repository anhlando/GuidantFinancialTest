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
    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//span[@class='has-error']")]
        private IWebElement errorMessage;

        [FindsBy(How = How.XPath, Using = "//input[@id='FirstName']")]
        private IWebElement txtFirstName;

        [FindsBy(How = How.XPath, Using = "//input[@id='LastName']")]
        private IWebElement txtLastName;

        [FindsBy(How = How.XPath, Using = "//input[@id='Email']")]
        private IWebElement txtEmail;

        [FindsBy(How = How.XPath, Using = "//input[@id='Phone']")]
        private IWebElement txtPhone;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement btnSubmit;

        public HomePage()
        {
            PageFactory.InitElements(TestEnvironment.webDriver, this);
        }

        public void clickSubmit()
        {
            this.clickObject(this.btnSubmit);
        }

        public void inputFirstname(String value)
        {
            this.enterText(this.txtFirstName, value);
        }

        public void inputLastname(String value)
        {
            this.enterText(this.txtLastName, value);
        }

        public void inputEmail(String value)
        {
            this.enterText(this.txtEmail, value);
        }

        public void inputPhone(String value)
        {
            this.enterText(this.txtPhone, value);
        }

        public void submitForm(String fname, String lname, String email, String phone)
        {
            this.inputFirstname(fname);
            this.inputLastname(lname);
            this.inputEmail(email);
            this.inputPhone(phone);
            this.clickSubmit();
        }

        public Boolean isFormValid()
        {
            return this.isObjectExisted(this.errorMessage);
        }

    }
}
