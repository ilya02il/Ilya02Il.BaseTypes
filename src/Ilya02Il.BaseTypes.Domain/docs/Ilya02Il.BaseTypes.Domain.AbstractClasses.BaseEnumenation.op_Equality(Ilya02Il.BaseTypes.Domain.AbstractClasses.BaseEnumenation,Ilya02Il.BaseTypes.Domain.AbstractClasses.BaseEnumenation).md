#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.AbstractClasses](Ilya02Il.BaseTypes.Domain.AbstractClasses.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses').[BaseEnumenation](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation')

## BaseEnumenation.operator ==(BaseEnumenation, BaseEnumenation) Operator

Оператор равенства, показывает равны ли два объекта типа [BaseEnumenation](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation').

```csharp
public static bool operator ==(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation left, Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation right);
```
#### Parameters

<a name='Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation).left'></a>

`left` [BaseEnumenation](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation')

<a name='Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.op_Equality(Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation,Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation).right'></a>

`right` [BaseEnumenation](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') если выполнено одно из условий:  
                  
- Оба объекта имеют значение [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null');  
- Результат вызова метода [Equals(object)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Equals(object).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Equals(object)') - [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') если выполнено одно из условий:  
                  
- Один из объектов имеет значение [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null');  
- Результат вызова метода [Equals(object)](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Equals(object).md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation.Equals(object)') - [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').