using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Contracts
{
    public interface ICircle : IFigure
    {
        public double Radius { get; init; }
    }
}
