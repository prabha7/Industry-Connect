using MainProject.Drivers;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MainProject.Base_Class
{
    class TestBase:CommonDrivers
    {
       //public static IWebDriver driver;

        [OneTimeSetUp]
        public void Login()
        {
            //Basic login code
            driver = new ChromeDriver();
            //Creating instance of Login Page
            Login loginpage = new Login();
            loginpage.LoginSuccess(driver);

            //Creating instance of home page
            Home homepage = new Home();
            homepage.ClickAdministration(driver);
            homepage.ClickTimeAndMaterials(driver);
        }

        [OneTimeTearDown]
        public void Closing()
        {
            Thread.Sleep(3000);
            driver.Close();

        }
    }
}
