#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.AbstractClasses](Ilya02Il.BaseTypes.Domain.AbstractClasses.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses')

## BaseValueObject Class

Базовый класс, от которого должны наследоваться все ValueObject.<br/>  
Два объекта, унаследованных от типа [BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject') равны, если значения <b>всех</b> их свойств равны.

```csharp
public abstract class BaseValueObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; BaseValueObject

| Methods | |
| :--- | :--- |
| [EqualOperator(BaseValueObject, BaseValueObject)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.EqualOperator(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.EqualOperator(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject)') | Оператор равенства, показывает равны ли два объекта типа [BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject'). |
| [Equals(object)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object)') | Показывает равен ли объект, на котором вызывается метод аргументу [obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).obj'). |
| [GetEqualityComponents()](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.GetEqualityComponents().md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.GetEqualityComponents()') | Возвращает перечисляемую коллекцию значений свойств объекта, унаследованного от [BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject'). |
| [GetHashCode()](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.GetHashCode().md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.GetHashCode()') | Serves as the default hash function. |
| [NotEqualOperator(BaseValueObject, BaseValueObject)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.NotEqualOperator(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.NotEqualOperator(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject)') | Оператор неравенства. Возвращает значение противоположное тому, которое вернул бы оператор <seealso cref="M:Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.EqualOperator(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject)"/> |

| Operators | |
| :--- | :--- |
| [operator ==(BaseValueObject, BaseValueObject)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject)') | Оператор равенства, показывает равны ли два объекта типа [BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject'). |
| [operator !=(BaseValueObject, BaseValueObject)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.op_Inequality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.op_Inequality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject)') | Оператор неравенства. Возвращает значение противоположное тому, которое вернул бы оператор <seealso cref="M:Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.EqualOperator(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject)"/> |
