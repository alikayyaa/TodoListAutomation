using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListAutomation.Utilities;

namespace TodoListAutomation.UIModels {
    class ToDoListModels {


        public static IWebElement createTaskbtn => Driver.getDriver().FindElementByName("Create a task");  
        public static IWebElement result => Driver.getDriver().FindElementByName("Result"); //This locator does not actually exist its is for demo purposes
        public static IWebElement markCompletedBtn => Driver.getDriver().FindElementById("Mark Completed"); //This locator does not actually exist its is for demo purposes
        public static IWebElement toggleAallCompletedBtn => Driver.getDriver().FindElementById("Toggle all completed"); //This locator does not actually exist its is for demo purposes 
        public static IWebElement selectColorBtn => Driver.getDriver().FindElementById("Color select"); //This locator does not actually exist its is for demo purposes 
        public static IWebElement calendarBtn => Driver.getDriver().FindElementById("Calendar"); //This locator does not actually exist its is for demo purposes 




    }
}
