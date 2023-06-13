using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Contracts
{
    public interface ITriangle : IFigure
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }

        public bool IsRight { get; }
    }
}
