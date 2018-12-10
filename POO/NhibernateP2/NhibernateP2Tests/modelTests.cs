using Microsoft.VisualStudio.TestTools.UnitTesting;
using NhibernateP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateP2.Tests
{
    [TestClass()]
    public class modelTests
    {
        [TestMethod()]
        public void TestTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AdditionTest()
        {
            //arrange
            int a = 1;
            int b = 2;
            int expected = a + b;

            //act
            var testModel = new model();
            int actual = testModel.Addition(1, 2);

            //assert
            Assert.AreEqual(expected, actual, "La valeur doit être égale à 3");
        }
    }
}