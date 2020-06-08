using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
namespace MainProject
{
    class Home
    {
        private IWebDriver driver;

        public Home(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Click Administration 
        internal void ClickAdministration()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
        }

        //Click Time and Material
        internal void ClickTimeAndMaterials()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }

    }
}
