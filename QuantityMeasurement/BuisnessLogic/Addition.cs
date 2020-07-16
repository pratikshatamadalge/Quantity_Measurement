// <copyright file="Addition.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement.BuisnessLogic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Buisness Logic for Addition of Quantity.
    /// </summary>
    public class Addition
    {
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="firstValue">first value.</param>
        /// <param name="secondValue">Second value.</param>
        /// <param name="expected_value">expected value.</param>
        /// <returns>True or false.</returns>
        public static bool Add(double firstValue, double secondValue, double expected_value)
        {
            double result = firstValue + secondValue;
            if (result == expected_value)
            {
                return true;
            }

            return false;
        }
    }
}
