using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace SeleniumAssignment_Mishrit
{
	[TestClass]
	public class Test04_AddtoCart
    {
		IWebDriver driver;
		string websiteLink = "https://demo.nopcommerce.com/htc-one-m8-android-l-50-lollipop";

		[TestInitialize]
		public void TestInitialize()
		{
			driver = new ChromeDriver(".");
			driver.Navigate().GoToUrl(websiteLink);
            driver.Manage().Window.Maximize();  // Window Maximizing
            Thread.Sleep(1000);
        }
        [TestMethod]
        public void GetProductDetails()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement addToCart = driver.FindElement(By.XPath("//*[@id=\"add-to-cart-button-18\"]"));
            addToCart.Click();
            
            
            
            IWebElement shipingCart = driver.FindElement(By.XPath("//*[@id=\"topcartlink\"]/a/span[1]"));
            shipingCart.Click();
            Thread.Sleep(1000);
        }
        
        [TestCleanup]
        public void TestCleanup()
        {
            Thread.Sleep(2000);
            driver.Close();
        }
        
    }

}
