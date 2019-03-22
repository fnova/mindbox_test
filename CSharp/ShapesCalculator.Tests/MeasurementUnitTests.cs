using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCalculator.MeasurementUnits;

namespace ShapesCalculator.Tests
{
    [TestClass]
    public class MeasurementUnitTests
    {
        [TestMethod]
        public void When_CreateCentimeterWithValue_5_Expect_CentimeterWithValue_5()
        {
            var centimeter = new Centimeter(5);

            Assert.AreEqual(5, centimeter.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void When_CreateCentimeterWith_NegativeValue_Expect_ArgumentException()
        {
           var centimeter = new Centimeter(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void When_CreateCentimeterWith_ZeroValue_Expect_ArgumentException()
        {
            var centimeter = new Centimeter(0);
        }

        [TestMethod]
        public void When_CompareTwoCentimetersWith_EqualValues_Expect_TheyAreEqual()
        {
            var centimeter1 = new Centimeter(5);
            var centimeter2 = new Centimeter(5);

            Assert.IsTrue(centimeter1 == centimeter2);
        }

        [TestMethod]
        public void When_CompareTwoCentimetersWith_DifferentValues_Expect_TheyAreNotEqual()
        {
            var centimeter1 = new Centimeter(5);
            var centimeter2 = new Centimeter(6);

            Assert.IsTrue(centimeter1 != centimeter2);
        }

        [TestMethod]
        public void When_CompareDifferentMeasureTypesWith_EqualValues_Expect_TheyAreNotEqual()
        {
            var centimeter1 = new Centimeter(5);    
            var centimeter2 = new Square<Centimeter>(5);

            Assert.IsTrue(centimeter1 != centimeter2);
        }

        [TestMethod]
        public void When_CreateMeasurementUnitWithHackAndValue_5_Expect_MeasurementUnitWithValue_5()
        {
            var centimeter = MeasurementUnit.ValueTo<Centimeter>(5);

            Assert.AreEqual(5, centimeter.Value);
        }

    }
}
