using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestSelenium.Pages
{
    class RegisterPage
    {
        public RegisterPage(IWebDriver RegisterDriver)
        {
            Driver = RegisterDriver;
        }
        public IWebDriver Driver { get; }

        IWebElement boxUserName => Driver.FindElement(By.XPath("/html/body/div[2]/form/div[2]/div/input"));
        IWebElement boxPass => Driver.FindElement(By.XPath("/html/body/div[2]/form/div[3]/div/input"));

        //IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        //IWebElement btn => Driver.FindElement(By.XPath("//input[@value = 'Log in']"));

        public int MaxLengthUserName()
        {
            int max = int.Parse(boxUserName.GetAttribute("data-val-length-max"));
            return max;
        }
        public int MaxLengthPass()
        {
            int max = int.Parse(boxPass.GetAttribute("data-val-length-max"));
            return max;
        }

        IWebElement btnRegister => Driver.FindElement(By.XPath("/html/body/div[2]/h2"));

        public bool IsButtonRegister() => btnRegister.Displayed;


    }
}
