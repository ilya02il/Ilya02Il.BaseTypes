using System;

namespace Ilya02Il.BaseTypes.Domain.AbstractClasses
{
    /// <summary>
    ///     Базовый класс перечисления "Java like".
    /// </summary>
    /// <example>
    ///     Пример реализации перечисления, наследуемого от <see cref="BaseEnumenation"/>:
    ///     <code>
    ///         public class Color : BaseEnumenation
    ///         {
    ///             public static Color Red      = new Color(0, "#FF0000");
    ///             public static Color Green    = new Color(1, "#00FF00");
    ///             public static Color Blue     = new Color(2, "#0000FF");
    ///         }
    ///     </code>
    /// </example>
    public abstract class BaseEnumenation : IComparable
    {
        /// <summary>
        /// Идентификатор элемента перечисления
        /// </summary>
        public int Id { get; protected set; }

        /// <summary>
        /// Значение элемента перечисления
        /// </summary>
        public string Value { get; protected set; }

        /// <param name="id">
        ///     <see cref="Id"/>
        /// </param>
        /// <param name="name">
        ///     <see cref="Value"/>
        /// </param>
        protected BaseEnumenation(int id, string name) => (Id, Value) = (id, name);

        /// <summary>
        ///     Показывает равен ли объект, на котором вызывается метод аргументу <paramref name="obj"/>.
        /// </summary>
        /// <returns>
        ///     <see langword="true"/> если объекты имеют одинаковый тип и значения их свойств <see cref="Id"/> равны.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (!(obj is BaseEnumenation other))
                return false;

            return Id.Equals(other.Id);
        }

        /// <summary>
        ///     Оператор равенства, показывает равны ли два объекта типа <see cref="BaseEnumenation"/>.
        /// </summary>
        /// <returns>
        ///     <see langword="true"/> если выполнено одно из условий:
        ///     <list type="bullet">
        ///         <item>
        ///             <description>Оба объекта имеют значение <see langword="null"/>;</description>
        ///         </item>
        ///         <item>
        ///             <description>Результат вызова метода <see cref="Equals(object)"/> - <see langword="true"/>.</description>
        ///         </item>
        ///     </list>
        ///     
        ///     <see langword="false"/> если выполнено одно из условий:
        ///     <list type="bullet">
        ///         <item>
        ///             <description>Один из объектов имеет значение <see langword="null"/>;</description>
        ///         </item>
        ///         <item>
        ///             <description>Результат вызова метода <see cref="Equals(object)"/> - <see langword="false"/>.</description>
        ///         </item>
        ///     </list>
        /// </returns>
        public static bool operator ==(BaseEnumenation left, BaseEnumenation right)
        {
            if (left is null && right is null)
                return true;

            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }

        /// <summary>
        /// Оператор неравенства. Возвращает значение противоположное тому, которое вернул бы оператор <seealso cref="operator ==(BaseEnumenation, BaseEnumenation)"/>
        /// </summary>
        public static bool operator !=(BaseEnumenation left, BaseEnumenation right) => !left.Equals(right);

        /// <inheritdoc cref="IComparable.CompareTo(object?)"/>
        public int CompareTo(object obj)
        {
            var other = (BaseEnumenation)obj;

            return Id.CompareTo(other.Id);
        }

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode() => (Id.ToString() + Value).GetHashCode();
    }
}
