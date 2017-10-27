using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSED02ProjectMovies;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Database myDatabase = new Database();

        [TestMethod]
        public void SQLConnection()
        {
            string result = myDatabase.IssueMovie("1", "2", DateTime.Now);
            Assert.AreEqual(result, " is Successful");
        }

        [TestMethod]
        public void MovieCost()
        {
            myDatabase.MovieReleaseYear = 2016.ToString();

            int result = myDatabase.RentalCost();
            Assert.AreEqual(result, 5);
        }

    }
}
