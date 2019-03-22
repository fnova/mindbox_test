using System;
using ShapesCalculator.MeasurementUnits;

namespace ShapesCalculator.Shapes.TwoDimenshional
{
    public class Triangle<TUnit> : ISquarableShape<TUnit> where TUnit: MeasurementUnit
    {
        public TUnit Side1 { get; }
        public TUnit Side2 { get; }
        public TUnit Side3 { get; }
        public TUnit Perimeter => MeasurementUnit.ValueTo<TUnit>(Side1.Value + Side2.Value + Side3.Value);
        public bool IsRectangular => PythagorasTheoremIsSatisfied();

        public Square<TUnit> Square 
        {
            get
            {
                var halfperimeter = Perimeter.Value / 2;
                return new Square<TUnit>(Math.Sqrt(halfperimeter *
                                                   (halfperimeter - Side1.Value) *
                                                   (halfperimeter - Side2.Value) *
                                                   (halfperimeter - Side3.Value)));
            }
        }

        public Triangle(double side1, double side2, double side3) :
            this(MeasurementUnit.ValueTo<TUnit>(side1), 
                MeasurementUnit.ValueTo<TUnit>(side2), 
                MeasurementUnit.ValueTo<TUnit>(side3))
        {
        }

        public Triangle(TUnit side1, TUnit side2, TUnit side3)
        {
            if (side1 == null)
                throw new ArgumentNullException(nameof(side1));

            if (side2 == null)
                throw new ArgumentNullException(nameof(side2));

            if (side3 == null)
                throw new ArgumentNullException(nameof(side3));

            if (!CanCreateTriangleWithSides(side1, side2, side3))
                throw new ArgumentException("Cannot create triangle with current sides.");
            
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        private bool CanCreateTriangleWithSides(TUnit side1, TUnit side2, TUnit side3)
        {
            return side1.Value <= side2.Value + side3.Value &&
                   side2.Value <= side1.Value + side3.Value &&
                   side3.Value <= side1.Value + side2.Value;
        }

        private bool PythagorasTheoremIsSatisfied()
        {
            //неизвестно, какая из сторон является гипотенузой, поэтому перебираем все варианты
            var max = Math.Max(Side1.Value, Math.Max(Side2.Value, Side3.Value));
            if (Side1.Value.IsAprroximatelyEqualsTo(max))
            {
                return TheoremIsSatisfied(Side1, Side2, Side3);
            }

            else if (Side2.Value.IsAprroximatelyEqualsTo(max))
            {
                return TheoremIsSatisfied(Side2, Side1, Side3);
            }

            else
            {
                return TheoremIsSatisfied(Side3, Side1, Side2);
            }

            bool TheoremIsSatisfied(TUnit hypotenuse, TUnit cath1, TUnit cath2)
            {
                return hypotenuse.Value.IsAprroximatelyEqualsTo(
                    Math.Sqrt(Math.Pow(cath1.Value, 2) + Math.Pow(cath2.Value, 2))
                );
            }
        }
    }
}