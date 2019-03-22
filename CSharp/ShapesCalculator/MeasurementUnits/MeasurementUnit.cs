using System;
using System.Linq.Expressions;

namespace ShapesCalculator.MeasurementUnits
{
    public abstract class MeasurementUnit
    {
        public double Value { get; }

        protected MeasurementUnit(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Cannot initialize measurement unit with non-positive number.");
            }
                
            Value = value;
        }
        
        public static TUnit ValueTo<TUnit>(double value) where TUnit: MeasurementUnit
        {
            var constant = Expression.Constant(value);
            var constructor = typeof(TUnit).GetConstructor(new []{ typeof(double)});
            var newUnit = Expression.New(constructor, constant);
            var lambda = Expression.Lambda<Func<TUnit>>(newUnit);
            var func = lambda.Compile();

            return func();
        }

        protected bool Equals(MeasurementUnit other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((MeasurementUnit)obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator ==(MeasurementUnit left, MeasurementUnit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MeasurementUnit left, MeasurementUnit right)
        {
            return !Equals(left, right);
        }
    }
}