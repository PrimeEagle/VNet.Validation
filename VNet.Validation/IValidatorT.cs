using System.Collections.Generic;

namespace VNet.Validation
{
    public interface IValidator<T> : IValidator
    {
        ValidationState DoValidate(T item, ErrorCategory category);
        ValidationState DoValidate(T item, IEnumerable<string> ruleSets, ErrorCategory defaultCategory);
    }
}