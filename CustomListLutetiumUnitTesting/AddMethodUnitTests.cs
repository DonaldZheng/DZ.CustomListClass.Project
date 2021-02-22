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
        public void Check_IndexOnList_Added()
        {
            CustomList<int> indexNumber = new CustomList<int>();

            // Arrange 
            int number = 5;
            int expected = 5;
            int actual;


            // Act
            indexNumber.Add(number);
            actual = indexNumber[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

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
            int itemsInCapacity = 1;
            int itemsInCapacity2 = 2;
            int itemsInCapacity3 = 3;
            int itemsInCapacity4 = 4;
            int itemsInCapacity5 = 5;

            int expected = 8;
            int actual;

            //Act USE a for loop to add item
            capacityItem.Add(itemsInCapacity);
            capacityItem.Add(itemsInCapacity2);
            capacityItem.Add(itemsInCapacity3);
            capacityItem.Add(itemsInCapacity4);
            capacityItem.Add(itemsInCapacity5);

            actual = capacityItem.Capacity;

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Items_IncrementByFour()
        {
            CustomList<int> ItemsByFour = new CustomList<int>();
            int numberOne = 3;
            int numberTwo = 5;
            int expected = 4;
            int actual;

            ItemsByFour.Add(numberOne);
            ItemsByFour.Add(numberTwo);
            actual = ItemsByFour.Count;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_TwoItems_ToList_ReturnSecondNumber()
        {
            CustomList<int> returnTwoItemsToList = new CustomList<int>();
            int numberOne = 2;
            int numberTwo = 5;
            int expected = 5;
            int actual;

            returnTwoItemsToList.Add(numberOne);
            returnTwoItemsToList.Add(numberTwo);
            actual = returnTwoItemsToList[1]; // index 0 is 2 index 1 is 5

            Assert.AreEqual(expected, actual); 


        }
    }
}
