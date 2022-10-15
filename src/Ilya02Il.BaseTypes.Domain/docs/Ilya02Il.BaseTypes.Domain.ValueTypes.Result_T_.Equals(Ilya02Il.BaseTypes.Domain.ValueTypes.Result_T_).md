#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.ValueTypes](Ilya02Il.BaseTypes.Domain.ValueTypes.md 'Ilya02Il.BaseTypes.Domain.ValueTypes').[Result&lt;T&gt;](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>')

## Result<T>.Equals(Result<T>) Method

Показывает равен ли объект, на котором вызывается метод аргументу [other](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Equals(Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Equals(Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_).other 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Equals(Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>).other').

```csharp
private bool Equals(Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T> other);
```
#### Parameters

<a name='Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Equals(Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_).other'></a>

`other` [Ilya02Il.BaseTypes.Domain.ValueTypes.Result&lt;](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>')[T](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.T 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.T')[&gt;](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>')

Объект типа [Result&lt;T&gt;](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>'), с которым сравнивается текущий объект

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') если значения [Value](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Value.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Value') равны, а также значения [Exception](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Exception.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Exception') равны.