#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.ValueTypes](Ilya02Il.BaseTypes.Domain.ValueTypes.md 'Ilya02Il.BaseTypes.Domain.ValueTypes').[Result&lt;T&gt;](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>')

## Result<T>.Map<TOut>(Func<T,TOut>) Method

Метод, преобразующий результат в объект типа [TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Map<TOut>(System.Func<T,TOut>).TOut') при помощи функции [map](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).map 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Map<TOut>(System.Func<T,TOut>).map').

```csharp
public Ilya02Il.BaseTypes.Domain.ValueTypes.Result<TOut> Map<TOut>(System.Func<T,TOut> map);
```
#### Type parameters

<a name='Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).TOut'></a>

`TOut`

Тип результата функции
#### Parameters

<a name='Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).map'></a>

`map` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.T 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Map<TOut>(System.Func<T,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Функция, преобразующая объект типа [T](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.T 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.T') в объект типа [TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Map<TOut>(System.Func<T,TOut>).TOut').

#### Returns
[Ilya02Il.BaseTypes.Domain.ValueTypes.Result&lt;](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>')[TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Map<TOut>(System.Func<T,TOut>).TOut')[&gt;](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>')  
Объект типа [TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Map<TOut>(System.Func<T,TOut>).TOut'), который является результатом работы функции [map](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).map 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Map<TOut>(System.Func<T,TOut>).map').