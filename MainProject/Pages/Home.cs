using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
namespace MainProject
{
    class Home
    {
        //private IWebDriver driver;

        //public Home(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        //Click Administration 
        internal void ClickAdministration(IWebDriver driver)
        {
            Assert.AreEqual("Administration", driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Text);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
        }

        //Click Time and Material
        internal void ClickTimeAndMaterials(IWebDriver driver)
        {
            Assert.AreEqual("Time & Materials", driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Text);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }

    }
}
