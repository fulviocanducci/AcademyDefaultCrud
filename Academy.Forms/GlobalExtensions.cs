using System;
using System.Globalization;

namespace Academy.Forms
{
    internal static class GlobalExtensions
    {
        public static DateTime? ToDateOrDefault(this string value, string format = "dd/MM/yyyy")
        {
            if (DateTime.TryParseExact(value, format, new CultureInfo("pt-BR"), DateTimeStyles.None, out var date))
            {
                return date;
            }
            return null;
        }

        public static DateTime? ToDateTimeOrDefault(this string value, string format = "dd/MM/yyyy HH:mm:ss")
        {
            if (DateTime.TryParseExact(value, format, new CultureInfo("pt-BR"), DateTimeStyles.None, out var date))
            {
                return date;
            }
            return null;
        }

        public static string ToDateOrDefault(this DateTime? date, string format = "dd/MM/yyyy")
        {
            if (date == null)
            {
                return null;
            }
            return date.Value.ToString(format);
        }

        public static string ToDateTimeOrDefault(this DateTime? date, string format = "dd/MM/yyyy HH:mm:ss")
        {
            if (date == null)
            {
                return null;
            }
            return date.Value.ToString(format);
        }
    }
}
