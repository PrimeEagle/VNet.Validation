namespace VNet.Validation
{
    public interface IValidatorManager
    {
        ValidationState Validate(object rootObject, ValidationState previousValidationState);
    }
}
