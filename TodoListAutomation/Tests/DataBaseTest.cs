using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListAutomation.Tests {
    class DataBaseTest {

        //This is a very basic database testing can be improved.
        public void databaseTest() {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=TodoListDB;Integrated Security=SSPI");
            conn.Open();
            string _sql = "SELECT ID,Name From Tasks";
            SqlCommand command = new SqlCommand(_sql,conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                Assert.AreEqual("your task name here", reader.GetString(0), reader.GetString(1)); // the values of reader.GetStrings can be changed according to the task you need to retrive from database
            }

            reader.Close();
            conn.Close();

        }




    }
}
