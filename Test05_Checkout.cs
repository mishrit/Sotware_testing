using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
namespace SeleniumAssignment_Mishrit
{
    [TestClass]
    public class Test05_Checkout
    {
        IWebDriver driver;
        string websiteLink = "https://demo.nopcommerce.com/htc-one-m8-android-l-50-lollipop";

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver(".");
            driver.Navigate().GoToUrl(websiteLink);
            driver.Manage().Window.Maximize();  // Window Maximizing
            Thread.Sleep(100);
        }
        [TestMethod]
        public void chekout()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // add to cart
            IWebElement addToCart = driver.FindElement(By.XPath("//*[@id=\"add-to-cart-button-18\"]"));
            addToCart.Click();
            

            // Click on Shiping Cart
            IWebElement shipingCart = driver.FindElement(By.XPath("//*[@id=\"topcartlink\"]/a/span[1]"));
            shipingCart.Click();
            Thread.Sleep(100);

            // Click on Term Of Service Option
            IWebElement termsOfService = driver.FindElement(By.XPath("//*[@id=\"termsofservice\"]"));
            termsOfService.Click();
            Thread.Sleep(100);

            // Click on Checkout Button 
            IWebElement checkOut = driver.FindElement(By.Id("checkout"));
            checkOut.Click();
            Thread.Sleep(100);

            // After Checkout Login with valid credentials

            string validEmailId = "mishritc31@gmail.com";
            string validPassword = "8463819851";

            IWebElement emailId = driver.FindElement(By.Id("Email"));
            emailId.SendKeys(validEmailId);

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys(validPassword);

            IWebElement userLogin = driver.FindElement(By.XPath("/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/div[2]/form/div[3]/button"));
            userLogin.Click();
            


            // After login Click on Term Of Service Option
            IWebElement termsOfService2 = driver.FindElement(By.XPath("//*[@id=\"termsofservice\"]"));
            termsOfService2.Click();
            

            // After login Click on Checkout Button 
            IWebElement checkOut2 = driver.FindElement(By.Id("checkout"));
            checkOut2.Click();

            IWebElement selectCity = driver.FindElement(By.Id("BillingNewAddress_CountryId"));
            selectCity.SendKeys("India");
            

            IWebElement city = driver.FindElement(By.XPath("//*[@id=\"BillingNewAddress_City\"]"));
            city.Click();
            city.SendKeys("Vadodara");
            

            IWebElement address = driver.FindElement(By.XPath("//*[@id=\"BillingNewAddress_Address1\"]"));
            address.Click();
            address.SendKeys("Notus Pride IT Park Civica Vadodara");
            

            IWebElement zip_PostalCode = driver.FindElement(By.XPath("//*[@id=\"BillingNewAddress_ZipPostalCode\"]"));
            zip_PostalCode.Click();
            zip_PostalCode.SendKeys("123456");
            

            IWebElement enterPhoneNumber = driver.FindElement(By.XPath("//*[@id=\"BillingNewAddress_PhoneNumber\"]"));
            enterPhoneNumber.Click();
            enterPhoneNumber.SendKeys("1234567891");
            


            IWebElement clickOnContinue = driver.FindElement(By.XPath("//*[@id=\"billing-buttons-container\"]/button[4]"));
            clickOnContinue.Click();
            Thread.Sleep(1000);

            
            IWebElement clickOnShippingMethodContinue = driver.FindElement(By.XPath("//*[@id=\"shipping-method-buttons-container\"]/button"));
            clickOnShippingMethodContinue.Click();
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
