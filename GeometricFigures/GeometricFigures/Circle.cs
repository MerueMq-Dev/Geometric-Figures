using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Circle : Figure
    {
        public string Name { get; } = "Circle";

        public double Radius { get; }

        public Circle(int radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Argument cannot be zero or less");

            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;

            Math.Round(this.Radius, 3);
        }


        public override string ToString()
        {
            return $"Name figure: {this.Name}\n " +
                  $"Area: {this.GetArea()}";
        }
    }
}
