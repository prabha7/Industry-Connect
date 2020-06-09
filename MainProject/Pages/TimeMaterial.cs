using MainProject.Base_Class;
using MainProject.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using System;
using System.Threading;
using TechTalk.SpecFlow.Bindings.Discovery;

namespace MainProject
{
    internal class TimeMaterial:CommonDrivers
    {
        //private IWebDriver driver;

         //int i=0;

        //public TimeMaterial(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        internal void ClickCreatenew()
        {
            try
            {
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
                Console.WriteLine("Assertion Pass");
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
            
        }

        internal void NewRecord(String code, String description)
        {
            Assert.That(driver.FindElement(By.XPath("//*[@id='container']/h2")).Text, Is.EqualTo("Time and Materials"));
            //Find Code button
            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.Clear();
            Code.SendKeys(code);

            //Find description button and entering value//
            IWebElement Description = driver.FindElement(By.XPath("//input[contains(@id,'Description')]"));
            Description.Clear();
            Description.SendKeys(description);

            //Finding pricePerUnit and entering value//

            IWebElement pricePerUnit = driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]"));
            pricePerUnit.Clear();
            pricePerUnit.SendKeys("7000");
            //finding  save button and then click
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            
            Console.WriteLine("Created Successfully");

        }

       /* internal void ValidateNewRecord(String code, String description)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
                    try
                    {
                        while (true)
                        {
                            for (i = 1; i <= 10; i++)
                            {
                                var Code = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[" + i + "]/td[1]"));


                                var testDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[" + i + "]/td[3]")).Text;

                        

                                // logic to compare the one we wanted

                                if (Code.Text == code && testDescription == description)
                                {
                                  
                            //Assert.That(Code.Text, Is.EqualTo(code));
                            Console.WriteLine("Test Passed");
                                    Console.WriteLine("i=" +i);
                              
                                    return;
                                }

                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Test Failed");
                    }
                }*/
                
        internal void ValidateNewRecord(String code, String description)
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            var Code = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            var testDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]")).Text;

            // logic to compare the one we wanted
            Assert.That(Code.Text, Is.EqualTo(code));
        } 


        internal void CreateNewRecord(String code, String description)
        {
            NewRecord(code, description);
        }

        internal void EditNewRecord()
        {      
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id='container']/h2")).Text, Is.EqualTo("Time and Materials"));             
            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.Clear();
            Code.SendKeys("Jay");
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
        }
        
      /*  internal void EditNewRecord(String code, String description)
        {

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            for (i = 1; i <= 10; i++)
            {
                var Code = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[" + i + "]/td[1]"));


                var testDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[" + i + "]/td[3]")).Text;

                // logic to compare the one we wanted

                if (Code.Text == code && testDescription == description)
                {
                    driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[" + i + "]/td[5]/a[1]")).Click();
                    IWebElement Code1 = driver.FindElement(By.Id("Code"));
                    Code1.Clear();
                    Code1.SendKeys("Jay");
                    driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
                    break;
                }

            }
                 
            
        }
        
    */
        internal void DeleteNewRecord()
        {
            try
            {
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
               // Assert.Pass();
            }
            catch(Exception ex)
            {
                Assert.Fail();
            }
            
        }

    }
}
