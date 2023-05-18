using System;
using System.Diagnostics.CodeAnalysis;

namespace VNet.Validation
{
    [ExcludeFromCodeCoverage]
    public class ValidationError : ICloneable
    {
        public string ErrorMessage { get; set; }
        public string ErrorCode { get; set; }
        public string PropertyName { get; set; }
        public object AttemptedValue { get; set; }
        public ErrorSeverity Severity { get; set; }
        public ErrorCategory Category { get; set; }

		public object Clone()
		{
			return this.MemberwiseClone();
		}

		public override string ToString()
        {
            return ErrorMessage;
        }
    }
}
