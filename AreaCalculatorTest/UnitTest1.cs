using Microsoft.VisualStudio.TestTools.UnitTesting;
using AeraCalculator;

namespace AreaCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void shoelaceStrategyTest()
        {
            var coordinates = new List<(double x, double y)>
            {
                (151.42, 376.52), (218.27, 519.73), (558.43, 564.43), (195.75, 628.85), (-33.95, 552.35), (151.42, 376.52),
            };

            IAreaStrategy shoelaceStrategy = new ShoelaceAreaStrategy();
            AreaCalculator calculator = new AreaCalculator(shoelaceStrategy);
            double area = calculator.CalculateArea(coordinates);

            Assert.AreEqual(51606.810200000036, area);
        }
    }
}