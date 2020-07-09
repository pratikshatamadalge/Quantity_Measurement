namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement.BuisnessLogic;
    using QuantityMeasurement.MetricsUnit;
    using static QuantityMeasurement.BuisnessLogic.Conversion;
    using static QuantityMeasurement.MetricsUnit.Units;
    using QuantityMeasurement.Lenghts;

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
    }
}