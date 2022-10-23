### [Ilya02Il.BaseTypes.Extensions](Ilya02Il.BaseTypes.Extensions.md 'Ilya02Il.BaseTypes.Extensions').[AsyncExtensions](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.md 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions')

## AsyncExtensions.Then<TIn,TOut>(this Task<TIn>, Func<TIn,TOut>, Func<TOut>) Method

Метод расширения, принимающий как аргументы делегаты, которые выполняются  
сразу после выполнения [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then<TIn,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TOut>, System.Func<TOut>).task') в зависимости от ее статуса.

```csharp
public static System.Threading.Tasks.Task<TOut> Then<TIn,TOut>(this System.Threading.Tasks.Task<TIn> task, System.Func<TIn,TOut> onSuccess, System.Func<TOut> onCancelled=null);
```
#### Type parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).TIn'></a>

`TIn`

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).TOut'></a>

`TOut`
#### Parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIn](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).TIn 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then<TIn,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TOut>, System.Func<TOut>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).onSuccess'></a>

`onSuccess` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TIn](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).TIn 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then<TIn,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TOut>, System.Func<TOut>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).TOut 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then<TIn,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TOut>, System.Func<TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Функция, которая вызывается сразу после того,  
как [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then<TIn,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TOut>, System.Func<TOut>).task') была успешно выполнена

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).onCancelled'></a>

`onCancelled` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TOut](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).TOut 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then<TIn,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TOut>, System.Func<TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Функция, которая вызывается сразу после того,  
как [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then<TIn,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TOut>, System.Func<TOut>).task') была отменена

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then_TIn,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TOut_,System.Func_TOut_).TOut 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then<TIn,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TOut>, System.Func<TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')