using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeraCalculator
{
    public class Test
    {
        public void Run()
        {
            IAreaStrategy shoelaceStrategy = new ShoelaceAreaStrategy();
            AreaCalculator calculator = new AreaCalculator(shoelaceStrategy);

            Console.WriteLine("Enter the number of coordinates:");
            int numCoordinates = int.Parse(Console.ReadLine());

            List<(double x, double y)> coordinates = new List<(double x, double y)>();
            for (int i = 0; i < numCoordinates; i++)
            {
                Console.WriteLine($"Enter x-coordinate for point {i + 1}:");
                double x = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter y-coordinate for point {i + 1}:");
                double y = double.Parse(Console.ReadLine());

                coordinates.Add((x, y));
            }

            double area = calculator.CalculateArea(coordinates);
            Console.WriteLine($"Area: {area}");
        }
    }
}
