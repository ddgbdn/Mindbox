using Geometry.Calculators;
using NUnit.Framework;

namespace Tests
{
    public class CircleShould
    {
        private readonly CircleCalculator _checker = new CircleCalculator();

        [TestCase(1, Math.PI)]
        [TestCase(2, 12.566370)]
        [TestCase(2.50505, 19.714359)]
        public void ReturnCorrectArea(double raduis, double expectedArea)
        {
            var actualArea = _checker.GetArea(raduis);

            Assert.That(Math.Abs(expectedArea - actualArea), Is.LessThan(1e-5));
        }


        [TestCase(-1)]
        [TestCase(-0.00001)]
        public void ThrowIfIncorrect(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _checker.GetArea(radius));
        }
    }
}
