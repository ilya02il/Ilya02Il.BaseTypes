### [Ilya02Il.BaseTypes.Extensions](Ilya02Il.BaseTypes.Extensions.md 'Ilya02Il.BaseTypes.Extensions').[AsyncExtensions](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.md 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions')

## AsyncExtensions.Finally(this Task, Action) Method

Метод расширения, принимающий как аргумент делегат, который выполняется после завершения [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally(thisSystem.Threading.Tasks.Task,System.Action).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally(thisSystem.Threading.Tasks.Task,System.Action).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally(this System.Threading.Tasks.Task, System.Action).task').

```csharp
public static System.Threading.Tasks.Task Finally(this System.Threading.Tasks.Task task, System.Action finallyBlock);
```
#### Parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally(thisSystem.Threading.Tasks.Task,System.Action).task'></a>

`task` [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally(thisSystem.Threading.Tasks.Task,System.Action).finallyBlock'></a>

`finallyBlock` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Функция, которая выполняется после выполнения [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally(thisSystem.Threading.Tasks.Task,System.Action).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally(thisSystem.Threading.Tasks.Task,System.Action).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Finally(this System.Threading.Tasks.Task, System.Action).task')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')