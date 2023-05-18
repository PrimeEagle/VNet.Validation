﻿using System;
using System.Linq;
using FluentValidation.Results;

namespace VNet.Validation.FluentValidation
{
    public static class Utility
    {
        public static ValidationState ConvertToValidationState(this ValidationResult result, ErrorCategory category)
        {
            var state = new ValidationState();

            foreach (var newErr in result.Errors.Select(e => new ValidationError()
            {
                AttemptedValue = e.AttemptedValue,
                ErrorCode = e.ErrorCode,
                ErrorMessage = e.ErrorMessage,
                PropertyName = e.PropertyName,
                Severity = Enum.Parse<ErrorSeverity>(e.Severity.ToString()),
                Category = category
            }))
            {
                state.Errors.Add(newErr);
            }
            return state;
        }
    }
}
