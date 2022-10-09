using Ilya02Il.BaseTypes.Domain.ValueTypes;

namespace Ilya02Il.BaseTypes.Domain.Enums
{
    /// <summary>
    /// Перечисление с видами состояния <see cref="Result{T}"/>
    /// </summary>
    internal enum ResultState : byte
    {
        /// <summary>
        /// Результат успешен, то есть имеет значение
        /// </summary>
        Success = 0,
        /// <summary>
        /// Результатом является исключение
        /// </summary>
        Faulted = 1
    }
}
