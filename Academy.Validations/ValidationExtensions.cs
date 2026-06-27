using FluentValidation.Results;
using System.Linq;

namespace Academy.Validations
{
    public static class ValidationExtensions
    {
        public static string ErrorsToString(this ValidationResult result)
        {
            return string.Join(System.Environment.NewLine, result.Errors.Select(c => c.ErrorMessage));
        }
    }
}
