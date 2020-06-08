using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace MainProject
{
    [TestFixture]
   
    class Program
    {
        IWebDriver driver;

        [SetUp]
        public void Login()
        {
            //Basic login code
            driver = new ChromeDriver();
            //Creating instance of Login Page
            Login loginpage = new Login(driver);
            loginpage.LoginSuccess();

            //Creating instance of home page
            Home homepage = new Home(driver);
            homepage.ClickAdministration();
            homepage.ClickTimeAndMaterials();
        }

        [Test, Order(1)]
        [TestCaseSource(typeof(TestDataClass), "TestCases")]
        public void AddTMTest(String code, String description)
        {
            //Creating instance of time and material
            TimeMaterial timematerial = new TimeMaterial(driver);
            timematerial.ClickCreatenew();
            timematerial.CreateNewRecord(code, description);

            timematerial.ValidateNewRecord(code, description);
            
        }
        [Test, Order(2)]
        public void EditTMTest()
        {
            TimeMaterial timematerial = new TimeMaterial(driver);
            timematerial.EditNewRecord();

        }


        [Test]
        public void DeleteTMTest()
        {
            TimeMaterial timematerial = new TimeMaterial(driver);
            timematerial.DeleteNewRecord();
        }

        [TearDown]
        public void Closing()
        {
            Thread.Sleep(3000);
            driver.Close();
           
        }



    }



}
