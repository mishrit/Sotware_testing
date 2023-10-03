using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumAssignment_Mishrit
{
    [TestClass]
    public class Test02_ValidateSearchProduct
    {
        IWebDriver driver;
        string websiteLink = "https://demo.nopcommerce.com/";

        string productName = "HTC One M8 Android L 5.0 Lollipop";

        [TestInitialize]
        public void TestInitialize() 
        {
            driver = new ChromeDriver(".");
            driver.Navigate().GoToUrl(websiteLink);
            driver.Manage().Window.Maximize();  // Window Maximizing
        }

        [TestMethod]
        public void ValidateSearchProduct()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement searchProduct = driver.FindElement(By.Id("small-searchterms"));
            searchProduct.SendKeys(productName);
            Thread.Sleep(1000);

            IWebElement search = driver.FindElement(By.XPath("//*[@id=\"small-search-box-form\"]/button"));
            search.Click();
            Thread.Sleep(1000);
        }
        
        [TestCleanup] 
        public void TestCleanup()
        {
            Thread.Sleep(1000);
            driver.Quit();
        }
        
    }
}
