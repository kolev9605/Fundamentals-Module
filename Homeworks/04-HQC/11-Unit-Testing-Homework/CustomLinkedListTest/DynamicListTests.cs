namespace CustomLinkedListTest
{
    using System;
    using CustomLinkedList;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DynamicListTests
    {
        [TestMethod]
        public void CountTest()
        {
            DynamicList<int> list = new DynamicList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Assert.AreEqual(3, list.Count, "Count does not count the elements correctly");
        }

        [TestMethod]
        public void IndexTest()
        {
            DynamicList<int> list = new DynamicList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Assert.AreEqual(3, list[2], "List indexation is incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexTest_NegativeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            DynamicList<int> list = new DynamicList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            var element = list[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexTest_IndexOutOfRange_ShouldThrowArgumentOutOfRangeException()
        {
            DynamicList<int> list = new DynamicList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            var element = list[5];
        }

        [TestMethod]
        public void AddTest()
        {
            DynamicList<int> list = new DynamicList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Assert.AreEqual(3, list[2], "List does not add items correctly");
        }

        [TestMethod]
        public void RemoveAtTest()
        {
            DynamicList<int> list = new DynamicList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.RemoveAt(0);
            Assert.AreNotEqual(1, list[0], "List does not remove items ");
        }

        [TestMethod]
        public void RemoveTest()
        {
            DynamicList<int> list = new DynamicList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Remove(3);

            Assert.IsFalse(list.Contains(3), "List does not remove items correctly");
        }

        [TestMethod]
        public void IndexOfTest()
        {
            DynamicList<int> list = new DynamicList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            var result = list.IndexOf(3);

            Assert.AreEqual(2, result, "Index of does not search the list correctly");
        }

        [TestMethod]
        public void ContainsTest()
        {
            DynamicList<int> list = new DynamicList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            var result = list.Contains(2);

            Assert.IsTrue(result, "List does not search correctly");
        }
    }
}