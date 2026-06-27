using System;

namespace Academy.Validations.Utils
{
    public static class ValidationCustom
    {
        public static readonly DateTime InitialValue = new DateTime(1900, 1, 1);
        public static bool IsDateTimeOrDefault(DateTime? value)
        {
            if (value == null)
            {
                return true;
            }
            return (value.HasValue && value.Value >= InitialValue);
        }
        public static bool IsDateTime(DateTime value)
        {
            return value >= InitialValue;
        }
    }
}
