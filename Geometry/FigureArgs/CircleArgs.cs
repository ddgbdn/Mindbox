using Geometry.Contracts;
using Geometry.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.FigureArgs
{
    public record CircleArgs(double Radius) : IFigureArgs<Circle>;
}