#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.AbstractClasses](Ilya02Il.BaseTypes.Domain.AbstractClasses.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses')

## BaseEnumenation Class

Базовый класс перечисления "Java like".

```csharp
public abstract class BaseEnumenation :
System.IComparable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; BaseEnumenation

Implements [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable')

### Example
Пример реализации перечисления, наследуемого от [BaseEnumenation](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation'):  
  
```csharp  
public class Color : BaseEnumenation  
{  
    public static Color Red      = new Color(0, "#FF0000");  
    public static Color Green    = new Color(1, "#00FF00");  
    public static Color Blue     = new Color(2, "#0000FF");  
}  
```

| Constructors | |
| :--- | :--- |
| [BaseEnumenation(int, string)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.BaseEnumenation(int,string).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.BaseEnumenation(int, string)') | |

| Properties | |
| :--- | :--- |
| [Id](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Id.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Id') | Идентификатор элемента перечисления |
| [Value](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Value.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Value') | Значение элемента перечисления |

| Methods | |
| :--- | :--- |
| [CompareTo(object)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.CompareTo(object).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.CompareTo(object)') | Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object. |
| [Equals(object)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Equals(object).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Equals(object)') | Показывает равен ли объект, на котором вызывается метод аргументу [obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Equals(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Equals(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Equals(object).obj'). |
| [GetHashCode()](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.GetHashCode().md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.GetHashCode()') | Serves as the default hash function. |

| Operators | |
| :--- | :--- |
| [operator ==(BaseEnumenation, BaseEnumenation)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation)') | Оператор равенства, показывает равны ли два объекта типа [BaseEnumenation](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation'). |
| [operator !=(BaseEnumenation, BaseEnumenation)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.op_Inequality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.op_Inequality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation)') | Оператор неравенства. Возвращает значение противоположное тому, которое вернул бы оператор <seealso cref="M:Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation)"/> |
