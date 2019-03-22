using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCalculator.MeasurementUnits;
using ShapesCalculator.Shapes.TwoDimenshional;

namespace ShapesCalculator.Tests
{
    [TestClass]
    public class TrianlgeTests
    {
        [TestMethod]
        public void When_CreateTriangleWithValues_2_3_4_Expect_TriangleWithSides_2_3_4()
        {
            var triangle = new Triangle<Centimeter>(2, 3, 4);

            Assert.AreEqual(2, triangle.Side1.Value);
            Assert.AreEqual(3, triangle.Side2.Value);
            Assert.AreEqual(4, triangle.Side3.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void When_CreateTriangleWithValues_2_3_6_Expect_TriangleCannotBeCreated()
        {
            var triangle = new Triangle<Centimeter>(2, 3, 6);
        }

        [TestMethod]
        public void When_CreateTriangleWithValues_2_3_4_Expect_PerimeterWithValue_9()
        {
            var triangle = new Triangle<Centimeter>(2, 3, 4);

            Assert.AreEqual(9, triangle.Perimeter.Value);
        }

        [TestMethod]
        public void When_CreateTriangleWithValues_2_3_4_Expect_SquareWithValue_2dot9047()
        {
            var triangle = new Triangle<Centimeter>(2, 3, 4);

            Assert.AreEqual(2.9047, triangle.Square.Value, 0.0001);
        }

        [TestMethod]
        public void When_TriangleHasSides_2_3_4_Expect_ItIsNotRectangular()
        {
            var triangle = new Triangle<Centimeter>(2, 3, 4);

           Assert.IsFalse(triangle.IsRectangular);
        }

        [TestMethod]
        public void When_TriangleHasSides_3_4_5_Expect_ItIsRectangular()
        {
            var triangle = new Triangle<Centimeter>(3, 4, 5);

            Assert.IsTrue(triangle.IsRectangular);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_CreateTriangleWithFirstSideNull_Expect_ArgumentNullException()
        {
            var triangle = new Triangle<Centimeter>(null, new Centimeter(4), new Centimeter(4));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_CreateTriangleWithSecondSideNull_Expect_ArgumentNullException()
        {
            var triangle = new Triangle<Centimeter>(new Centimeter(4), null, new Centimeter(4));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_CreateTriangleWithThirdSideNull_Expect_ArgumentNullException()
        {
            var triangle = new Triangle<Centimeter>(new Centimeter(4), new Centimeter(4), null);
        }

    }
}