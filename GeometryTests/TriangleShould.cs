using Geometry.Figures;
using NUnit.Framework;

namespace Tests
{
    class TriangleCheckerShould
    {
        [TestCase(5, 2, 3, 0)]
        [TestCase(10, 6, 8, 24)]
        [TestCase(1, 1, 1, 0.4330127018922193)]
        [TestCase(2.00001, 3.10001, 3.23815, 3)]
        public void ReturnCorrectArea(double sideA, double sideB, double sideC, double expectedArea)
        {
            var actualArea = new Triangle(sideA, sideB, sideC).Area;

            Assert.That(Math.Abs(expectedArea - actualArea), Is.LessThan(1e-5));
        }

        [TestCase(6, 2, 3)]
        [TestCase(2, 2, 0)]
        [TestCase(-1, -2, 3)]
        [TestCase(-1.00023, 2.53, 0.2)]
        public void ThrowIfIncorrect(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(5, 3, 7, false)]
        [TestCase(1.5, 2, 2.5, true)]
        [TestCase(1, 2, 2.5, false)]
        public void IndicateRightnessCorrectly(double sideA, double sideB, double sideC, bool isRight)
        {
            Assert.That(new Triangle(sideA, sideB, sideC).IsRight, Is.EqualTo(isRight));
        }
    }
}
