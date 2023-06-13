using Geometry.Contracts;
using Geometry.FigureArgs;
using Geometry.Figures;

namespace Geometry.Calculators
{
    public class TriangleCalculator : FigureFactoryBase<ITriangle>
    {
        public double GetArea(double sideA, double sideB, double sideC) 
            => GetArea(new TriangleArgs(sideA, sideB, sideC));

        public bool IsRight(double sideA, double sideB, double sideC)
            => IsRight(new TriangleArgs(sideA, sideB, sideC));

        public bool IsRight(IFigureArgs<ITriangle> args) => CreateFigure(args).IsRight;

        internal override ITriangle CreateFigure(IFigureArgs<ITriangle> args)
        {
            if (args is not TriangleArgs triangleArgs)
                throw new ArgumentException(nameof(triangleArgs));

            return new Triangle(triangleArgs);
        }
    }
}
