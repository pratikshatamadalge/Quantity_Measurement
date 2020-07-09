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
            switch (name)
            {
                case "length":
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

                case "volume":
                    switch (unit)
                    {
                        case Volume.LITRE:
                            return value;
                        case Volume.GALLON:
                            return value * 3.78;
                        case Volume.ML:
                            return value / 1000;
                        default:
                            throw new CustomException(CustomException.TypeOfException.INVALID_UNIT_FOR_GIVEN_MEASUREMENT);
                    }

                default:
                    throw new CustomException(CustomException.TypeOfException.INVALID_UNIT_FOR_GIVEN_MEASUREMENT);
            }
        }
    }
}
