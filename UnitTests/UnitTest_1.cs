//using System;
//using System.Collections.Generic;
//using System.Text;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System.Threading.Tasks;
//using System.Linq;


//namespace NUnitTestSelenium.UnitTests
//{
//    [TestFixture]
//    public class UnitTest_1 : TestBase
//    {
//        protected IWebDriver driver;
//        //Open Browser Driver
//        IWebDriver webDriver = new ChromeDriver(@"G:\HOCTAP\N4\4.2\1_TRKPO");// 


//        //Hooks in NUnit
//        [SetUp]
//        public void Setup()
//        {
//            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/Account/Login");
//            // webDriver.Navigate().GoToUrl("http://eaapp.somee.com/"); //navigate to the site        }
//        }
//        [Test]
//        public void VerrifyValidLogin()
//        {
//            //driver.Navigate().GoToUrl("http://eaapp.somee.com/Account/Login/");
//            driver.FindElement(By.Name("UserName")).SendKeys("trangdang");
//            driver.FindElement(By.Name("Password")).SendKeys("Tr@ang123");
//            driver.FindElement(By.XPath("//input[@value = 'Log in']")).Submit();

//            String actualResult = driver.Title;
//            String expectedResult = "Home - Execute Automation Employee App";
//            //Validate that Alert comes with SUCCESS as text on it
//            Assert.AreEqual(actualResult, expectedResult);
//            Console.WriteLine("logined");
//        }
//        [TearDown]
//        public void TearDown() => webDriver.Quit();


//        [Test]
//        public void VerrifyInvalidLogin()
//        {

//        }
//    }

//}
