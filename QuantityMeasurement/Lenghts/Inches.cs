// <copyright file="Inches.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement.Lenghts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Length measurement for Inches.
    /// </summary>
    public class Inches
    {
        /// <summary>
        /// Length measurement for Inches.
        /// </summary>
        public double Inch;

        /// <summary>
        /// Initializes a new instance of the <see cref="Inches"/> class.
        /// </summary>
        public Inches()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Inches"/> class.
        /// </summary>
        /// <param name="inches">Inches.</param>
        public Inches(double inches)
        {
            this.Inch = inches;
        }

        /// <summary>
        /// Override Equals method.
        /// </summary>
        /// <param name="obj">obj.</param>
        /// <returns>true or false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj == this))
            {
                return false;
            }

            if (!(obj.GetType() == this.GetType()))
            {
                return false;
            }

            return ((Inches)obj).Inch == this.Inch;
        }

        /// <summary>
        /// override method for getHashCode.
        /// </summary>
        /// <returns>integer value.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Override method of ToString.
        /// </summary>
        /// <returns>String.</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
