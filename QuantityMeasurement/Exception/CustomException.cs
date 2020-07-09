namespace QuantityMeasurement
{
    using System;

    public class CustomException : Exception
    {
        public TypeOfException typeOfException;

        public CustomException(TypeOfException typeOfException)
        {
            this.typeOfException = typeOfException;
        }

        public enum TypeOfException
        {
            NULL_POINTER_EXCEPTION, INVALID_UNIT_FOR_GIVEN_MEASUREMENT, INVALID_MEASUREMENT_UNIT_MISMATCH,
        }
    }
}
