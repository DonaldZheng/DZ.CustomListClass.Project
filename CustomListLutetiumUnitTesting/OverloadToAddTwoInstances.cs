﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListLutetium;


namespace CustomListLutetiumUnitTesting
{
    [TestClass]
    // JJ and David said it's okay to have 3 UnitTesting here as well
    public class OverloadToAddTwoInstances // take values in two different list and make it one 
    {
        [TestMethod]
        public void AddTwoInstance_WithTwoList()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> totalOfTwoList;

            //Arrange 
            int expected = 6;
            int actual;

            //Act
            totalOfTwoList = listOne + listTwo;
            actual = totalOfTwoList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void AddTwoInstance_WithInstructors()
        {
            CustomList<string> instructorGroupOne = new CustomList<string>() { "JJ", "Brent", "Brett", "Charles" };
            CustomList<string> instructorGroupTwo = new CustomList<string>() { "Nevin", "Michael", "Pascal", "David" };
            //Arrange 
            CustomList<string> expected = new CustomList<string>() { "JJ", "Brent", "Brett", "Charles", "Nevin", "Michael", "Pascal", "David" };
            CustomList<string> actual;

            //Act
            actual = instructorGroupOne + instructorGroupTwo;

            //Assert 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddTwoInstance_SubtractNumbers_FromSecondList()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> listTwo = new CustomList<int>() { 1, 3, 5 };

            //Arrange 
            CustomList<int> expected = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> actual;

            //Act
            actual = listOne - listTwo;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusTwoInstance_WithListOneLonger()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 2, 3, 3, 4, 4, 5, 5, 6 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 3, 4, };

            // Arrange 
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 5,6 };
            CustomList<int> actual;

            // Act 
            actual = listOne - listTwo;

            //Assert 
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddTwoInstance_WithListTwoLonger()
        {
            CustomList<int> listOne = new CustomList<int>() { 2, 5 };
            CustomList<int> listTwo = new CustomList<int>() {1, 1, 1, 3, 3, 4, 5, 6, 8, 10, 20, 20 };

            // Arrange 
            CustomList<int> expected = new CustomList<int>() { 1, 1, 1, 2, 3, 3, 4, 5, 5, 6, 8, 10, 20, 20 };
            CustomList<int> actual;

            // Act 
            actual = listOne + listTwo;

            //Assert 
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddTwoInstance_ListTwoWithNothing()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 3, 4, 7, 8, 9, 15, 100};
            CustomList<int> listTwo = new CustomList<int>() { };

            // Arrange 
            CustomList<int> expected = new CustomList<int>() { 1, 3, 4, 7, 8, 9, 15, 100 };
            CustomList<int> actual;

            // Act 
            actual = listOne + listTwo;

            //Assert 
            Assert.AreEqual(expected, actual);

        }
    }
}
