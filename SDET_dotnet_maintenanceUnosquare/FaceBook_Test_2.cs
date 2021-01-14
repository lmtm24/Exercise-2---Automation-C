using java.lang;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace lmtm24
{
    class FaceBook_Test_2
    {
       
        #region Login Locators
        By title = By.CssSelector("#reg_pages_msg");
        By createNewAccountButton = By.CssSelector("form#u_0_a  a[role='button']");
        By firstNameField = By.Name("firstname");
        By lastNameField = By.Name("lastname");
        By email = By.XPath("//input[@name='reg_email__']");
        By reEmail = By.XPath("//input[@name='reg_email_confirmation__']");        
        By pass = By.XPath("//input[@name='reg_passwd__']");
        By month = By.XPath("//select[@id='month']");
        By day = By.XPath("//select[@id='day']");
        By year = By.XPath("//select[@id='year']");
        By genderMale = By.CssSelector("span:nth-of-type(2) > ._58mt");
        By signUpButton = By.Name("websubmit");


        #endregion


        static void Main(string[] args)
        {
            IWebDriver Browser;
            IWebElement element;
            Setup setup = new Setup();
            FaceBook_Test_2 faceBook_Test = new FaceBook_Test_2();
            Browser = setup.SetUpDriver();
            Browser.Url = "https://www.facebook.com/";


            element = Browser.FindElement(faceBook_Test.title);
            setup.GetText(element);
            setup.AreEquals("Create a Page for a celebrity, band or business.", setup.GetText(element));            

            element = Browser.FindElement(faceBook_Test.createNewAccountButton);
            setup.Click(element);

            element = Browser.FindElement(faceBook_Test.firstNameField);
            setup.SendText(element,"Luis");

            element = Browser.FindElement(faceBook_Test.lastNameField);
            setup.SendText(element, "Toscano");

            element = Browser.FindElement(faceBook_Test.email);
            setup.SendText(element, "luis.toscano@unoquare.com");

            element = Browser.FindElement(faceBook_Test.reEmail);
            setup.SendText(element, "luis.toscano@unoquare.com");

            element = Browser.FindElement(faceBook_Test.pass);
            setup.SendText(element, "Password#123");

            element = Browser.FindElement(faceBook_Test.month);           
            SelectElement selectMonth = new SelectElement(element);            
            selectMonth.SelectByText("Nov");

            element = Browser.FindElement(faceBook_Test.day);
            SelectElement selectDay = new SelectElement(element);
            selectDay.SelectByValue("24");

            element = Browser.FindElement(faceBook_Test.year);
            SelectElement selectYear = new SelectElement(element);
            selectYear.SelectByValue("1980");

            element = Browser.FindElement(faceBook_Test.genderMale);
            setup.Click(element);

            element = Browser.FindElement(faceBook_Test.signUpButton);
            setup.Click(element);










        }
    }
}
