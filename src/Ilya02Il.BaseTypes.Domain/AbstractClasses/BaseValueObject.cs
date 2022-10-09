using System.Collections.Generic;
using System.Linq;

namespace Ilya02Il.BaseTypes.Domain.AbstractClasses
{
    /// <summary>
    /// Базовый класс, от которого должны наследоваться все ValueObject.<br/>
    /// Два объекта, унаследованных от типа <see cref="BaseValueObject"/> равны, если значения <b>всех</b> их свойств равны.
    /// </summary>
    public abstract class BaseValueObject
    {
        /// <summary>
        ///     Оператор равенства, показывает равны ли два объекта типа <see cref="BaseValueObject"/>.
        /// </summary>
        /// <returns>
        ///     <see langword="true"/> если результат работы метода <see cref="Equals(object)"/> не равен <see langword="false"/>.<br/>
        ///     <see langword="false"/> если выполнено одно из условий:<br/>
        ///     <list type="bullet">
        ///         <item>
        ///             <description>один из объектов имеет значение <see langword="null"/>;</description>
        ///         </item>
        ///         <item>
        ///             <description>результат работы метода <see cref="Equals(object)"/> равен <see langword="false"/>.</description>
        ///         </item>
        ///     </list>
        /// </returns>
        protected static bool EqualOperator(BaseValueObject left, BaseValueObject right)
        {
            if (left is null ^ right is null)
                return false;

            return left?.Equals(right) != false;
        }

        /// <summary>
        /// Оператор неравенства. Возвращает значение противоположное тому, которое вернул бы оператор <seealso cref="EqualOperator(BaseValueObject, BaseValueObject)"/>
        /// </summary>
        protected static bool NotEqualOperator(BaseValueObject left, BaseValueObject right) => !EqualOperator(left, right);

        /// <inheritdoc cref="EqualOperator(BaseValueObject, BaseValueObject)"/>
        public static bool operator ==(BaseValueObject left, BaseValueObject right) => EqualOperator(left, right);

        /// <inheritdoc cref="NotEqualOperator(BaseValueObject, BaseValueObject)"/>
        public static bool operator !=(BaseValueObject left, BaseValueObject right) => NotEqualOperator(left, right);

        /// <summary>
        ///     Возвращает перечисляемую коллекцию значений свойств объекта, унаследованного от <see cref="BaseValueObject"/>.
        /// </summary>
        /// <example>
        ///     Пример показывает как необходимо реализовывать функцию в наследуемом классе
        ///     <code>
        ///         protected override IEnumerable&lt;object&gt; GetEqualityComponents()
        ///         {
        ///             yield return Property1;
        ///             yield return Property2;
        ///             yield return Property3;
        ///         }
        ///     </code>
        /// </example>
        /// <returns>
        ///     Перечисление значений свойств объекта, унаследованного от <see cref="BaseValueObject"/>.
        /// </returns>
        protected abstract IEnumerable<object> GetEqualityComponents();

        /// <summary>
        ///     Показывает равен ли объект, на котором вызывается метод аргументу <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">
        ///     Объект, сравниваемый с объектом <see cref="BaseValueObject"/>, у которого вызывается данный метод.
        /// </param>
        /// <returns>
        ///     <see langword="true"/> если перечисления, являющиеся результатом вызова функции <see cref="GetEqualityComponents"/> у обоих объектов, равны.
        ///     <br/>
        ///     <see langword="false"/> если выполнено одно из условий:<br/>
        ///     <list type="bullet">
        ///         <item>
        ///             <description>объект <paramref name="obj"/> имеет тип отличный от <see cref="BaseValueObject"/>;</description>
        ///         </item>
        ///         <item>
        ///             <description>
        ///                 если перечисления, являющиеся результатом вызова функции <see cref="GetEqualityComponents"/> у обоих объектов, не равны.
        ///             </description>
        ///         </item>
        ///     </list>
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is BaseValueObject other))
                return false;

            return GetEqualityComponents()
                .SequenceEqual(other.GetEqualityComponents());
        }

        /// <inheritdoc cref="object.GetHashCode()"/>
        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => !(x is null) ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }
    }
}
