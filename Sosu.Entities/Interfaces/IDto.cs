namespace Entities.Interfaces;

/// <summary>
/// Provides nessesary methods/properties to make a Dto
/// </summary>
/// <typeparam name="TDto">Type of the Dto that implements this interface</typeparam>
public interface IDto<TDto>
    where TDto : class, IDto<TDto>
{
}
