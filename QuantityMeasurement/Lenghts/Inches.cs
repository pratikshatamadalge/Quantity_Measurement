using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement.Lenghts
{
    class Inches
    {
        public double Inch;

        public Inches()
        {
        }

        public Inches(double inches)
        {
            this.Inch = inches;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(!(obj == this))
            {
                return false;
            }

            if(!(obj.GetType()==this.GetType()))
            {
                return false;
            }

            return ((Inches)obj).Inch == this.Inch;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
