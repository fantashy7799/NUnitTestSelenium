using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestSelenium.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        private IWebDriver Driver { get; }
        public IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        public IWebElement lnkRegister => Driver.FindElement(By.LinkText("Register"));


        IWebElement logOf => Driver.FindElement(By.LinkText("Log off"));
        IWebElement Invalid => Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/section/form/div[1]/ul/li"));
        IWebElement txtNoticeEmptyFiels => Driver.FindElement(By.CssSelector("span[class='text-danger field-validation-error']"));

        public void ClickLogin() => lnkLogin.Click();
        public void ClickRegister() => lnkRegister.Click();
        public bool IsLogOfExist() => logOf.Displayed;
        public bool IsInvalidExist() => Invalid.Displayed;
        public bool IsNoticeEmptyFielsExist() => txtNoticeEmptyFiels.Displayed;

    }
}
