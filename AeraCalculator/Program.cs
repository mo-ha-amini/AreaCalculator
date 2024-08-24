using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeraCalculator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //double area(double[] x, double[] y)
            //{
            //    double A = 0.0;
            //    double B = 0.0;

            //    Console.WriteLine("----------------XY---------------");
            //    for (int i = 1; i < y.Length; i++)
            //    {
            //        Console.WriteLine(x[i - 1] * y[i]);
            //        A += (x[i - 1] * y[i]);
            //    }
            //    Console.WriteLine("----------------YX---------------");
            //    for (int i = 1; i < x.Length; i++)
            //    {
            //        Console.WriteLine(x[i] * y[i - 1]);
            //        B += (x[i] * y[i - 1]);
            //    }
            //    Console.WriteLine("----------------Sum---------------");
            //    Console.WriteLine(A);
            //    Console.WriteLine(B);
            //    Console.WriteLine("----------------Area---------------");
            //    Console.WriteLine((A - B) / 2);


            //    return (A - B) / 2;
            //}

            // double[] x = new double[6] { 18114.795, 18475.43, 18414.48, 18000.00, 17778.71, 18114.79, };
            //double[] y = new double[6] { 46136.622, 45971.169, 45682.896, 45555.000, 45920.053, 46136.622};

            //area(x, y);

            //double[] x = new double[6] { 151.42, 218.27, 558.43, 195.75, -33.95, 151.42 };
            //double[] y = new double[6] { 376.52, 519.73, 564.43, 628.85, 552.35, 376.52 };

            
            //area(x, y);

            var coordinates = new List<(double x, double y)>
            {
                (151.42, 376.52), (218.27, 519.73), (558.43, 564.43), (195.75, 628.85), (-33.95, 552.35), (151.42, 376.52),
            };

            IAreaStrategy shoelaceStrategy = new ShoelaceAreaStrategy();
            AreaCalculator calculator = new AreaCalculator(shoelaceStrategy);
            double area1 = calculator.CalculateArea(coordinates);

            Console.WriteLine($"Area: {area1}");
        }
    }
}


