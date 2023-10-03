using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SeleniumAssignment_Mishrit
{
    [TestClass]
    public class Test03_ProductDetails
    {
        IWebDriver driver;
        string websiteLink = "https://demo.nopcommerce.com/htc-one-m8-android-l-50-lollipop";

        [TestInitialize] 
        public void TestInitialize()
        {
            driver = new ChromeDriver(".");
            driver.Navigate().GoToUrl(websiteLink);
            driver.Manage().Window.Maximize();  // Window Maximizing
        }
        
        [TestMethod]
        public void GetProductDetails()
        {
            Thread.Sleep(1000);
        }
        
        [TestCleanup]
        public void TestCleanup()
        {
            Thread.Sleep(1000);
            driver.Close();
        }
    }

}
