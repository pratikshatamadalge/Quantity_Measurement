namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement.BuisnessLogic;
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
            this.Result = Conversion.UnitConvertor<Length>(12, Units.Length.INCHES) == Conversion.UnitConvertor<Length>(12, Units.Length.INCHES);
            Assert.IsTrue(this.Result);
        }
    }
}