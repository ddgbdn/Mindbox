using Geometry.Contracts;
using Geometry.FigureArgs;

namespace Geometry.Figures
{
    public readonly struct Triangle : IFigure
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }

        public double Area
        {
            get
            {
                var p = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
        }

        public bool IsRight
        {
            get => Math.Abs(SideA * SideA + SideB * SideB - (SideC * SideC)) < 1e-5
                || Math.Abs(SideA * SideA + SideC * SideC - (SideB * SideB)) < 1e-5
                || Math.Abs(SideB * SideB + SideC * SideC - (SideA * SideA)) < 1e-5;
        }

        public Triangle() : this(1, 1, 1)
        {
        }

        public Triangle(TriangleArgs args) : this(args.SideA, args.SideB, args.SideC)
        {
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (!IsTriangleValid(firstSide, secondSide, thirdSide))
                throw new ArgumentOutOfRangeException();

            SideA = firstSide;
            SideB = secondSide;
            SideC = thirdSide;
        }

        private static bool IsTriangleValid(double a, double b, double c)
            => a > 0 && b > 0 && c > 0
            && (a + b >= c) && (a + c >= b) && (b + c >= a); // Допускаю вырожденные треугольники
    }
}