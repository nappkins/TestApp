using FigureProcessor.Shapes;

namespace FigureProcessor.Tests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void Calculate_Circle_Area_With_Valid_Parameters()
        {
            var circle = new Circle(5);
            var s = Math.PI * Math.Pow(5, 2);
            Assert.Equal(s, AreaCalculator.GetFigureArea(circle));
        }

        [Fact]
        public void Calculate_Circle_Area_With_Negative_Parameters()
        {
            var circle = new Circle(-5);
            Assert.Equal(0, AreaCalculator.GetFigureArea(circle));
        }

        [Fact]
        public void Calculate_Triangle_Area_With_Valid_Parameters() 
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.Equal(6, AreaCalculator.GetFigureArea(triangle));
        }

        [Fact]
        public void Calculate_Triangle_Area_With_Negative_Parameters()
        {
            var triangle = new Triangle(-3, 4, 5);

            Assert.Equal(0, AreaCalculator.GetFigureArea(triangle));
        }

        [Fact]
        public void Calculate_Triangle_Area_With_Invalid_Parameters()
        {
            var triangle = new Triangle(3, 4, 9);

            Assert.Equal(0, AreaCalculator.GetFigureArea(triangle));
        }

    }
}