### [Ilya02Il.BaseTypes.Extensions](Ilya02Il.BaseTypes.Extensions.md 'Ilya02Il.BaseTypes.Extensions').[AsyncExtensions](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.md 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions')

## AsyncExtensions.Then(this Task, Action, Action) Method

Метод расширения, принимающий как аргументы делегаты, которые выполняются  
сразу после выполнения [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(thisSystem.Threading.Tasks.Task,System.Action,System.Action).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(thisSystem.Threading.Tasks.Task,System.Action,System.Action).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(this System.Threading.Tasks.Task, System.Action, System.Action).task') в зависимости от ее статуса.

```csharp
public static System.Threading.Tasks.Task Then(this System.Threading.Tasks.Task task, System.Action onSuccess=null, System.Action onCancelled=null);
```
#### Parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(thisSystem.Threading.Tasks.Task,System.Action,System.Action).task'></a>

`task` [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(thisSystem.Threading.Tasks.Task,System.Action,System.Action).onSuccess'></a>

`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Функция, которая вызывается сразу после того,  
как [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(thisSystem.Threading.Tasks.Task,System.Action,System.Action).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(thisSystem.Threading.Tasks.Task,System.Action,System.Action).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(this System.Threading.Tasks.Task, System.Action, System.Action).task') была успешно выполнена

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(thisSystem.Threading.Tasks.Task,System.Action,System.Action).onCancelled'></a>

`onCancelled` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Функция, которая вызывается сразу после того,  
как [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(thisSystem.Threading.Tasks.Task,System.Action,System.Action).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(thisSystem.Threading.Tasks.Task,System.Action,System.Action).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Then(this System.Threading.Tasks.Task, System.Action, System.Action).task') была отменена

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')