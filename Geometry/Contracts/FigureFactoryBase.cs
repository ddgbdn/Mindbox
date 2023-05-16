namespace Geometry.Contracts
{
    public abstract class FigureFactoryBase<T> where T : IFigure
    {
        public abstract T CreateFigure(IFigureArgs<T> args);

        public double GetArea(IFigureArgs<T> args) => CreateFigure(args).Area;
    }
}