//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace NUnitTestSelenium
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
           
//        }

//        [Test]
//        public void Test1()
//        {
//            IWebDriver webDriver = new ChromeDriver(@"G:\HOCTAP\N4\4.2\1_TRKPO");// Open browser Driver
//            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/"); //navigate to the site
        
//            //Indentify Login
//            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("Login"));
//            //operation
//            lnkLogin.Click();

//            var txtUserName = webDriver.FindElement(By.Name("UserName"));

//            //Assertion
//            Assert.That(txtUserName.Displayed, Is.True);

//            txtUserName.SendKeys("trangdang");

//            webDriver.FindElement(By.Name("Password")).SendKeys("Tr@ang123");
//            webDriver.FindElement(By.XPath("//input[@value = 'Log in']")).Submit();

//            var lnkEmployeeDetail = webDriver.FindElement(By.LinkText("Employee Details"));

//            Assert.That(lnkEmployeeDetail, Is.True);

//        }
//    }
//}
