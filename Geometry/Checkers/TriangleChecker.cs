using Geometry.Contracts;
using Geometry.FigureArgs;
using Geometry.Figures;

namespace Geometry.Checkers
{
    public class TriangleChecker : FigureFactoryBase<Triangle>
    {
        public override Triangle CreateFigure(IFigureArgs<Triangle> args)
        {
            if (args is not TriangleArgs triangleArgs)
                throw new ArgumentNullException(nameof(triangleArgs));

            return new Triangle(triangleArgs);
        }

        public bool IsRight(IFigureArgs<Triangle> args) => CreateFigure(args).IsRight;
    }
}
