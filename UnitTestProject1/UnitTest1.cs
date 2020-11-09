using Microsoft.VisualStudio.TestTools.UnitTesting;
using Compulsory_assigment;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTitle()
        {
            Book tBook; //tBook is the name of the object that we are about to test 

            tBook = new Book("AlexTheLion", "LeonTheLukovic", 50, "1234567890123");

            Assert.AreEqual(expected: "AlexTheLion",tBook.Title);
        }

        [TestMethod]
        public void TestAuthor()
        {
            Book tBook; //tBook is the name of the object that we are about to test 

            tBook = new Book("AlexTheLion", "LeonTheLukovic", 50, "1234567890123");

            Assert.AreEqual(expected: "LeonTheLukovic", tBook.Author);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestError()
        {
            Book tBook = new Book("M2", "0", 1001, "14");
        }
    }
}
