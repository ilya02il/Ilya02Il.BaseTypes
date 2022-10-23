### [Ilya02Il.BaseTypes.Extensions](Ilya02Il.BaseTypes.Extensions.md 'Ilya02Il.BaseTypes.Extensions').[AsyncExtensions](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.md 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions')

## AsyncExtensions.Catch(this Task, Action<Exception>) Method

Метод расширения, принимающий как аргумент делегат [catchBlock](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch(thisSystem.Threading.Tasks.Task,System.Action_System.Exception_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch(thisSystem.Threading.Tasks.Task,System.Action_System.Exception_).catchBlock 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch(this System.Threading.Tasks.Task, System.Action<System.Exception>).catchBlock'),  
который выполняется если во время выполнения [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch(thisSystem.Threading.Tasks.Task,System.Action_System.Exception_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch(thisSystem.Threading.Tasks.Task,System.Action_System.Exception_).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch(this System.Threading.Tasks.Task, System.Action<System.Exception>).task')  
было выкинуто исключение.

```csharp
public static System.Threading.Tasks.Task Catch(this System.Threading.Tasks.Task task, System.Action<System.Exception> catchBlock=null);
```
#### Parameters

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch(thisSystem.Threading.Tasks.Task,System.Action_System.Exception_).task'></a>

`task` [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch(thisSystem.Threading.Tasks.Task,System.Action_System.Exception_).catchBlock'></a>

`catchBlock` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Функция, которая выполняется если во время выполнения [task](Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch(thisSystem.Threading.Tasks.Task,System.Action_System.Exception_).md#Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch(thisSystem.Threading.Tasks.Task,System.Action_System.Exception_).task 'Ilya02Il.BaseTypes.Extensions.AsyncExtensions.Catch(this System.Threading.Tasks.Task, System.Action<System.Exception>).task') было выброшено исключение.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')