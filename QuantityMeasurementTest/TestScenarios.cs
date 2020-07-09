namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement.BuisnessLogic;
    using QuantityMeasurement.Lenghts;
    using QuantityMeasurement.MetricsUnit;
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
            this.Result = Conversion.UnitConvertor<Length>(12, Length.INCHES) == Conversion.UnitConvertor<Length>(12, Length.INCHES);
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
            this.Result = UnitConvertor<Length>(0, Length.FEET) == UnitConvertor<Length>(0, Length.FEET);
            Assert.IsTrue(this.Result);
        }

        [Test]
        public void  ReferenceCheck_Test_For_FEET()
        {
            Feet first_value = new Feet();
            Feet second_value = new Feet();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        [Test]
        public void ImproperType_object_should_Return_False()
        {
            Feet first_value=new Feet();
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
    }
}