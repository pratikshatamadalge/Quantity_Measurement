// <copyright file="Conversion.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement.BuisnessLogic
{
    using System;
    using static QuantityMeasurement.MetricsUnit.Units;

    /// <summary>
    /// Buisness Logic for Quantity conversion.
    /// </summary>
    public static class Conversion
    {
        /// <summary>
        /// Unit convertor method.
        /// </summary>
        /// <typeparam name="T">Generic.</typeparam>
        /// <param name="value">Entered value.</param>
        /// <param name="unit">Given Unit.</param>
        /// <returns>double value.</returns>
        public static double UnitConvertor<T>(double value, Enum unit)
        {
            Type type = typeof(T);
            string name = type.Name;
            switch (name)
            {
                case "Length":
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

                case "Weight":
                    switch (unit)
                    {
                        case Weight.GRAM:
                            return value / 1000;

                        case Weight.KILO:
                            return value;

                        case Weight.TONNE:
                            return value * 1000;

                        default:
                            throw new CustomException(CustomException.TypeOfException.INVALID_UNIT_FOR_GIVEN_MEASUREMENT);
                    }

                case "Temperature":
                    switch (unit)
                    {
                        case Temperature.CELCIUS:
                            return value;

                        case Temperature.FARENHITE:
                            return (value - 32) * 5 / 9;

                        default:
                            throw new CustomException(CustomException.TypeOfException.INVALID_UNIT_FOR_GIVEN_MEASUREMENT);
                    }

                default:
                    throw new CustomException(CustomException.TypeOfException.INVALID_UNIT_FOR_GIVEN_MEASUREMENT);
            }
        }
    }
}