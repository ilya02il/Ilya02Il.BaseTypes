### [Ilya02Il.BaseTypes.Extensions](Ilya02Il.BaseTypes.Extensions.md 'Ilya02Il.BaseTypes.Extensions').[AsyncExtensions](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.md 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions')

## AsyncExtensions.WithCancellation(this Task, CancellationToken) Method

Метод расширения для [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task'),  
позволяющий добавить [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') в  
[System.Threading.Tasks.TaskCompletionSource&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1'),  
токеном которого является [cancelToken](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation(thisSystem.Threading.Tasks.Task,System.Threading.CancellationToken).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation(thisSystem.Threading.Tasks.Task,System.Threading.CancellationToken).cancelToken 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation(this System.Threading.Tasks.Task, System.Threading.CancellationToken).cancelToken')

```csharp
public static System.Threading.Tasks.Task WithCancellation(this System.Threading.Tasks.Task task, System.Threading.CancellationToken cancelToken);
```
#### Parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation(thisSystem.Threading.Tasks.Task,System.Threading.CancellationToken).task'></a>

`task` [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.WithCancellation(thisSystem.Threading.Tasks.Task,System.Threading.CancellationToken).cancelToken'></a>

`cancelToken` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')