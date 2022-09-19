using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Triangle : Figure
    {
        public string Name { get; } = "Triangle";

        public double FirstSide { get; }

        public double SecondSide { get; }

        public double ThirdSide { get; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Arguments cannot be zero or less");


            if (!(firstSide + secondSide > thirdSide &&
                firstSide + thirdSide > secondSide &&
                secondSide + thirdSide > firstSide))
            {
                throw new ArgumentException("Triangles with such sides do not exist.");
            }


            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }


        public override double GetArea()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }


        public override string ToString()
        {
            return $"Name figure:{this.Name}\n" +
                   $"Length of a segment: {FirstSide}, {SecondSide}, {ThirdSide}, area: {this.GetArea()}";

        }


        public bool IsRightTriangle()
        {
            if (FirstSide > SecondSide && FirstSide > ThirdSide)
            {
                return Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2) == Math.Pow(FirstSide, 2);
            }
            else if (SecondSide > FirstSide && SecondSide > ThirdSide)
            {
                return Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2) == Math.Pow(SecondSide, 2);
            }
            else if (ThirdSide > FirstSide && ThirdSide > SecondSide)
            {
                return Math.Pow(SecondSide, 2) + Math.Pow(FirstSide, 2) == Math.Pow(ThirdSide, 2);
            }
            else
            {
                return false;
            }
        }
    }
}
