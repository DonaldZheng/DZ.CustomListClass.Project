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
            
            int number = 4;
            int expected = 1;
            int actual;

            
            //Act
            collectionOfNumbers.Add(number);
            actual = collectionOfNumbers.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Item_CapacityIncreased()
        {
            //Arrange 
            CustomList<int> capacityItem = new CustomList<int>();
            capacityItem.Add(1);
            capacityItem.Add(2);
            capacityItem.Add(3);
            capacityItem.Add(4);
            capacityItem.Add(5);

            int itemsInCapacity = 8;
            int expected = 8;
            int actual;

            //Act USE a for loop to add item
            actual = capacityItem.Count;
            for (int i = 0; i < itemsInCapacity; i++)
            {
                capacityItem.Add(i);
            }
            //Assert 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Item_WasAdded()
        {
            // Arrange 

            // Act

            // Assert
        }
    }
}
