using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(0, 0, 1)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 0, -1)]
        public void GetArea_NotEnoughInfo_ThrowsArgumentException(float hyp, float cat1, float cat2)
        {
            Assert.Throws<ArgumentException>(new TestDelegate(() => Triangle.GetArea(hyp, cat1, cat2)));
        }

        [Test]
        public void GetArea_CathetsAreSet_ReturnsExpectedArea()
        {
            Assert.AreEqual(9.0f, Triangle.GetArea(0, 6, 3));
        }

        [Test]
        public void GetArea_HypAndCat1AreSet_ReturnsExpectedArea()
        {
            var cat1 = 9.0f;
            var cat2 = 5.0f;
            var hyp = (float)Math.Sqrt(cat1 * cat1 + cat2 * cat2);
            Assert.That(
                Triangle.GetArea(hyp, cat1, 0), 
                Is.EqualTo(cat1 * cat2 * 0.5f).Within(0.001f));
        }

        [Test]
        public void GetArea_HypAndCat2AreSet_ReturnsExpectedArea()
        {
            var cat1 = 23.0f;
            var cat2 = 25.0f;
            var hyp = (float)Math.Sqrt(cat1 * cat1 + cat2 * cat2);
            Assert.That(
                Triangle.GetArea(hyp, 0, cat2), 
                Is.EqualTo(cat1 * cat2 * 0.5f).Within(0.001f));
        }
    }
}
