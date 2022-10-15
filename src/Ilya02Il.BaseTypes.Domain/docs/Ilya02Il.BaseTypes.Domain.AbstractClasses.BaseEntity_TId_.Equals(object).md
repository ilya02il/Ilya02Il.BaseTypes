#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.AbstractClasses](Ilya02Il.BaseTypes.Domain.AbstractClasses.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses').[BaseEntity&lt;TId&gt;](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>')

## BaseEntity<TId>.Equals(object) Method

Показывает равен ли объект, на котором вызывается метод аргументу [obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Equals(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Equals(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.Equals(object).obj').

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Equals(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

Объект, сравниваемый с объектом [BaseEntity&lt;TId&gt;](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>'), у которого вызывается данный метод.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') если выполнено одно из условий:<br/>  
- объекты имеют один тип и одинаковое значение поля [Id](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Id.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.Id');  
- переменные указывают на один объект в памяти.[false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') если выполнено одно из условий:<br/>  
- объекты имеют разные типы;  
- [obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Equals(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Equals(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.Equals(object).obj') не является объектом, унаследованным от типа [BaseEntity&lt;TId&gt;](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>');  
- объекты имеют разные значения свойства [Id](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Id.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.Id');  
- у одного из объектов свойство [Id](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity_TId_.Id.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEntity<TId>.Id') имеет значение [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').