// <copyright file="Tests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement;
    using QuantityMeasurement.BuisnessLogic;
    using QuantityMeasurement.Lenghts;
    using static QuantityMeasurement.BuisnessLogic.Addition;
    using static QuantityMeasurement.BuisnessLogic.Conversion;
    using static QuantityMeasurement.MetricsUnit.Units;

    /// <summary>
    /// Test cases for Quantity measurement.
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Result.
        /// </summary>
        public bool Result;

        /// <summary>
        /// Initialization.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.Result = false;
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void TwelveInch_EqualTo_OneFeet_Should_Return_True()
        {
            this.Result = Conversion.UnitConvertor<Length>(12, Length.INCHES) == Conversion.UnitConvertor<Length>(12, Length.INCHES);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void ZeroFeet_EqualTo_ZeroFeet_should_Return_True()
        {
            Feet first_value = new Feet(0.0);
            Feet second_value = new Feet(0.0);
            Assert.IsTrue(first_value.ValueInFeet.Equals(second_value.ValueInFeet));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void ZeroFeet_And_NullValue_should_Return_False()
        {
            Feet feet = new Feet();
            Assert.IsFalse(feet.Equals(null));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void ZeroFeet_And_ZeroFeet_Should_Return_True()
        {
            this.Result = UnitConvertor<Length>(0, Length.FEET) == UnitConvertor<Length>(0, Length.FEET);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void ReferenceCheck_Test_For_FEET()
        {
            Feet first_value = new Feet();
            Feet second_value = new Feet();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void ImproperType_object_should_Return_False()
        {
            Feet first_value = new Feet();
            object second_value = new Feet();

            Assert.IsFalse(first_value.Equals(second_value));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void EqualValue_should_Return_True()
        {
            Feet first_value = new Feet();
            first_value.ValueInFeet = 3.6;
            Assert.IsTrue(first_value.Equals(first_value));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void ZeroInch_EqualTo_ZeroInch_should_return_true()
        {
            Inches first_value = new Inches();
            Inches second_value = new Inches();
            Assert.IsTrue(first_value.Inch.Equals(second_value.Inch));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void ZeroInch_And_NullValue_should_return_False()
        {
            Inches inch = new Inches();
            Assert.IsFalse(inch.Equals(null));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void ZeroInch_And_ZeroInch_should_return_true()
        {
            Inches first_value = new Inches();
            Inches second_value = new Inches();
            Assert.IsTrue(first_value.Inch.Equals(second_value.Inch));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void ZeroInch_And_NullValue_Should_return_False()
        {
            Inches inch = new Inches();
            Assert.IsFalse(inch.Equals(null));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void ReferenceCheck_For_Inch()
        {
            Inches first_value = new Inches();
            Inches second_value = new Inches();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void Equal_InchValue_Should_return_true()
        {
            Inches value = new Inches();
            value.Inch = 5.0;
            Assert.IsTrue(value.Equals(value));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void Improper_InchType_Value_Should_Return_False()
        {
            Inches first_value = new Inches();
            object second_value = new Inches();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void ThreeFeet_compare_one_Yard_should_return_True()
        {
            this.Result = UnitConvertor<Length>(3, Length.FEET) == UnitConvertor<Length>(1, Length.YARDS);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void Provided_OneFeet_And_OneYard_After_Compare_Should_Return_False()
        {
            this.Result = UnitConvertor<Length>(1, Length.FEET) == UnitConvertor<Length>(1, Length.YARDS);
            Assert.IsFalse(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void Provided_OneInche_And_OneYard_When_Compare_Should_Return_False()
        {
            this.Result = UnitConvertor<Length>(1, Length.INCHES) == UnitConvertor<Length>(1, Length.YARDS);
            Assert.IsFalse(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void Provided_OneYard_And_ThirtySixInches_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<Length>(1, Length.YARDS) == UnitConvertor<Length>(36, Length.INCHES);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void Provided_ThirtySixInches_And_OneYard_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<Length>(36, Length.INCHES) == UnitConvertor<Length>(1, Length.YARDS);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void Provided_OneYard_And_ThreeFeet_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<Length>(1, Length.YARDS) == UnitConvertor<Length>(3, Length.FEET);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void Provided_TwoInch_And_FiveCM_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<Length>(2, Length.INCHES) == UnitConvertor<Length>(5, Length.CM);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void TwoInch_Add_TwoInch_Should_Return_FourInch()
        {
            this.Result = Add(UnitConvertor<Length>(2, Length.INCHES), UnitConvertor<Length>(2, Length.INCHES), UnitConvertor<Length>(4, Length.INCHES));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void OneFeet_Add_TwoInch_should_return_TwentyFourInch()
        {
            this.Result = Add(UnitConvertor<Length>(1, Length.FEET), UnitConvertor<Length>(2, Length.INCHES), UnitConvertor<Length>(24, Length.INCHES));
            Assert.IsFalse(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void OneFeet_Add_OneFeet_should_return_TwentyFourInch()
        {
            this.Result = Add(UnitConvertor<Length>(1, Length.FEET), UnitConvertor<Length>(1, Length.FEET), UnitConvertor<Length>(24, Length.INCHES));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void TwoInch_Add_TwoPointFiveInch_rturn_Three_Inch()
        {
            this.Result = Add(UnitConvertor<Length>(2, Length.INCHES), UnitConvertor<Length>(2.5, Length.INCHES), UnitConvertor<Length>(3, Length.INCHES));
            Assert.IsFalse(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void Provided_Improper_Type_Measurment_Should_Throw_Exception()
        {
            try
            {
                bool result = UnitConvertor<Length>(12, Length.INCHES) == UnitConvertor<Length>(1, Volume.GALLON);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.TypeOfException.INVALID_UNIT_FOR_GIVEN_MEASUREMENT, e.TypeOfExceptionValue);
            }
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void Improper_Type_Measurment_Should_Throw_Exception()
        {
            try
            {
                bool result = UnitConvertor<Length>(12, Length.INCHES) == UnitConvertor<Volume>(1, Volume.GALLON);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.TypeOfException.INVALID_MEASUREMENT_UNIT_MISMATCH, e.TypeOfExceptionValue);
            }
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void OneGallon_EqualTo_ThreePointSeventyEightLitre_Should_Return_True()
        {
            this.Result = UnitConvertor<Volume>(1, Volume.GALLON) == UnitConvertor<Volume>(3.78, Volume.LITRE);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void OneLitre_EqualTo_OneThousandML_Should_Return_True()
        {
            this.Result = UnitConvertor<Volume>(1, Volume.LITRE) == UnitConvertor<Volume>(1000, Volume.ML);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        public void OneGallon_Add_ThreePointSeventyEightGallon_Return_SevenPointFiftySevenLitres()
        {
            this.Result = Add(UnitConvertor<Volume>(1, Volume.GALLON), UnitConvertor<Volume>(3.78, Volume.LITRE), UnitConvertor<Volume>(7.57, Volume.LITRE));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void OneLitre_Add_OneML_Should_Return_TwoLitre()
        {
            this.Result = Add(UnitConvertor<Volume>(1, Volume.LITRE), UnitConvertor<Volume>(1000, Volume.ML), UnitConvertor<Volume>(2, Volume.LITRE));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void OneKG_Equal_OneThousandGram_Should_Return_True()
        {
            this.Result = UnitConvertor<Weight>(1, Weight.KILO) == UnitConvertor<Weight>(1000, Weight.GRAM);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void OneThousandKG_Equal_OneTonne_should_Return_True()
        {
            this.Result = UnitConvertor<Weight>(1000, Weight.KILO) == UnitConvertor<Weight>(1, Weight.TONNE);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void OneTonne_Add_OneGram_return_OneThousandAndOneKG()
        {
            this.Result = Add(UnitConvertor<Weight>(1, Weight.TONNE), UnitConvertor<Weight>(1000, Weight.GRAM), UnitConvertor<Weight>(1001, Weight.KILO));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test case.
        /// </summary>
        [Test]
        public void TwoHundredAndTwelveFarenhite_EqualTo_Hundred_Celcius()
        {
            this.Result = UnitConvertor<Temperature>(212, Temperature.FARENHITE) == UnitConvertor<Temperature>(100, Temperature.CELCIUS);
            Assert.IsTrue(this.Result);
        }
    }
}