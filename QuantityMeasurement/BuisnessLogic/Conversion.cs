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
                        case length.FEET:
                            return value * 12;

                        case length.YARDS:
                            return value * 36;

                        case length.INCHES:
                            return value;

                        case length.CM:
                            return value / 2.5;
                        default:
                            throw new CustomException(CustomException.TypeOfException.INVALID_UNIT_FOR_GIVEN_MEASUREMENT);
                    }

                case "Volume":
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
