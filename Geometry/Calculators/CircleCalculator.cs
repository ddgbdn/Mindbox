using Geometry.Contracts;
using Geometry.FigureArgs;
using Geometry.Figures;

namespace Geometry.Calculators
{
    public class CircleCalculator : FigureFactoryBase<ICircle>
    {
        public double GetArea(double radius) => GetArea(new CircleArgs(radius));

        internal override ICircle CreateFigure(IFigureArgs<ICircle> args)
        {
            if (args is not CircleArgs circleArgs)
                throw new ArgumentException(nameof(circleArgs));

            return new Circle(circleArgs);
        }
    }
}


