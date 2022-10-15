#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.AbstractClasses](Ilya02Il.BaseTypes.Domain.AbstractClasses.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses')

## BaseEnumenation<TValue> Class

Базовый класс перечисления "Java like".

```csharp
public abstract class BaseEnumenation<TValue> :
System.IComparable
```
#### Type parameters

<a name='Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.TValue'></a>

`TValue`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; BaseEnumenation<TValue>

Implements [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable')

### Example
Пример реализации перечисления, наследуемого от [BaseEnumenation&lt;TValue&gt;](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>'):  
  
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
| [BaseEnumenation(int, TValue)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.BaseEnumenation(int,TValue).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.BaseEnumenation(int, TValue)') | |

| Properties | |
| :--- | :--- |
| [Id](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.Id.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.Id') | Идентификатор элемента перечисления |
| [Value](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.Value.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.Value') | Значение элемента перечисления |

| Methods | |
| :--- | :--- |
| [CompareTo(object)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.CompareTo(object).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.CompareTo(object)') | Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object. |
| [Equals(object)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.Equals(object).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.Equals(object)') | Показывает равен ли объект, на котором вызывается метод аргументу [obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.Equals(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.Equals(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.Equals(object).obj'). |
| [GetHashCode()](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.GetHashCode().md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.GetHashCode()') | |

| Operators | |
| :--- | :--- |
| [operator ==(BaseEnumenation&lt;TValue&gt;, BaseEnumenation&lt;TValue&gt;)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>)') | Оператор равенства, показывает равны ли два объекта типа [BaseEnumenation&lt;TValue&gt;](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>'). |
| [implicit operator int(BaseEnumenation&lt;TValue&gt;)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.op_Implicitint(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.op_Implicit int(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>)') | Оператор неявного приведения [BaseEnumenation&lt;TValue&gt;](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>') к типу [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). |
| [operator !=(BaseEnumenation&lt;TValue&gt;, BaseEnumenation&lt;TValue&gt;)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.op_Inequality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.op_Inequality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>)') | Оператор неравенства. Возвращает значение противоположное тому, которое вернул бы оператор <seealso cref="M:Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation`1.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation{`0},Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation{`0})"/> |
