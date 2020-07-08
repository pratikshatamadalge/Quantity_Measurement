namespace QuantityMeasurement.Lenghts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Feet
    {
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
        /// <param name="feet"></param>
        public Feet(double feet)
        {
            this.ValueInFeet = feet;
        }

        /// <summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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

        public override int GetHashCode()
        {
            return HashCode.Combine(this.ValueInFeet);
        }
    }
}
