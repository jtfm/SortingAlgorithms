using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SortingAlgorithms.Algorithms;

namespace SortingAlgorithms.Tests
{
    public class BubbleSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanSortTwoIntegers()
        {
            var sut = new BubbleSorter();
            Assert.Throws<ArgumentNullException>(() => sut.Sort(null));
        }

        [Test]
        public void CanSortTwoIntegers()
        {
            var input = new List<int> { 2, 1 };
            var expected = new List<int> { 1, 2 };

            var sut = new BubbleSorter();
            List<int> actual = sut.Sort(input);
            Assert.That(actual.SequenceEqual(expected));
        }

        [Test]
        public void CanSortThreeIntegers()
        {
            Assert.Fail();
        }
    }
}