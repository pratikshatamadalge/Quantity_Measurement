namespace QuantityMeasurement.BuisnessLogic
{
    using System;
    using static QuantityMeasurement.MetricsUnit.Units;

    public static class Conversion
    {
        /// <summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="value"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        /// </summary>
        public static double UnitConvertor<E>(double value, Enum unit)
        {
            Type type = typeof(E);
            string name = type.Name;
            switch (unit)
            {
                case Length.FEET:
                    return value * 12;

                case Length.YARDS:
                    return value * 36;

                case Length.INCHES:
                    return value;

                case Length.CM:
                    return value / 2.5;
                default:
                    throw new CustomException(CustomException.TypeOfException.INVALID_UNIT_FOR_GIVEN_MEASUREMENT);
            }
        }
    }
}
