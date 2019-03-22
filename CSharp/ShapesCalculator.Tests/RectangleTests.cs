using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCalculator.MeasurementUnits;
using ShapesCalculator.Shapes.TwoDimenshional;

namespace ShapesCalculator.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void When_CreateRectangleWithValues_4_5_Expect_RectangleWithSides_4_5()
        {
            var rectangle = new Rectangle<Centimeter>(4, 5);

            Assert.AreEqual(4, rectangle.Height.Value);
            Assert.AreEqual(5, rectangle.Width.Value);
        }

        [TestMethod]
        public void When_CreateRectangleWithSides_4_5_Expect_SquareWithValue20()
        {
            var rectangle = new Rectangle<Centimeter>(4, 5);

            Assert.AreEqual(20, rectangle.Square.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_CreateRectangleWithHeightNull_Expect_ArgumentNullException()
        {
            var triangle = new Rectangle<Centimeter>(null, new Centimeter(4));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_CreateRectangleWithWidthNull_Expect_ArgumentNullException()
        {
            var triangle = new Rectangle<Centimeter>(new Centimeter(4), null);
        }
    }
}