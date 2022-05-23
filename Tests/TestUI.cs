using NUnit.Framework;
using NUnitTestSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestSelenium.Tests
{
    public class TestE2E
    {
        //Open Browser Driver
        IWebDriver webDriver = new ChromeDriver(@"Pages\driver");

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/"); //navigate to the site        
        }
        /// 1- Login with correct username and pass
       [Test]

        public void Test1()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("UyDinh", "Uydinh123$");

            Assert.That(homePage.IsLogOfExist, Is.True);
        }
        //<summary>
        /// 2- Login incorrect Username and correct pass
        //</summary>
        [Test]
        public void Test2()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("Uydinhh", "Uydinh123$");

            Assert.That(homePage.IsInvalidExist, Is.True);
        }
        ///3- Login đúng Username sai pass
        [Test]
        public void Test3()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("UyDinh", "Uydinh123");

            Assert.That(homePage.IsInvalidExist, Is.True);
        }
        ///4- Login sai pass sai username
        [Test]
        public void Test4()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("Sasuke", "Naruto");

            Assert.That(homePage.IsInvalidExist, Is.True);
        }

        ///5- Login bỏ trống cả 2 trường Input 
        [Test]
        public void Test5()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("", "");

            Assert.That(homePage.IsNoticeEmptyFielsExist, Is.True);
        }
        ///6- Login but not input data to field Username  
        [Test]
        public void Test6()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("", "Uydinh123$");

            Assert.That(homePage.IsNoticeEmptyFielsExist, Is.True);
        }
        //7- Login but not input data to field Pass
        [Test]
        public void Test7()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("UyDinh", "");

            Assert.That(homePage.IsNoticeEmptyFielsExist, Is.True);
        }
        ///8- Maxlength of field UserName when Register
        [Test]
        public void Test8()
        {
            HomePage homePage = new HomePage(webDriver);
            RegisterPage regisPage = new RegisterPage(webDriver);

            homePage.ClickRegister();

            int maxLength = 10;
            //int maxLengthDefind;

            Assert.AreEqual(maxLength, regisPage.MaxLengthUserName());
        }
        /// <summary>
        /// 9 Maxlength of field password when Register
        /// </summary>
         [Test]
         public void Test9()
         {
             HomePage homePage = new HomePage(webDriver);
             RegisterPage regisPage = new RegisterPage(webDriver);

             homePage.ClickRegister();

             int maxLength = 100;
             //int maxLengthDefind;

             Assert.AreEqual(maxLength, regisPage.MaxLengthPass());
         }

        /*10*/
         [Test]
         public void Test10()
        {
            HomePage homePage= new HomePage(webDriver);
            homePage.ClickRegister();

            RegisterPage regisPage = new RegisterPage(webDriver);

            Assert.That(regisPage.IsButtonRegister, Is.True);
        }
        

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}







