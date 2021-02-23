using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;

namespace CustomListLutetiumUnitTesting
{
    [TestClass]
    class RemoveMethodUnitTests
    {
        [TestMethod]
        public void Check_IndexOnList_Removed()
        {
            CustomList<int> indexNumber = new CustomList<int>();

            // Arrange 
            int number = 3;
            int expected = 3;
            int actual;


            // Act
            indexNumber.Remove(number);
            actual = indexNumber[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
