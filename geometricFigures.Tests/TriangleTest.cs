using GeometricFigures;

namespace GeometricFigures.Tests
{
    [TestClass]
    public class TriangleTest
    {

        [TestMethod()]
        public void IsRightTriangle_3and4and5_returnedTrue()
        {
            //arrange
            var triangle = new Triangle(3, 4, 5);
            bool expected = true;


            //act
            var actual = triangle.IsRightTriangle();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetArea_4and5and6_returned9()
        {
            //arrange
            var triangle = new Triangle(4, 5, 6);
            double expected = 9.921567416492215;

            //act
            var actual = triangle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}