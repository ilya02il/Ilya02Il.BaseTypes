#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.ValueTypes](Ilya02Il.BaseTypes.Domain.ValueTypes.md 'Ilya02Il.BaseTypes.Domain.ValueTypes').[Result&lt;T&gt;](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>')

## Result<T>.Match<TOut>(Func<T,TOut>, Func<Exception,TOut>) Method

Метод, преобразующий результат в объект типа [TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).TOut') при помощи функции [ifSuccess](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).ifSuccess 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).ifSuccess')  
или функции [ifFauled](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).ifFauled 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).ifFauled') в зависимости от состояния результата.

```csharp
public TOut Match<TOut>(System.Func<T,TOut> ifSuccess, System.Func<System.Exception,TOut> ifFauled);
```
#### Type parameters

<a name='Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).TOut'></a>

`TOut`

Тип результата функции
#### Parameters

<a name='Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).ifSuccess'></a>

`ifSuccess` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.T 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Функция, которая выполняется если результат успешен

<a name='Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).ifFauled'></a>

`ifFauled` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Функция, которая выполняется если результатом является исключение

#### Returns
[TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).TOut')  
Объект типа [TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).TOut'), который является результатом работы одной из функций-аргументов ([ifSuccess](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).ifSuccess 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).ifSuccess') и [ifFauled](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).ifFauled 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).ifFauled')).

### Example
Пример использования функции в контроллере ASP.NET  
  
```csharp  
Result<int> result = _someService.GetIntResult(someArgs);  
return result.Match(val => Ok(val), exp => BadRequest(exp.Message));  
```