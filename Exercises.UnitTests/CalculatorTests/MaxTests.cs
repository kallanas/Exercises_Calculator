using NUnit.Framework;
using System.Collections.Generic;

namespace Exercises.UnitTests
{
    [TestFixture]
    public class MaxTests
    {
      
        [Test]
        public void MaxNumber_WithListOfInt_ReturnMax()
        {
            var result = Calculator.Max(new List<int> { 1, 4, 6, 9 });
            Assert.That(result == 9);
        }

        [Test]
        public void MaxNumber_WithOneitem_ReturnItem()
        {
            var result = Calculator.Max(new List<int> { 6 });
            Assert.That(result == 6);
        }

        [Test]
        public void MaxNumber_WithEmptyList_ReturnNull()
        {
            var result = Calculator.Max(new List<int> { });
            Assert.That(result == null);
        }

        [Test]
        public void MaxNumber_WithNull_ReturnNull()
        {
            var result = Calculator.Max(null);
            Assert.That(result == null);
        }
    }
}