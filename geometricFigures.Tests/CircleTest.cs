using GeometricFigures;

namespace GeometricFigures.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetArea_6_returned113()
        {
            //arrange
            var circle = new Circle(6);
            double expected = 113.09733552923255;

            //act
            var actual = circle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}