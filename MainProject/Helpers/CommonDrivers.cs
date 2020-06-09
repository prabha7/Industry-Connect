using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.Drivers
{
    public class CommonDrivers
    {
        //common driver init
        public static IWebDriver driver
        {
            set;
            get;
        }
    }
}
