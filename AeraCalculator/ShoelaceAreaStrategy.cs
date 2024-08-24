using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeraCalculator
{
    public class ShoelaceAreaStrategy: IAreaStrategy
    {
        public double CalculateArea(List<(double x, double y)> coordinates) 
        { 
            int n = coordinates.Count;
            double area = 0.0;
            for (int i = 0; i < n; i++)
            {
                int j = (i + 1) % n;
                area += coordinates[i].x * coordinates[j].y;
                area -= coordinates[j].x * coordinates[i].y;
            }
            return Math.Abs(area) / 2.0;
        }
    }
}
