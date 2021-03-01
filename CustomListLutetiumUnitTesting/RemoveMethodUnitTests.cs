using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;

namespace CustomListLutetiumUnitTesting
{
    [TestClass]
    public class RemoveMethodUnitTests
    {
        [TestMethod]
        public void Check_IndexOnList_RemovedOneIndex_HaveTwoExpectedBack()
        {
            CustomList<int> indexNumber = new CustomList<int>();

            // Arrange 
            int numberOne = 1;
            int numberTwo = 2;
            int numberThree = 3;
            int expected = 2;
            int actual;


            // Act
            indexNumber.Add(numberOne);
            indexNumber.Add(numberTwo);
            indexNumber.Add(numberThree);
            indexNumber.Remove(numberOne);
            actual = indexNumber[0];

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
            int expected = 2;
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
            int expected = 3;
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

        [TestMethod]
        public void Remove_Item_AtIndexTwo()
        {
            //Arrange
            CustomList<int> RemoveAtIndexTwo = new CustomList<int>();
            int numberOne = 1; // 0
            int numberTwo = 2; 
            int numberThree = 3;
            int numberFour = 4; 
            int expected = 3; // have 3 left over 
            int actual;
        
            //Act
            RemoveAtIndexTwo.Add(numberOne);
            RemoveAtIndexTwo.Add(numberTwo);
            RemoveAtIndexTwo.Add(numberThree);
            RemoveAtIndexTwo.Add(numberFour);
            RemoveAtIndexTwo.Remove(numberThree);

            actual = RemoveAtIndexTwo.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_TwoItems_ToList_ReturnSecondNumber()
        {
            CustomList<int> returnTwoItemsToList = new CustomList<int>();
            int numberOne = 1;
            int numberTwo = 2;
            int numberThree = 3;
            int numberFour = 4;
            int numberFive = 5;
            int expected = 3;
            int actual;

            returnTwoItemsToList.Add(numberOne);
            returnTwoItemsToList.Add(numberTwo);
            returnTwoItemsToList.Add(numberThree);
            returnTwoItemsToList.Add(numberFour);
            returnTwoItemsToList.Add(numberFive);
            returnTwoItemsToList.Remove(numberFive);
            returnTwoItemsToList.Remove(numberFour);

            actual = returnTwoItemsToList[2];

            Assert.AreEqual(expected, actual);


        }
    }
}
