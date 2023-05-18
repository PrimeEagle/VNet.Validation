using System.Collections.Generic;

namespace VNet.Validation
{
    public class DefaultValidatorParameters : IValidatorParameters
    {
        public List<IValidator> AdditionalValidators { get; init; }
    }
}
