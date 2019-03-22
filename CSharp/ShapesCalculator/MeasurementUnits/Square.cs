namespace ShapesCalculator.MeasurementUnits
{
    public class Square<TUnit> : MeasurementUnit where TUnit : MeasurementUnit
    {
        public Square(double value) : base(value)
        {
        }
    }
}