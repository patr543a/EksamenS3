namespace Entities.Interfaces;

/// <summary>
/// Provides method require to convert to Dto
/// </summary>
/// <typeparam name="TFrom">Class to convert to Dto. Must implement this interface</typeparam>
/// <typeparam name="TTo">Dto to convert to. Must implement IDto<TTo></typeparam>
public interface IDtoConversion<in TFrom, out TTo>
    where TFrom : class, IDtoConversion<TFrom, TTo>
    where TTo : class, IDto<TTo>
{
    /// <summary>
    /// Converts a class of type TFrom to Dto of type TTo
    /// </summary>
    /// <returns>Dto of TFrom</returns>
    TTo ToDto();
}
