namespace ShapesCalculator.MeasurementUnits
{
    public class Cubic<TUnit> : MeasurementUnit where TUnit : MeasurementUnit
    {
        public Cubic(double value) : base(value)
        {
        }
    }
}