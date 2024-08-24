using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeraCalculator
{
    public interface IAreaStrategy
    {
        double CalculateArea(List<(double x, double y)> area);
    }
}
