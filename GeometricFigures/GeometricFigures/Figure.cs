namespace GeometricFigures
{
    public abstract class Figure
    {
        abstract public double GetArea();    // get area

        public override string ToString()
        {
            return "Figure data";
        }
    }
}