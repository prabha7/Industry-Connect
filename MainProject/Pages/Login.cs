using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
namespace MainProject
{
    internal class Login
    {
        //private IWebDriver driver;

        //IWebElement UserName => driver.FindElement(By.XPath(("//*[@id='UserName']")));
        //IWebElement Password => driver.FindElement(By.XPath("//*[@id='Password']"));
        //IWebElement LoginBtn => driver.FindElement(By.XPath("//input[@type='submit']"));


        //public Login(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        public void LoginSuccess(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //  driver.Manage().Window.Maximize();
            // enter hari as username
            driver.FindElement(By.XPath("//*[@id='UserName']")).SendKeys("hari");
            //identfying password & sending password
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("123123");
            //clicked login btn
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }

        public void Loginfailure(IWebDriver driver)
        {
            //Identify username and enter user name as hari
            driver.FindElement(By.XPath("//*[@id='UserName']")).SendKeys("hari");

            //identfying password & sending password
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("123123");
        }

    }
}