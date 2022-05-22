using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestSelenium.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebDriver Driver { get; }

        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value = 'Log in']"));
        IWebElement txtTiltle => Driver.FindElement(By.XPath("//h2[contains(., 'Login.')]."));
        public void Login(String userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }

        public bool IsTittleLogInExist() => txtTiltle.Displayed;

    }
}
