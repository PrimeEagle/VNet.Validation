using System.Collections.Generic;

namespace VNet.Validation
{
    public interface IValidatorParameters
    {
        List<IValidator> AdditionalValidators { get; init; }
    }
}
