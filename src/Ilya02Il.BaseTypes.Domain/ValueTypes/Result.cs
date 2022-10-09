using Ilya02Il.BaseTypes.Domain.Enums;
using System;

namespace Ilya02Il.BaseTypes.Domain.ValueTypes
{
    /// <summary>
    ///     Значимый тип, используемый как результат функции.<br/>
    ///     Результатом может являться значение <see cref="Value"/> типа <typeparamref name="T"/> 
    /// (состояние - <see cref="ResultState.Success"/>) или же исключение <see cref="Exception"/> (состояние - <see cref="ResultState.Faulted"/>).
    /// </summary>
    /// <typeparam name="T">
    ///     Тип значения результата.
    /// </typeparam>
    public readonly struct Result<T> : IEquatable<Result<T>>
    {
        private readonly T _value;
        private readonly Exception _exception;
        private readonly ResultState _state;

        /// <summary>
        ///     Создает результат (состояние - <see cref="ResultState.Success"/>) со значением <paramref name="value"/>.
        /// </summary>
        /// <param name="value">
        ///     Значение, являющееся результатом.
        /// </param>
        public Result(T value)
        {
            _value = value;
            _exception = default;
            _state = ResultState.Success;
        }

        /// <summary>
        ///     Создает результат (состояние - <see cref="ResultState.Faulted"/>) с исключением <paramref name="exception"/>.
        /// </summary>
        /// <param name="exception">
        ///     Исключение, являющееся результатом.
        /// </param>
        public Result(Exception exception)
        {
            _value = default;
            _exception = exception;
            _state = ResultState.Faulted;
        }

        /// <summary>
        /// Значение, являющееся результатом
        /// </summary>
        public T Value
        {
            get
            {
                if (IsFaulted)
                    throw new Exception("The result faulted and does not have the value.");

                return _value;
            }
        }

        /// <summary>
        /// Исключение, являющееся результатом
        /// </summary>
        public Exception Exception
        {
            get
            {
                if (IsSuccess)
                    throw new Exception("The result is success and does not have an exception.");

                return _exception;
            }
        }

        /// <inheritdoc cref="ResultState.Success"/>
        public bool IsSuccess => _state == ResultState.Success;
        /// <inheritdoc cref="ResultState.Faulted"/>
        public bool IsFaulted => _state == ResultState.Faulted;

        /// <summary>
        /// Приводит <paramref name="value"/> к типу <see cref="Result{T}"/>
        /// </summary>
        public static implicit operator Result<T>(T value) => new Result<T>(value);
        /// <summary>
        ///     Сравнивает объекты <paramref name="left"/> и <paramref name="right"/>.
        /// </summary>
        /// <returns>
        ///     <see langword="true"/> если значения свойств <see cref="Value"/> и <see cref="Exception"/> 
        ///     у <paramref name="left"/> равны значениям этих свойств у <paramref name="right"/>
        /// </returns>
        public static bool operator ==(Result<T> left, Result<T> right) => left.Equals(right);
        /// <returns>
        /// Значение, противоположное <see cref="operator ==(Result{T}, Result{T})"/>.
        /// </returns>
        public static bool operator !=(Result<T> left, Result<T> right) => !left.Equals(right);

        /// <inheritdoc cref="object.Equals(object)"/>
        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;

            if (!(obj is Result<T> other))
                return false;

            if (!Equals(other))
                return false;

            return true;
        }

        /// <inheritdoc cref="object.GetHashCode()"/>
        public override int GetHashCode() => _value.GetHashCode() ^ _exception.GetHashCode();

        /// <summary>
        ///     Метод, преобразующий результат в объект типа <typeparamref name="TOut"/> при помощи функции <paramref name="ifSuccess"/>
        ///     или функции <paramref name="ifFauled"/> в зависимости от состояния результата.
        /// </summary>
        /// <typeparam name="TOut">
        ///     Тип результата функции
        /// </typeparam>
        /// <param name="ifSuccess">
        ///     Функция, которая выполняется если результат успешен
        /// </param>
        /// <param name="ifFauled">
        ///     Функция, которая выполняется если результатом является исключение
        /// </param>
        /// <returns>
        ///     Объект типа <typeparamref name="TOut"/>, который является результатом работы одной из функций-аргументов (<paramref name="ifSuccess"/> и <paramref name="ifFauled"/>).
        /// </returns>
        /// <example>
        ///     Пример использования функции в контроллере ASP.NET
        ///     <code>
        ///         Result&lt;int&gt; result = _someService.GetIntResult(someArgs);
        ///         return result.Match(val => Ok(val), exp => BadRequest(exp.Message));
        ///     </code>
        /// </example>
        public TOut Match<TOut>(Func<T, TOut> ifSuccess, Func<Exception, TOut> ifFauled) =>
            IsSuccess ? ifSuccess(_value) : ifFauled(_exception);

        /// <summary>
        ///     Метод, преобразующий результат в объект типа <typeparamref name="TOut"/> при помощи функции <paramref name="map"/>.
        /// </summary>
        /// <typeparam name="TOut">
        ///     Тип результата функции
        /// </typeparam>
        /// <param name="map">
        ///     Функция, преобразующая объект типа <typeparamref name="T"/> в объект типа <typeparamref name="TOut"/>. 
        /// </param>
        /// <returns>
        ///     Объект типа <typeparamref name="TOut"/>, который является результатом работы функции <paramref name="map"/>.
        /// </returns>
        public Result<TOut> Map<TOut>(Func<T, TOut> map) =>
            IsSuccess ? new Result<TOut>(map(_value)) : new Result<TOut>(_exception);

        private bool Equals(Result<T> other) =>
            _value.Equals(other._value) &&
            _exception == other._exception &&
            _state == other._state;

        bool IEquatable<Result<T>>.Equals(Result<T> other) => Equals(other);
    }
}
