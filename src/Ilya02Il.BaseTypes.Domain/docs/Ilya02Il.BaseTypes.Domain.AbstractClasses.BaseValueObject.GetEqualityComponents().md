#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.AbstractClasses](Ilya02Il.BaseTypes.Domain.AbstractClasses.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses').[BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject')

## BaseValueObject.GetEqualityComponents() Method

Возвращает перечисляемую коллекцию значений свойств объекта, унаследованного от [BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject').

```csharp
protected abstract System.Collections.Generic.IEnumerable<object> GetEqualityComponents();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Перечисление значений свойств объекта, унаследованного от [BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject').

### Example
Пример показывает как необходимо реализовывать функцию в наследуемом классе  
  
```csharp  
protected override IEnumerable<object> GetEqualityComponents()  
{  
    yield return Property1;  
    yield return Property2;  
    yield return Property3;  
}  
```