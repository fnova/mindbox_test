using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCalculator.MeasurementUnits;
using ShapesCalculator.Shapes.ThreeDimenshional;
using ShapesCalculator.Shapes.TwoDimenshional;

namespace ShapesCalculator.Tests
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void When_CreateSphereWithValue_5_Expect_SphereWithRadius_5()
        {
            var sphere = new Sphere<Centimeter>(5);

            Assert.AreEqual(5, sphere.Radius.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_CreateSphereWithRadius_Null_Expect_ArgumentNullException()
        {
            var sphere = new Sphere<Centimeter>(null);
        }

        [TestMethod]
        public void When_CreateSphereWitRadiues_5_Expect_SphereSquareWithValue_314dot1592()
        {
            var sphere = new Sphere<Centimeter>(5);

            Assert.AreEqual(314.1592, sphere.Square.Value, 0.0001);
        }

        [TestMethod]
        public void When_CreateSphereWitRadiues_5_Expect_SphereVolumeWithValue_523dot5987()
        {
            var sphere = new Sphere<Centimeter>(5);

            Assert.AreEqual(523.5987, sphere.Volume.Value, 0.0001);
        }
    }
}