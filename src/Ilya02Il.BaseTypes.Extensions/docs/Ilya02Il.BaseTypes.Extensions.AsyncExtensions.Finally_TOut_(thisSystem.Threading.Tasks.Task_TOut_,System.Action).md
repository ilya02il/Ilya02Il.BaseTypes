### [Ilya02Il.BaseTypes.Extensions](Ilya02Il.BaseTypes.Extensions.md 'Ilya02Il.BaseTypes.Extensions').[AsyncExtensions](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.md 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions')

## AsyncExtensions.Finally<TOut>(this Task<TOut>, Action) Method

Метод расширения, принимающий как аргумент делегат, который выполняется после завершения [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Action).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Action).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally<TOut>(this System.Threading.Tasks.Task<TOut>, System.Action).task').

```csharp
public static System.Threading.Tasks.Task<TOut> Finally<TOut>(this System.Threading.Tasks.Task<TOut> task, System.Action finallyBlock);
```
#### Type parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Action).TOut'></a>

`TOut`
#### Parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Action).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Action).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Action).TOut 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally<TOut>(this System.Threading.Tasks.Task<TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Action).finallyBlock'></a>

`finallyBlock` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Функция, которая выполняется после выполнения [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Action).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Action).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally<TOut>(this System.Threading.Tasks.Task<TOut>, System.Action).task')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Action).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Action).TOut 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally<TOut>(this System.Threading.Tasks.Task<TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')