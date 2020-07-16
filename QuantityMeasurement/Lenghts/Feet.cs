// <copyright file="Feet.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement.Lenghts
{
    using System;

    /// <summary>
    /// Length measurement for feet unit.
    /// </summary>
    public class Feet
    {
        /// <summary>
        /// Value in feet.
        /// </summary>
        public double ValueInFeet;

        /// <summary>
        /// Initializes a new instance of the <see cref="Feet"/> class.
        /// </summary>
        public Feet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Feet"/> class.
        /// </summary>
        /// <param name="feet">feet.</param>
        public Feet(double feet)
        {
            this.ValueInFeet = feet;
        }

        /// <returns>true or false.</returns>
        /// <param name="obj">object.</param>
        /// <summary>
        /// Equals override methode.
        /// <summary>
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

            return ((Feet)obj).ValueInFeet == this.ValueInFeet;
        }

        /// <summary>
        /// Override gethashCode method.
        /// </summary>
        /// <returns>int value.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.ValueInFeet);
        }
    }
}
