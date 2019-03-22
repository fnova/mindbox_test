using System;
using ShapesCalculator.MeasurementUnits;

namespace ShapesCalculator.Shapes.TwoDimenshional
{
    public class Circle<TUnit> where TUnit : MeasurementUnit 
    {
        public TUnit Radius { get; }
        public Square<TUnit> Square => new Square<TUnit>(Math.PI * Radius.Value.Square());

        public Circle(double radius) : this(MeasurementUnit.ValueTo<TUnit>(radius))
        {
        }

        public Circle(TUnit radius)
        {
            Radius = radius ?? throw new ArgumentException(nameof(radius));
        }
    }
}