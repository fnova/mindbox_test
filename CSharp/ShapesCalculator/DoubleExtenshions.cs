using System;

namespace ShapesCalculator
{
    public static class DoubleExtenshions
    {
        public static bool IsAprroximatelyEqualsTo(this double value1, double value2, 
            double tolerance = 0.0000001)
        {
            return Math.Abs(value1 - value2) < tolerance;
        }

        public static double Square(this double value)
        {
            return Math.Pow(value, 2);
        }

        public static double Cube(this double value)
        {
            return Math.Pow(value, 3);
        }
    }
}