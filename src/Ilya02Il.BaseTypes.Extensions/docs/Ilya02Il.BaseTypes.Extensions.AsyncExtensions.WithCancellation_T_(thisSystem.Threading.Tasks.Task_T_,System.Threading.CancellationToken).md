### [Ilya02Il.BaseTypes.Extensions](Ilya02Il.BaseTypes.Extensions.md 'Ilya02Il.BaseTypes.Extensions').[AsyncExtensions](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.md 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions')

## AsyncExtensions.WithCancellation<T>(this Task<T>, CancellationToken) Method

Метод расширения для [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1'),  
позволяющий добавить [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') в  
[System.Threading.Tasks.TaskCompletionSource&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1'),  
токеном которого является [cancelToken](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation_T_(thisSystem.Threading.Tasks.Task_T_,System.Threading.CancellationToken).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation_T_(thisSystem.Threading.Tasks.Task_T_,System.Threading.CancellationToken).cancelToken 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation<T>(this System.Threading.Tasks.Task<T>, System.Threading.CancellationToken).cancelToken')

```csharp
public static System.Threading.Tasks.Task<T> WithCancellation<T>(this System.Threading.Tasks.Task<T> task, System.Threading.CancellationToken cancelToken);
```
#### Type parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation_T_(thisSystem.Threading.Tasks.Task_T_,System.Threading.CancellationToken).T'></a>

`T`

Возвращаемый задачей тип
#### Parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation_T_(thisSystem.Threading.Tasks.Task_T_,System.Threading.CancellationToken).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation_T_(thisSystem.Threading.Tasks.Task_T_,System.Threading.CancellationToken).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation_T_(thisSystem.Threading.Tasks.Task_T_,System.Threading.CancellationToken).T 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation<T>(this System.Threading.Tasks.Task<T>, System.Threading.CancellationToken).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation_T_(thisSystem.Threading.Tasks.Task_T_,System.Threading.CancellationToken).cancelToken'></a>

`cancelToken` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation_T_(thisSystem.Threading.Tasks.Task_T_,System.Threading.CancellationToken).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation_T_(thisSystem.Threading.Tasks.Task_T_,System.Threading.CancellationToken).T 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation<T>(this System.Threading.Tasks.Task<T>, System.Threading.CancellationToken).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')