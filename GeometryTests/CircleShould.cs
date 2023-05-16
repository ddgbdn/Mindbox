using Geometry.Checkers;
using Geometry.FigureArgs;
using NUnit.Framework;

namespace Tests
{
    public class CircleShould
    {
        private readonly CircleChecker _checker = new CircleChecker();

        [TestCase(1, Math.PI)]
        [TestCase(2, 12.566370)]
        [TestCase(2.50505, 19.714359)]
        public void ReturnCorrectArea(double r, double expectedArea)
        {
            var args = new CircleArgs(r);
            var actualArea = _checker.GetArea(args);

            Assert.That(Math.Abs(expectedArea - actualArea), Is.LessThan(1e-5));
        }


        [TestCase(-1)]
        [TestCase(-0.00001)]
        public void ThrowIfIncorrect(double r)
        {
            var args = new CircleArgs(r);

            Assert.Throws<ArgumentOutOfRangeException>(() => _checker.GetArea(args));
        }
    }
}
