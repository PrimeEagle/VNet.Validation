using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace VNet.Validation
{
    [ExcludeFromCodeCoverage]
    public class ValidationState : ICloneable
    {
        public List<ValidationError> Errors { get; }
        public bool Valid => !Errors.Any();
        
        public bool HasConfigurationErrors => Errors.Any(e => e.Category == ErrorCategory.Configuration);
        public bool HasUsageErrors => Errors.Any(e => e.Category == ErrorCategory.Usage);
        public List<ValidationError> ConfigurationErrors => Errors.Where(e => e.Category == ErrorCategory.Configuration).ToList();
        public List<ValidationError> UsageErrors => Errors.Where(e => e.Category == ErrorCategory.Usage).ToList();
        public List<string> ConfigurationErrorMessages => Errors.Where(e => e.Category == ErrorCategory.Configuration).Select(e => e.ToString()).ToList();
        public List<string> UsageErrorMessages => Errors.Where(e => e.Category == ErrorCategory.Usage).Select(e => e.ToString()).ToList();

        public ValidationState()
        {
            this.Errors = new List<ValidationError>();
        } 

        public void Append(ValidationState validationState)
		{
            this.Errors.AddRange(validationState.Errors);
		}

		public object Clone()
		{
			var clone = (ValidationState)this.MemberwiseClone();

			foreach (var e in this.Errors)
			{
                clone.Errors.Add((ValidationError)e.Clone());
			}

			return clone;
		}
	}
}
