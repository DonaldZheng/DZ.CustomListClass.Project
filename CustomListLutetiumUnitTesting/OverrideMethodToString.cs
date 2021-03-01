using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;

namespace CustomListLutetiumUnitTesting
{
    [TestClass]

    public class OverrideMethodToString // Charles said it's okay to have 3 examples and move on to my ToString Method in CustomList
    {
        [TestMethod]
        public void String_ToEmpty_String()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "";
            string actual;

            //Act 
            actual = list.ToString();

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringTo_FourNumbers()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "1, 2, 3, 4"; // account for commas and space 
            string actual;

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringTo_EightNumbers_UsingForLoop()
        {
            //Arrange
            int item = 8;
            CustomList<int> list = new CustomList<int>();
            string expected = "1, 2, 3, 4, 5, 6, 7, 8";
            string actual;

            //Act
            for (int i = 0; i < item; i++)
            {
                list.Add(i);
            }
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
