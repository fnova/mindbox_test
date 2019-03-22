using System;
using ShapesCalculator.MeasurementUnits;

namespace ShapesCalculator.Shapes.ThreeDimenshional
{
    public class Sphere<TUnit> : I3DimenshionalShape<TUnit> where TUnit : MeasurementUnit
    {
        public TUnit Radius { get; }
        public Square<TUnit> Square => new Square<TUnit>(4 * Math.PI * Radius.Value.Square());
        public Cubic<TUnit> Volume => new Cubic<TUnit>(4d / 3d * Math.PI * Radius.Value.Cube());

        public Sphere(double radius) : this(MeasurementUnit.ValueTo<TUnit>(radius))
        {
        }

        public Sphere(TUnit radius)
        {
            Radius = radius ?? throw new ArgumentNullException(nameof(radius));
        }
    }
}
