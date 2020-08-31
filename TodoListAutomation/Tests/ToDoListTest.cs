using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoListAutomation.UIModels;
using TodoListAutomation.Utilities;
using Assert = NUnit.Framework.Assert;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace TodoListAutomation {
    [TestClass]
    public class ToDoListTest : Base{

        [Test]
        public void createTastTest() {
            ToDoListUtilites.createTask("First Task");
            string expected = "First Task";
            string actual = ToDoListModels.result.Text;
            Assert.AreEqual(expected, actual);
        }


        public void markCompleteTest() {
            ToDoListUtilites.createTask("Second Task");
            ToDoListModels.markCompletedBtn.Click();
            Assert.IsTrue(ToDoListModels.markCompletedBtn.Selected);
        }

        
        public void toggleAllCompletedTest() {
            ToDoListUtilites.createTask("Third Task");
            ToDoListUtilites.createTask("Fourth Task");
            ToDoListModels.toggleAallCompletedBtn.Click();
            ReadOnlyCollection<IWebElement> markbuttons = Driver.getDriver().FindElementsById("Mark Completed");
            foreach(IWebElement markbutton in markbuttons) {
                Assert.IsTrue(markbutton.Selected);
            }
        }


        public void chooseColorTest() {
            ToDoListModels.createTaskbtn.SendKeys("Todays Task");
            ToDoListModels.selectColorBtn.Click();
            ToDoListModels.createTaskbtn.SendKeys(Keys.Enter);
            IList<IWebElement> colorList = Driver.getDriver().FindElementsById("Color list");
            string expected = colorList[1].Text;
            string actual = "red";
            Assert.AreEqual(expected, actual);
        }

        public void selectDayTest() {
            IWebElement day = ToDoListUtilites.selectDate("25");
            Assert.IsTrue(day.Selected);
        }




    }
}
