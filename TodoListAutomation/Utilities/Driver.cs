using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListAutomation.Utilities {
    class Driver {

        private static RemoteWebDriver driver;

        //This method can be further developed to initiate the driver for a specific browser
        public static RemoteWebDriver getDriver() {

            var dc = new DesiredCapabilities();
            dc.SetCapability("app", @"C:\Program Files\todolist\Todolist.exe");
            var driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);
            return driver;
        }



        public static void closeDriver() {
            driver.Quit();
        }



        }
    }
