# MindBox

Задание:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

    Юнит-тесты

    Легкость добавления других фигур

    Вычисление площади фигуры без знания типа фигуры в compile-time

    Проверку на то, является ли треугольник прямоугольным


Требуемая логика заключена в классах соответсвующих классах "Checker"

Юнит-тесты присутсвуют

Для добавления фигуры потребуется создать класс фигуры, унаследованный от IFigure. Класс аргументов, соотвествующих этой фигуре, унаследованный от IFigureArgs<T> и класс "Checker", унаследованный от FigureFactorybase<T>
  
FigureFactoryBase<T> имеет ограничение T : IFigure, следовательно мы можем получить площадь любой реализованной фигуры
  
Класс TriangleChecker расширяет FigureFactoryBase методом IsRight, который позволяет проверить треугольник на прямоугольность
  

Допускаю, что фабричный метод в данном случае оверкилл   
