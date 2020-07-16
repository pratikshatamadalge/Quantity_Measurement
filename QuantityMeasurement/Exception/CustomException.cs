// <copyright file="CustomException.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement
{
    using System;

    /// <summary>
    /// Custom Exceptions.
    /// </summary>
    public class CustomException : Exception
    {
        /// <summary>
        /// Enum.
        /// </summary>
        public TypeOfException TypeOfExceptionValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomException"/> class.
        /// CustomExcption.
        /// </summary>
        /// <param name="typeOfException">Typeof Exception.</param>
        public CustomException(TypeOfException typeOfException)
        {
            this.TypeOfExceptionValue = typeOfException;
        }

        /// <summary>
        /// Enum for custom Exception.
        /// </summary>
        public enum TypeOfException
        {
            /// <summary>
            /// Null pointer exception.
            /// </summary>
            NULL_POINTER_EXCEPTION,

            /// <summary>
            /// Invalid unit for given measurement.
            /// </summary>
            INVALID_UNIT_FOR_GIVEN_MEASUREMENT,

            /// <summary>
            /// Invalid measurement because of unit mismatch.
            /// </summary>
            INVALID_MEASUREMENT_UNIT_MISMATCH,
        }
    }
}
