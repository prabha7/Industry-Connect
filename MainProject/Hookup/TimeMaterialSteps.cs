using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MainProject.Hookup
{
    [Binding]
    public class TimeMaterialSteps
    {
        IWebDriver driver;
        [Given(@"I have logged into the Turnup portal successfully")]
        public void GivenIHaveLoggedIntoTheTurnupPortalSuccessfully()
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
        
        [Given(@"I create a new Time and Material record")]
        public void GivenICreateANewTimeAndMaterialRecord()
        {
            
            //Creating instance of time and material
            TimeMaterial timematerial = new TimeMaterial(driver);
            timematerial.ClickCreatenew();
            timematerial.CreateNewRecord("jack1", "jack1Desc");

            timematerial.ValidateNewRecord("jack1", "jack1Desc");
        }
        
        [Given(@"I edit an existing Time and Material record")]
        public void GivenIEditAnExistingTimeAndMaterialRecord()
        {
            TimeMaterial timematerial = new TimeMaterial(driver);
            timematerial.EditNewRecord();
        }
        
        [Given(@"I create a new Time and Material with below (.*), testdec(.*)")]
        public void GivenICreateANewTimeAndMaterialWithBelowTestdec(string p0, String p1)
        {
            //Creating instance of home page
            Home homepage = new Home(driver);
            homepage.ClickAdministration();
            homepage.ClickTimeAndMaterials();
            //Creating instance of time and material
            TimeMaterial timematerial = new TimeMaterial(driver);
            timematerial.ClickCreatenew();
            timematerial.CreateNewRecord(p0, p1);

            timematerial.ValidateNewRecord(p0, p1);
        }
        
        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            driver.Close();
        }
        
        [Then(@"The record should be edited successfully")]
        public void ThenTheRecordShouldBeEditedSuccessfully()
        {
            driver.Close();
        }
    }
}
