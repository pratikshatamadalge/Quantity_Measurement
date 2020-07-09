namespace QuantityMeasurement.BuisnessLogic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Addition
    {
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
