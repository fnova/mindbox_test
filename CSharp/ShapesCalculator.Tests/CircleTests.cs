using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCalculator.MeasurementUnits;
using ShapesCalculator.Shapes.TwoDimenshional;

namespace ShapesCalculator.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void When_CreateCircleWithValue_10_Expect_CircleWithRadius_10()
        {
            var circle = new Circle<Centimeter>(10);

            Assert.AreEqual(10, circle.Radius.Value);
        }

        [TestMethod]
        public void When_CreateCircleWithValue_10_Expect_SquareWithValue_314dot1593()
        {
            var circle = new Circle<Centimeter>(10);

            Assert.AreEqual(314.1593, circle.Square.Value, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_CreateCircleWithRadius_Null_Expect_ArgumentNullException()
        {
            var circle = new Circle<Centimeter>(null);
        }
    }   
}