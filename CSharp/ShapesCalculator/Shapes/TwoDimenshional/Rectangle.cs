using System;
using ShapesCalculator.MeasurementUnits;

namespace ShapesCalculator.Shapes.TwoDimenshional
{
    public class Rectangle<TUnit> : ISquarableShape<TUnit> where TUnit : MeasurementUnit
    {
        public TUnit Side1 { get; }
        public TUnit Side2 { get; }
        public Square<TUnit> Square => new Square<TUnit>(Side1.Value * Side2.Value);

        public Rectangle(double side1, double side2) 
            : this(MeasurementUnit.ValueTo<TUnit>(side1), MeasurementUnit.ValueTo<TUnit>(side2))
        {
        }

        public Rectangle(TUnit side1, TUnit side2)
        {
            Side1 = side1 ?? throw new ArgumentNullException(nameof(side1));
            Side2 = side2 ?? throw new ArgumentNullException(nameof(side2));
        }
    }
}