using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Academy.Forms
{
    internal static class GlobalExtensions
    {
        public static DateTime ToDate(this string value, string format = "dd/MM/yyyy")
        {
            if (DateTime.TryParseExact(value, format, new CultureInfo("pt-BR"), DateTimeStyles.None, out var date))
            {
                return date;
            }
            return DateTime.MinValue;
        }

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

        public static string GetNumbers(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            return new string(value.Where(char.IsDigit).ToArray());
        }

        public static List<string> GetErrors(this ErrorProvider errorProvider, Control parent)
        {
            var errors = new List<string>();

            foreach (Control control in parent.Controls)
            {
                string error = errorProvider.GetError(control);
                if (!string.IsNullOrEmpty(error))
                {
                    errors.Add(error);
                }
                errors.AddRange(GetErrors(errorProvider, control));
            }
            return errors;
        }

        public static string ErrorsToString(this ErrorProvider errorProvider, Control parent)
        {
            return string.Join(System.Environment.NewLine, GetErrors(errorProvider, parent));
        }
    }
}
