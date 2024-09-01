using SquareLib.Model;

namespace SquareTestLib
{
    public class SquareTest
    {
        [Fact]
        public void SquareTriangleTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            SquareLib.Square square = new SquareLib.Square();

            double result = (double)square.TriangleSquare(a, b, c);

            Assert.Equal(6, result);
        }
        
        [Theory]
        [InlineData(2, 12.56)]
        [InlineData(5, 4)]
        public void SquareCircleTest(double r, double res)
        {
            SquareLib.Square square = new SquareLib.Square();
            CircleFig.radius = r;

            double result = square.CircleSquare();

            Assert.Equal(res, result);
        }
    }
}