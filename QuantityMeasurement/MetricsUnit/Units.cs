// <copyright file="Units.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement.MetricsUnit
{
    /// <summary>
    /// Enum for different Quantity unit.
    /// </summary>
    public static class Units
    {
        /// <summary>
        /// Enum for length.
        /// </summary>
        public enum Length
        {
            /// <summary>
            /// Feet.
            /// </summary>
            FEET,

            /// <summary>
            /// Yards.
            /// </summary>
            YARDS,

            /// <summary>
            /// Centimeter.
            /// </summary>
            CM,

            /// <summary>
            /// Inchesh.
            /// </summary>
            INCHES,
        }

        /// <summary>
        /// Enum for Volume.
        /// </summary>
        public enum Volume
        {
            /// <summary>
            /// Litre.
            /// </summary>
            LITRE,

            /// <summary>
            /// Gallon.
            /// </summary>
            GALLON,

            /// <summary>
            /// Mili Litre
            /// </summary>
            ML,
        }

        /// <summary>
        /// enum for weight.
        /// </summary>
        public enum Weight
        {
            /// <summary>
            /// Kilo.
            /// </summary>
            KILO,

            /// <summary>
            /// Gram.
            /// </summary>
            GRAM,

            /// <summary>
            /// Tonne.
            /// </summary>
            TONNE,
        }

        /// <summary>
        /// Enum for temperature.
        /// </summary>
        public enum Temperature
        {
            /// <summary>
            /// Farenhite.
            /// </summary>
            FARENHITE,

            /// <summary>
            /// Celcious.
            /// </summary>
            CELCIUS,
        }
    }
}
