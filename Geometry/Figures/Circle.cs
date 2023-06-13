using Geometry.Contracts;

namespace Geometry.Figures
{
    public readonly struct Circle : IShape
    {
        public double Radius { get; init; }

        public double Area
        {
            get => Math.PI * Radius * Radius;
        }

        public Circle() : this(1)
        {
        }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException(nameof(radius));

            Radius = radius;
        }
    }
}