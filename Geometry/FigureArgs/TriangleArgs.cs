using Geometry.Contracts;
using Geometry.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.FigureArgs
{
    internal record TriangleArgs(double SideA, double SideB, double SideC) : IFigureArgs<ITriangle>;
}