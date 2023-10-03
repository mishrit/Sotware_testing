using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumAssignment_Mishrit
{
    [TestClass]
    public class Test01_ValidateLogin
    {
        IWebDriver Driver;
        string websiteLink = "https://demo.nopcommerce.com/";
        
        string validEmailId = "mishritc31@gmail.com";
        string validPassword = "8463819851";

        string invalidEmailId = "ishritc21@gmail.com";
        string invalidPassword = "1234567890";
        
        [TestInitialize]
        public void TestInitialize()
        {
            Driver=new ChromeDriver(".");
            Driver.Navigate().GoToUrl(websiteLink);
            Driver.Manage().Window.Maximize();  // Window Maximizing
        }
        [TestMethod]
        public void login_With_valid_Email_And_Password() 
        {
            IWebElement logIn = Driver.FindElement(By.LinkText("Log in"));
            logIn.Click();
            Thread.Sleep(1000);

            IWebElement emailId = Driver.FindElement(By.Id("Email"));
            emailId.SendKeys(validEmailId);
            Thread.Sleep(1000);

            IWebElement password = Driver.FindElement(By.Id("Password"));
            password.SendKeys(validPassword);
            Thread.Sleep(1000);

            IWebElement userLogin = Driver.FindElement(By.XPath("/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/div[2]/form/div[3]/button"));
            userLogin.Click();
            Thread.Sleep(1000);
   
        }
        
        [TestMethod]
        public void login_With_invalid_Email_And_Password()
        {
            IWebElement logIn = Driver.FindElement(By.LinkText("Log in"));
            logIn.Click();
            Thread.Sleep(1000);

            IWebElement emailId = Driver.FindElement(By.Id("Email"));
            emailId.SendKeys(invalidEmailId);
            Thread.Sleep(1000);

            IWebElement password = Driver.FindElement(By.Id("Password"));
            password.SendKeys(invalidPassword);
            Thread.Sleep(1000);

            IWebElement userLogin = Driver.FindElement(By.XPath("/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/div[2]/form/div[3]/button"));
            userLogin.Click();
            Thread.Sleep(1000);
        }
        
        [TestCleanup] 
        public void Cleanup()
        {
            Thread.Sleep(2000);
            Driver.Quit();
        }
        
    }

}
