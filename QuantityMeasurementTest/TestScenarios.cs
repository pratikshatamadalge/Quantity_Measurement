namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement.BuisnessLogic;
    using QuantityMeasurement.Lenghts;
    using static QuantityMeasurement.BuisnessLogic.Addition;
    using static QuantityMeasurement.BuisnessLogic.Conversion;
    using static QuantityMeasurement.MetricsUnit.Units;

    public class Tests
    {
        public bool Result;

        [SetUp]
        public void Setup()
        {
            this.Result = false;
        }

        [Test]
        public void TwelveInch_EqualTo_OneFeet_Should_Return_True()
        {
            this.Result = Conversion.UnitConvertor<length>(12, length.INCHES) == Conversion.UnitConvertor<length>(12, length.INCHES);
            Assert.IsTrue(this.Result);
        }

        [Test]
        public void ZeroFeet_EqualTo_ZeroFeet_should_Return_True()
        {
            Feet first_value = new Feet(0.0);
            Feet second_value = new Feet(0.0);
            Assert.IsTrue(first_value.ValueInFeet.Equals(second_value.ValueInFeet));
        }

        [Test]
        public void ZeroFeet_And_NullValue_should_Return_False()
        {
            Feet feet = new Feet();
            Assert.IsFalse(feet.Equals(null));
        }

        [Test]
        public void ZeroFeet_And_ZeroFeet_Should_Return_True()
        {
            this.Result = UnitConvertor<length>(0, length.FEET) == UnitConvertor<length>(0, length.FEET);
            Assert.IsTrue(this.Result);
        }

        [Test]
        public void ReferenceCheck_Test_For_FEET()
        {
            Feet first_value = new Feet();
            Feet second_value = new Feet();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        [Test]
        public void ImproperType_object_should_Return_False()
        {
            Feet first_value = new Feet();
            object second_value = new Feet();

            Assert.IsFalse(first_value.Equals(second_value));
        }

        [Test]
        public void EqualValue_should_Return_True()
        {
            Feet first_value = new Feet();
            first_value.ValueInFeet = 3.6;
            Assert.IsTrue(first_value.Equals(first_value));
        }

        [Test]
        public void ZeroInch_EqualTo_ZeroInch_should_return_true()
        {
            Inches first_value = new Inches();
            Inches second_value = new Inches();
            Assert.IsTrue(first_value.Inch.Equals(second_value.Inch));
        }

        [Test]
        public void ZeroInch_And_NullValue_should_return_False()
        {
            Inches inch = new Inches();
            Assert.IsFalse(inch.Equals(null));
        }

        [Test]
        public void ZeroInch_And_ZeroInch_should_return_true()
        {
            Inches first_value = new Inches();
            Inches second_value = new Inches();
            Assert.IsTrue(first_value.Inch.Equals(second_value.Inch));
        }

        [Test]
        public void ZeroInch_And_NullValue_Should_return_False()
        {
            Inches inch = new Inches();
            Assert.IsFalse(inch.Equals(null));
        }

        [Test]
        public void ReferenceCheck_For_Inch()
        {
            Inches first_value = new Inches();
            Inches second_value = new Inches();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        [Test]
        public void Equal_InchValue_Should_return_true()
        {
            Inches value = new Inches();
            value.Inch = 5.0;
            Assert.IsTrue(value.Equals(value));
        }

        [Test]
        public void Improper_InchType_Value_Should_Return_False()
        {
            Inches first_value = new Inches();
            object second_value = new Inches();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        [Test]
        public void ThreeFeet_compare_one_Yard_should_return_True()
        {
            this.Result = UnitConvertor<length>(3, length.FEET) == UnitConvertor<length>(1, length.YARDS);
            Assert.IsTrue(this.Result);
        }

        [Test]
        public void Provided_OneFeet_And_OneYard_After_Compare_Should_Return_False()
        {
            this.Result = UnitConvertor<length>(1, length.FEET) == UnitConvertor<length>(1, length.YARDS);
            Assert.IsFalse(this.Result);
        }

        [Test]
        public void Provided_OneInche_And_OneYard_When_Compare_Should_Return_False()
        {
            this.Result = UnitConvertor<length>(1, length.INCHES) == UnitConvertor<length>(1, length.YARDS);
            Assert.IsFalse(this.Result);
        }

        [Test]
        public void Provided_OneYard_And_ThirtySixInches_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<length>(1, length.YARDS) == UnitConvertor<length>(36, length.INCHES);
            Assert.IsTrue(this.Result);
        }

        [Test]
        public void Provided_ThirtySixInches_And_OneYard_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<length>(36, length.INCHES) == UnitConvertor<length>(1, length.YARDS);
            Assert.IsTrue(this.Result);
        }

        [Test]
        public void Provided_OneYard_And_ThreeFeet_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<length>(1, length.YARDS) == UnitConvertor<length>(3, length.FEET);
            Assert.IsTrue(this.Result);
        }

        [Test]
        public void Provided_TwoInch_And_FiveCM_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<length>(2, length.INCHES) == UnitConvertor<length>(5, length.CM);
            Assert.IsTrue(this.Result);
        }

        [Test]
        public void TwoInch_Add_TwoInch_Should_Return_FourInch()
        {
            this.Result = Add(UnitConvertor<length>(2, length.INCHES), UnitConvertor<length>(2, length.INCHES), UnitConvertor<length>(4, length.INCHES));
            Assert.IsTrue(this.Result);
        }

        [Test]
        public void OneFeet_Add_TwoInch_should_return_TwentyFourInch()
        {
            this.Result = Add(UnitConvertor<length>(1, length.FEET), UnitConvertor<length>(2, length.INCHES), UnitConvertor<length>(24, length.INCHES));
            Assert.IsFalse(this.Result);
        }

        [Test]
        public void OneFeet_Add_OneFeet_should_return_TwentyFourInch()
        {
            this.Result = Add(UnitConvertor<length>(1, length.FEET), UnitConvertor<length>(1, length.FEET), UnitConvertor<length>(24, length.INCHES));
            Assert.IsTrue(this.Result);
        }

        [Test]
        public void TwoInch_Add_TwoPointFiveInch_rturn_Three_Inch()
        {
            this.Result = Add(UnitConvertor<length>(2, length.INCHES), UnitConvertor<length>(2.5, length.INCHES), UnitConvertor<length>(3, length.INCHES));
            Assert.IsFalse(this.Result);
        }

        [Test]
        public void OneGallon_EqualTo_ThreePointSeventyEightLitre_Should_Return_True()
        {
            this.Result = UnitConvertor<Volume>(1, Volume.GALLON) == UnitConvertor<Volume>(3.78, Volume.LITRE);
            Assert.IsTrue(this.Result);
        }

        [Test]
        public void OneLitre_EqualTo_OneThousandML_Should_Return_True()
        {
            this.Result = UnitConvertor<Volume>(1, Volume.LITRE) == UnitConvertor<Volume>(1000,Volume.ML);
            Assert.IsTrue(this.Result);
        }
    }
}