#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.ValueTypes](Ilya02Il.BaseTypes.Domain.ValueTypes.md 'Ilya02Il.BaseTypes.Domain.ValueTypes')

## Result<T> Struct

Значимый тип, используемый как результат функции.<br/>  
Результатом может являться значение [Value](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Value.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Value') типа [T](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.T 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.T')   
тояние - [Success](Ilya02Il.BaseTypes.Domain.Enums.ResultState.md#Ilya02Il.BaseTypes.Domain.Enums.ResultState.Success 'Ilya02Il.BaseTypes.Domain.Enums.ResultState.Success')) или же исключение [Exception](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Exception.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Exception') (состояние - [Faulted](Ilya02Il.BaseTypes.Domain.Enums.ResultState.md#Ilya02Il.BaseTypes.Domain.Enums.ResultState.Faulted 'Ilya02Il.BaseTypes.Domain.Enums.ResultState.Faulted')).

```csharp
public readonly struct Result<T> :
System.IEquatable<Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>>
```
#### Type parameters

<a name='Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.T'></a>

`T`

Тип значения результата.

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Ilya02Il.BaseTypes.Domain.ValueTypes.Result&lt;](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>')[T](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.T 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.T')[&gt;](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Result(Exception)](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Result(System.Exception).md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Result(System.Exception)') | Создает результат (состояние - [Faulted](Ilya02Il.BaseTypes.Domain.Enums.ResultState.md#Ilya02Il.BaseTypes.Domain.Enums.ResultState.Faulted 'Ilya02Il.BaseTypes.Domain.Enums.ResultState.Faulted')) с исключением [exception](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Result(System.Exception).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Result(System.Exception).exception 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Result(System.Exception).exception'). |
| [Result(T)](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Result(T).md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Result(T)') | Создает результат (состояние - [Success](Ilya02Il.BaseTypes.Domain.Enums.ResultState.md#Ilya02Il.BaseTypes.Domain.Enums.ResultState.Success 'Ilya02Il.BaseTypes.Domain.Enums.ResultState.Success')) со значением [value](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Result(T).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Result(T).value 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Result(T).value'). |

| Properties | |
| :--- | :--- |
| [Exception](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Exception.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Exception') | Исключение, являющееся результатом |
| [IsFaulted](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.IsFaulted.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.IsFaulted') | Результатом является исключение |
| [IsSuccess](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.IsSuccess.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.IsSuccess') | Результат успешен, то есть имеет значение |
| [Value](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Value.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Value') | Значение, являющееся результатом |

| Methods | |
| :--- | :--- |
| [Equals(object)](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Equals(object).md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Equals(object)') | Determines whether the specified object is equal to the current object. |
| [GetHashCode()](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.GetHashCode().md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.GetHashCode()') | Serves as the default hash function. |
| [Map&lt;TOut&gt;(Func&lt;T,TOut&gt;)](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Map<TOut>(System.Func<T,TOut>)') | Метод, преобразующий результат в объект типа [TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Map<TOut>(System.Func<T,TOut>).TOut') при помощи функции [map](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Map_TOut_(System.Func_T,TOut_).map 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Map<TOut>(System.Func<T,TOut>).map'). |
| [Match&lt;TOut&gt;(Func&lt;T,TOut&gt;, Func&lt;Exception,TOut&gt;)](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>)') | Метод, преобразующий результат в объект типа [TOut](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).TOut 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).TOut') при помощи функции [ifSuccess](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).ifSuccess 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).ifSuccess')<br/>или функции [ifFauled](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.Match_TOut_(System.Func_T,TOut_,System.Func_System.Exception,TOut_).ifFauled 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.Match<TOut>(System.Func<T,TOut>, System.Func<System.Exception,TOut>).ifFauled') в зависимости от состояния результата. |

| Operators | |
| :--- | :--- |
| [operator ==(Result&lt;T&gt;, Result&lt;T&gt;)](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.op_Equality(Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_,Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_).md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.op_Equality(Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>, Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>)') | Сравнивает объекты [left](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.op_Equality(Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_,Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.op_Equality(Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_,Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_).left 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.op_Equality(Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>, Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>).left') и [right](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.op_Equality(Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_,Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.op_Equality(Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_,Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_).right 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.op_Equality(Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>, Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>).right'). |
| [implicit operator Result&lt;T&gt;(T)](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.op_ImplicitIlya02Il.BaseTypes.Domain.ValueTypes.Result_T_(T).md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.op_Implicit Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>(T)') | Приводит [value](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.op_ImplicitIlya02Il.BaseTypes.Domain.ValueTypes.Result_T_(T).md#Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.op_ImplicitIlya02Il.BaseTypes.Domain.ValueTypes.Result_T_(T).value 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.op_Implicit Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>(T).value') к типу [Result&lt;T&gt;](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>') |
| [operator !=(Result&lt;T&gt;, Result&lt;T&gt;)](Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_.op_Inequality(Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_,Ilya02Il.BaseTypes.Domain.ValueTypes.Result_T_).md 'Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>.op_Inequality(Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>, Ilya02Il.BaseTypes.Domain.ValueTypes.Result<T>)') | |
