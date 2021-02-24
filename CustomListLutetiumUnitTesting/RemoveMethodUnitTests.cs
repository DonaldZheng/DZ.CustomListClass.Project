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
            actual = indexNumber[1];

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_Item_CountDecreasedByOne()
        {
            // Arrange
            CustomList<int> itemsToRemove = new CustomList<int>();
            int numberOne = 1;
            int numberTwo = 2;
            int numberThree = 3;
            int expected = 1;
            int actual;


            //Act
            itemsToRemove.Add(numberOne);
            itemsToRemove.Add(numberTwo);
            itemsToRemove.Add(numberThree);
            itemsToRemove.Remove(numberTwo);
            actual = itemsToRemove.Count;

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_Items_DecrementByThree()
        {
            CustomList<int> ItemsByFour = new CustomList<int>();
            int numberOne = 1;
            int numberTwo = 2;
            int numberThree = 3;
            int numberFour = 4;
            int numberFive = 5;
            int numberSix = 6;
            int expected = 4;
            int actual;
            
            //add
            ItemsByFour.Add(numberOne);
            ItemsByFour.Add(numberTwo);
            ItemsByFour.Add(numberThree);
            ItemsByFour.Add(numberFour);
            ItemsByFour.Add(numberFive);
            ItemsByFour.Add(numberSix);

            //remove 
            ItemsByFour.Remove(numberFour);
            ItemsByFour.Remove(numberFive);
            ItemsByFour.Remove(numberSix);


            actual = ItemsByFour.Count;

            Assert.AreEqual(expected, actual);

        }

        // no capacity 
        // remove [1] at which index 
    }
}
