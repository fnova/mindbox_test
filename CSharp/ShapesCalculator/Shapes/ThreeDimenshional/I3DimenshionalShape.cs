using ShapesCalculator.MeasurementUnits;
using ShapesCalculator.Shapes.TwoDimenshional;

namespace ShapesCalculator.Shapes.ThreeDimenshional
{
    public interface I3DimenshionalShape<TUnit> : ISquarableShape<TUnit> where TUnit : MeasurementUnit
    {
        Cubic<TUnit> Volume { get; }
    }
}