namespace Geometry.Contracts
{
    public abstract class FigureFactoryBase<T> where T : IFigure
    {
        public double GetArea(IFigureArgs<T> args) => CreateFigure(args).Area;

        //Фабричный метод
        internal abstract T CreateFigure(IFigureArgs<T> args);
    }
}