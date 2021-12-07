using NUnit.Framework;
using System.Collections.Generic;

namespace Exercises.UnitTests
{
    [TestFixture]
    public class AverageTests
    {
        [Test]
        public void Average_WithListOfInt_ReturnAvg()
        {
            var result = Calculator.Average(new List<int> { 1, 4, 6, 8 });
            Assert.That(result == 4.75);
        }

        [Test]
        public void Average_WithOneItem_ReturnItem()
        {
            var result = Calculator.Average(new List<int> { 8 });
            Assert.That(result == 8);
        }

        [Test]
        public void Average_WithEmptyList_ReturnNull()
        {
            var result = Calculator.Average(new List<int> { });
            Assert.That(result == null);
        }

        [Test]
        public void Average_WithNull_ReturnNull()
        {
            var result = Calculator.Average(null);
            Assert.That(result == null);
        }
    }
}