using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SeleniumAssignment_Mishrit
{
    
    [TestClass]
    public class Test06_Payment
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
        public void chekout()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // add to cart
            IWebElement addToCart = driver.FindElement(By.XPath("//*[@id=\"add-to-cart-button-18\"]"));
            addToCart.Click();
            

            // Click on Shiping Cart
            IWebElement shipingCart = driver.FindElement(By.XPath("//*[@id=\"topcartlink\"]/a/span[1]"));
            shipingCart.Click();
            

            // Click on Term Of Service Option
            IWebElement termsOfService = driver.FindElement(By.XPath("//*[@id=\"termsofservice\"]"));
            termsOfService.Click();
            
            // Click on Checkout Button 
            IWebElement checkOut = driver.FindElement(By.Id("checkout"));
            checkOut.Click();
            

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
            
            IWebElement clickOnContinue = driver.FindElement(By.XPath("//*[@id=\"billing-buttons-container\"]/button[4]"));
            clickOnContinue.Click();


            // Shipping Method 
            
            IWebElement clickOnShippingMethodContinue = driver.FindElement(By.XPath("//*[@id=\"shipping-method-buttons-container\"]/button"));
            clickOnShippingMethodContinue.Click();

            
            IWebElement clickOnCreditCard = driver.FindElement(By.XPath("//*[@id=\"paymentmethod_1\"]"));
            clickOnCreditCard.Click();


            //Thread.Sleep(1000);
            IWebElement clickOnPaymentMethodContinue = driver.FindElement(By.XPath("//*[@id=\"payment-method-buttons-container\"]/button"));
            clickOnPaymentMethodContinue.Click();

            
            IWebElement enterCardHolderName = driver.FindElement(By.XPath("//*[@id=\"CardholderName\"]"));
            enterCardHolderName.Click();
            enterCardHolderName.SendKeys("Mr. Mishu");

            
            IWebElement enterCardNumber = driver.FindElement(By.XPath("//*[@id=\"CardNumber\"]"));
            enterCardNumber.Click();
            enterCardNumber.SendKeys("4956 1954 1499 7100");

            IWebElement selectYear = driver.FindElement(By.Id("ExpireYear"));
            selectYear.SendKeys("2030");

            IWebElement enterCardCode = driver.FindElement(By.XPath("//*[@id=\"CardCode\"]"));
            enterCardCode.Click();
            enterCardCode.SendKeys("897");

            IWebElement clickPaymentInformationContinue = driver.FindElement(By.XPath("//*[@id=\"payment-info-buttons-container\"]/button"));
            clickPaymentInformationContinue.Click();

            IWebElement clickOnConfirmOrderContinue = driver.FindElement(By.XPath("//*[@id=\"confirm-order-buttons-container\"]/button"));
            clickOnConfirmOrderContinue.Click();
        }
        
        [TestCleanup]
        public void TestCleanup()
        {
            Thread.Sleep(2000);
            driver.Close();
        }
        
    }

}
