using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using System.Text;
using System.Linq; 

namespace NUnitTestSelenium
{
    public class TestBase
    {
        protected IWebDriver driver ;
        //Open Browser Driver
        IWebDriver webDriver = new ChromeDriver(@"D:\Nam4\ky 2\TPKPO\test3\driver");// 


        //Hooks in NUnit
        [SetUp]
        public void Setup()
        {
            //webDriver.Navigate().GoToUrl("http://eaapp.somee.com/Account/Login"); 
           webDriver.Navigate().GoToUrl("http://eaapp.somee.com/"); //navigate to the site        }
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
        
    }
}
