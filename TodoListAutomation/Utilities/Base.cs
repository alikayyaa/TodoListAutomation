using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListAutomation.Utilities {
    public class Base {


        public RemoteWebDriver driver;
        public Actions action;

        [SetUp]
        public void setup() {

            driver = Driver.getDriver();
            action = new Actions(driver);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //driver.Manage().Window.Maximize();
            
        }

        [TearDown]
        public void teardown() {
            Driver.closeDriver();
        }


    }
}
