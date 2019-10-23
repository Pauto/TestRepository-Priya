using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Framework.Pages
{
    public class LoginPage
    {
        private int PAGE_LOAD_TIMEOUT;

        public void Goto()
        {
            Browser.Goto("https://www.bestbuy.ca/profile/signin.aspx?ReturnURL=/DefaultPage.aspx");
        }

        public void Login()
        {
            //Browser.Driver.FindElement(By.Id("ap_email")).SendKeys("piabarmi@hotmail.com");
            //Browser.Driver.FindElement(By.Id("ap_password")).SendKeys("Passcode@1234");
            //Browser.Driver.FindElement(By.Id("signInSubmit")).Submit();
            Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_UserNameContainer_txtUserName']")).Clear();
            Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_UserNameContainer_txtUserName']")).SendKeys("emailpb9@yahoo.com");
            Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_PasswordContainer_txtPassword']")).Clear();
            Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_PasswordContainer_txtPassword']")).SendKeys("Passxx@129");
            //Browser.Driver.FindElement(By.Name("Sign In")).Click();
            //Browser.Driver.FindElement(By.Name("Sign In")).Submit();
            Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_BtnLoginButton']")).Click();
            //IWebElement button = Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_BtnLoginButton']"));
            //button.Submit();
            //button.Click();
            //button.Submit();
            //button.Click();
            //
        }
        public void SendUserName(string username)
        {
            IWebElement usernamefield = Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_UserNameContainer_txtUserName']"));
            usernamefield.SendKeys(username);
        }

        public bool IsAt()
        {
            By actualname = By.Id("FirstNameLabel");
            return Browser.WaitUntilElementIsDisplayed(actualname, PAGE_LOAD_TIMEOUT); 
        }

        public void InValidLogin()
        {
            Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_UserNameContainer_txtUserName']")).Clear();
            Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_UserNameContainer_txtUserName']")).SendKeys("piabarmi@hotmail.com");
            Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_PasswordContainer_txtPassword']")).Clear();
            Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_PasswordContainer_txtPassword']")).SendKeys("1234");
            IWebElement button = Browser.Driver.FindElement(By.XPath(".//*[@id='ctl00_CP_SignInUC1_BtnLoginButton']"));
            button.Submit();
        }
    }
}
