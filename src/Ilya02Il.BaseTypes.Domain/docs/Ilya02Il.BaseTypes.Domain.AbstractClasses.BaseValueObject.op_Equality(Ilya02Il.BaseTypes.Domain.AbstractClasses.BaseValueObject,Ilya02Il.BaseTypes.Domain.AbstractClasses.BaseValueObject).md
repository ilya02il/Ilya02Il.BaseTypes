#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.AbstractClasses](Ilya02Il.BaseTypes.Domain.AbstractClasses.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses').[BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject')

## BaseValueObject.operator ==(BaseValueObject, BaseValueObject) Operator

Оператор равенства, показывает равны ли два объекта типа [BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject').

```csharp
public static bool operator ==(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject left, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject right);
```
#### Parameters

<a name='Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject).left'></a>

`left` [BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject')

<a name='Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject).right'></a>

`right` [BaseValueObject](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') если результат работы метода [Equals(object)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object)') не равен [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').<br/>[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') если выполнено одно из условий:<br/>  
- один из объектов имеет значение [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null');  
- результат работы метода [Equals(object)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseValueObject.Equals(object)') равен [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').