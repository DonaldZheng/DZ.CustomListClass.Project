using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;

namespace CustomListLutetiumUnitTesting
{
    [TestClass]
    public class AddMethodUnitTests
    {
        // checking the index of the item on your CustomList<T> to make sure it was added
        // check the count of the list to see if it was added
        // check the capacity of our list to make sure it increases when we add an item beyond the original capacity

        [TestMethod]
        public void Add_Item_CountIncreasesByOne()
        {
            // Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            
            int number = 9;
            int expected = 1;
            int actual;

            // Act
        

            collectionOfNumbers.Add(number);
            actual = collectionOfNumbers.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // make a commit
        // Finished first Add method test in AddMethodUnitTests class to test that the count increases by one when an item is added to the list

        // write next test - get it failing
        // make a commit 
    }
}
