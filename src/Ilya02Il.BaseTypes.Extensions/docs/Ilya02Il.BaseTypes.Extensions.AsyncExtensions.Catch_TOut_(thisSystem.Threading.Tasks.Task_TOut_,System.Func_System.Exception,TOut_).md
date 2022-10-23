### [Ilya02Il.BaseTypes.Extensions](Ilya02Il.BaseTypes.Extensions.md 'Ilya02Il.BaseTypes.Extensions').[AsyncExtensions](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.md 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions')

## AsyncExtensions.Catch<TOut>(this Task<TOut>, Func<Exception,TOut>) Method

Метод расширения, принимающий как аргумент делегат [catchBlock](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).catchBlock 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch<TOut>(this System.Threading.Tasks.Task<TOut>, System.Func<System.Exception,TOut>).catchBlock'),  
который выполняется если во время выполнения [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch<TOut>(this System.Threading.Tasks.Task<TOut>, System.Func<System.Exception,TOut>).task')  
было выкинуто исключение.

```csharp
public static System.Threading.Tasks.Task<TOut> Catch<TOut>(this System.Threading.Tasks.Task<TOut> task, System.Func<System.Exception,TOut> catchBlock);
```
#### Type parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).TOut'></a>

`TOut`
#### Parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).TOut 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch<TOut>(this System.Threading.Tasks.Task<TOut>, System.Func<System.Exception,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).catchBlock'></a>

`catchBlock` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).TOut 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch<TOut>(this System.Threading.Tasks.Task<TOut>, System.Func<System.Exception,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Функция, которая выполняется если во время выполнения [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch<TOut>(this System.Threading.Tasks.Task<TOut>, System.Func<System.Exception,TOut>).task') было выброшено исключение.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch_TOut_(thisSystem.Threading.Tasks.Task_TOut_,System.Func_System.Exception,TOut_).TOut 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch<TOut>(this System.Threading.Tasks.Task<TOut>, System.Func<System.Exception,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')