using ShapesCalculator.MeasurementUnits;

namespace ShapesCalculator.Shapes.TwoDimenshional
{
    public interface ISquarableShape<TUnit> where TUnit : MeasurementUnit
    {
        Square<TUnit> Square { get; }
    }
}