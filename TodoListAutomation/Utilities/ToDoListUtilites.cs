using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListAutomation.UIModels;

namespace TodoListAutomation.Utilities {
    class ToDoListUtilites {


        public static void createTask(string taskName) {
            ToDoListModels.createTaskbtn.SendKeys(taskName);
            ToDoListModels.createTaskbtn.SendKeys(Keys.Enter);
        }

        public static void createTask(string taskName, string color) {
            ToDoListModels.createTaskbtn.SendKeys("Todays Task");
            ToDoListModels.selectColorBtn.Click();
            ToDoListModels.createTaskbtn.SendKeys(Keys.Enter);
        }


        public static IWebElement selectDate(string day) {
            ToDoListModels.calendarBtn.Click();
            IWebElement selectedDay = Driver.getDriver().FindElementByName(day);
            selectedDay.Click();

            return selectedDay;
        }
    }
}