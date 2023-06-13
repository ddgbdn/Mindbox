using Geometry.Contracts;
using Geometry.FigureArgs;

namespace Geometry.Figures
{
    internal readonly struct Circle : ICircle
    {
        public double Radius { get; init; }

        public double Area
        {
            get => Math.PI * Radius * Radius;
        }

        public Circle() : this(1)
        {
        }

        public Circle(CircleArgs args) : this(args.Radius)
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