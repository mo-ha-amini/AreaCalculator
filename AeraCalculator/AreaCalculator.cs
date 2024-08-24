using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeraCalculator
{
    internal class AreaCalculator
    {
        private IAreaStrategy _strategy;
        public AreaCalculator(IAreaStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IAreaStrategy strategy)
        {
            _strategy = strategy;
        }

        public double CalculateArea(List<(double x, double y)> coordinates)
        {
            return _strategy.CalculateArea(coordinates);
        } 
    }
}
