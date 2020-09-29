using Microsoft.VisualStudio.TestTools.UnitTesting;
using Collections_and_Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_and_Enumerators.Tests
{
    [TestClass()]
    public class MyListTests
    {
        [TestMethod()]
        public void AddAtIndexTest()
        {
            // Arrange
            var list = new MyList<int>();

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.AddAtIndex(2, 7);

            // Assert
            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(7, list[2]);
            Assert.AreEqual(3, list[3]);
            Assert.AreEqual(4, list[4]);
            Assert.AreEqual(5, list.Length);
            Assert.AreEqual(8, list.Capacity);
        }

        [TestMethod()]
        public void RemoveFromIndexTest()
        {
            // Arrange
            var list = new MyList<int>();

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3); // To be removed
            list.Add(4);
            list.Add(5);
            list.RemoveAtIndex(2);
            list.Shrink();

            // Assert
            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(4, list[2]);
            Assert.AreEqual(5, list[3]);
            Assert.AreEqual(4, list.Length);
            Assert.AreEqual(list.Length, list.Capacity);
        }
    }
}