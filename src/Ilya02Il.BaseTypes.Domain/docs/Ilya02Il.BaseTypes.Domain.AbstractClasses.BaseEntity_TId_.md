#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.AbstractClasses](Ilya02Il.BaseTypes.Domain.AbstractClasses.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses')

## BaseEntity<TId> Class

Базовый класс сущности, от которого должны наследоваться все остальные сущности

```csharp
public abstract class BaseEntity<TId>
```
#### Type parameters

<a name='Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.TId'></a>

`TId`

Тип свойства [Id](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Id.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.Id').

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; BaseEntity<TId>

| Constructors | |
| :--- | :--- |
| [BaseEntity()](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.BaseEntity().md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.BaseEntity()') | Базовый конструктор |
| [BaseEntity(TId)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.BaseEntity(TId).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.BaseEntity(TId)') | |

| Properties | |
| :--- | :--- |
| [Id](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Id.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.Id') | Данное свойство идентифицирует сущность. Сущности, у которых данное свойство равно, считаются равными даже если остальные поля имеют разные значения. |

| Methods | |
| :--- | :--- |
| [Equals(object)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Equals(object).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.Equals(object)') | Показывает равен ли объект, на котором вызывается метод аргументу [obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Equals(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Equals(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.Equals(object).obj'). |
| [GetHashCode()](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.GetHashCode().md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.GetHashCode()') | Serves as the default hash function. |

| Operators | |
| :--- | :--- |
| [operator ==(BaseEntity&lt;TId&gt;, BaseEntity&lt;TId&gt;)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>)') | Оператор равенства, показывает равны ли два объекта типа [BaseEntity&lt;TId&gt;](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>'). |
| [operator !=(BaseEntity&lt;TId&gt;, BaseEntity&lt;TId&gt;)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.op_Inequality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.op_Inequality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>)') | Оператор неравенства. Возвращает значение противоположное тому, которое вернул бы оператор <seealso cref="M:Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity`1.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity{`0},Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity{`0})"/> |
