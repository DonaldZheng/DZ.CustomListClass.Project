using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;

namespace CustomListLutetiumUnitTesting
{

    class OverloadMethodToString
    {
        [TestMethod]
        public void String_ToEmpty_String()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = " ";
            string actual;


            //Act 
            actual = list.ToString();

            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
