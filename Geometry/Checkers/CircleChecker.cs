using Geometry.Contracts;
using Geometry.FigureArgs;
using Geometry.Figures;

namespace Geometry.Checkers
{
    public class CircleChecker : FigureFactoryBase<Circle>
    {
        public override Circle CreateFigure(IFigureArgs<Circle> args)
        {
            if (args is not CircleArgs circleArgs)
                throw new ArgumentNullException(nameof(circleArgs));

            return new Circle(circleArgs);
        }
    }
}
