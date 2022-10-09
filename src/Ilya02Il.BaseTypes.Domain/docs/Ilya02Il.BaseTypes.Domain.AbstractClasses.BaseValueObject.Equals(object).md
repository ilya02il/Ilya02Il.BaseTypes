#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.AbstractClasses](Ilya02Il.BaseTypes.Domain.AbstractClasses.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses').[BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject')

## BaseValueObject.Equals(object) Method

Показывает равен ли объект, на котором вызывается метод аргументу [obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).obj').

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

Объект, сравниваемый с объектом [BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject'), у которого вызывается данный метод.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') если перечисления, являющиеся результатом вызова функции [GetEqualityComponents()](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.GetEqualityComponents().md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.GetEqualityComponents()') у обоих объектов, равны.  
                <br/>[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') если выполнено одно из условий:<br/>  
- объект [obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).obj') имеет тип отличный от [BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject');  
- если перечисления, являющиеся результатом вызова функции [GetEqualityComponents()](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.GetEqualityComponents().md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.GetEqualityComponents()') у обоих объектов, не равны.