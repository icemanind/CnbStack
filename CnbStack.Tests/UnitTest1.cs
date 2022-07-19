using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using ConsoleApp4;

namespace CnbStack.Tests
{
    [TestClass]
    public class CnbStackTests
    {
        [TestMethod]
        public void PushAndPop()
        {
            var stack = new MinStack();

            stack.Push(15);
            Assert.AreEqual(15, stack.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PopEmptyStackShouldThrowException()
        {
            var stack = new MinStack();

            stack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GetMinEmptyStackShouldThrowException()
        {
            var stack = new MinStack();

            stack.GetMin();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GetTopEmptyStackShouldThrowException()
        {
            var stack = new MinStack();

            stack.Top();
        }

        [TestMethod]
        public void LargeStackShouldResize()
        {
            var stack = new MinStack();

            for (int i = 1; i <= 50; i++)
            {
                stack.Push(i);
            }

            for (int i = 50; i >= 1; i--)
            {
                Assert.AreEqual(i, stack.Pop());
            }
        }

        [TestMethod]
        public void LargeStackPerformance()
        {
            var stack = new MinStack();
            var sw = new Stopwatch();

            // Pushing and Popping 10 million records in
            // under a second should be acceptable performance.
            const int numberOfRecords = 10000000;
            const int numberOfMilliseconds = 1000;

            sw.Start();
            for (int i = 1; i <= numberOfRecords; i++)
            {
                stack.Push(i);
            }

            for (int i = numberOfRecords; i >= 1; i--)
            {
                Assert.AreEqual(i, stack.Pop());
            }

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds < numberOfMilliseconds);
        }

        [TestMethod]
        public void GetMinShouldReturnSmallestValue()
        {
            var stack = new MinStack();
            var rnd = new Random();

            const int numberOfIterations = 500;

            int location = rnd.Next(1, numberOfIterations + 1);

            for (int i = 1; i <= numberOfIterations; i++)
            {
                if (i == location)
                {
                    stack.Push(-1);
                }
                else
                {
                    stack.Push(i);
                }
            }

            Assert.AreEqual(-1, stack.GetMin());
        }

        [TestMethod]
        public void GetTopShouldReturnTopValue()
        {
            var stack = new MinStack();

            for (int i = 1; i <= 50; i++)
            {
                stack.Push(i);
            }

            for (int i = 50; i >= 1; i--)
            {
                Assert.AreEqual(i, stack.Top());
                Assert.AreEqual(i, stack.Pop());
            }
        }
    }
}
