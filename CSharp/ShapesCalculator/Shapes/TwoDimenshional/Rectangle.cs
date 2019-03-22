using System;
using ShapesCalculator.MeasurementUnits;

namespace ShapesCalculator.Shapes.TwoDimenshional
{
    public class Rectangle<TUnit> : ISquarableShape<TUnit> where TUnit : MeasurementUnit
    {
        public TUnit Height { get; }
        public TUnit Width { get; }
        public Square<TUnit> Square => new Square<TUnit>(Height.Value * Width.Value);

        public Rectangle(double height, double width) 
            : this(MeasurementUnit.ValueTo<TUnit>(height), MeasurementUnit.ValueTo<TUnit>(width))
        {
        }

        public Rectangle(TUnit height, TUnit width)
        {
            Height = height ?? throw new ArgumentNullException(nameof(height));
            Width = width ?? throw new ArgumentNullException(nameof(width));
        }
    }
}