namespace LinkedQueue.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _01.LinkedQueue;

    [TestClass]
    public class LinkedQueueTests
    {
        [TestMethod]
        public void DequeueTest_ShouldReturnExpectedElement()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();

            queue.Enqueue(45);
            var item = queue.Dequeue();

            Assert.AreEqual(45, item, "Dequeued item is not the same as expected");
        }

        [TestMethod]
        public void DequeueTest_CheckTheExpectedCount()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();

            queue.Enqueue(45);
            queue.Enqueue(32);
            queue.Enqueue(1);

            Assert.AreEqual(3, queue.Count, "Count is not the same as expected after the Enqueue");
        }

        [TestMethod]
        public void DequeueTest_CheckTheExpectedCountAfterDequeue()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();

            queue.Enqueue(45);
            queue.Enqueue(32);
            queue.Enqueue(1);
            queue.Enqueue(143);
            queue.Enqueue(57);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.AreEqual(2, queue.Count, "Count is not the same as expected after the Dequeue");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DequeueTestInEmptyQueue()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            queue.Dequeue();
        }
    }
}