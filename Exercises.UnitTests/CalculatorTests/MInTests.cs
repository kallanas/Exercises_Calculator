using NUnit.Framework;
using System.Collections.Generic;

namespace Exercises.UnitTests
{
    [TestFixture]
    public class MinTests
    {
        [Test]
        public void MinNumber_WithListOfInt_ReturnMin()
        {
            var result = Calculator.Min(new List<int> { 7, 8, 8, 9, 3, 2, 6, 4 });
            Assert.That(result == 2);
        }

        [Test]
        public void MinNumber_WithOneItem_ReturnItem()
        {
            var result = Calculator.Min(new List<int> { 7 });
            Assert.That(result == 7);
        }

        [Test]
        public void MinNumber_WithEmptyList_ReturnNull()
        {
            var result = Calculator.Min(new List<int> { });
            Assert.That(result == null);
        }

        [Test]
        public void MinNumber_WithNull_ReturnNull()
        {
            var result = Calculator.Min(null);
            Assert.That(result == null);
        }
    }
}