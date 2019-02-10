using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNUnit.Library.Tests
{
    [TestFixture]
    class ExampleTest
    {
        [Test]
        public void ReturnFalseGivenSingleValue()
        {
            //Arrange

            //Act
            Maths add = new Maths();
            int expectedResult = add.Add(1, 2);

            //Assert
            Assert.IsFalse(false, "It should not be prime");
        }

        [Test]
        public void Return3GivenSingleValue()
        {
            Maths add = new Maths();
            int expectedResult = add.Add(1, 2);
            Assert.AreEqual(3, expectedResult, "The method addition is not correct");
        }

        #region Sample_TestCode
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(2)]
        public void Return3GivenMultipleValue(int value)
        //public void CheckMultiValues([values(2)] int value)
        {
            Maths add = new Maths();
            int expectedResult = add.Add(value, 2);

            Assert.AreEqual(3, expectedResult, "The method addition is not correct");
        }
        #endregion
    }
}





