#### [Ilya02Il.BaseTypes.Domain](index.md 'index')
### [Ilya02Il.BaseTypes.Domain.AbstractClasses](Ilya02Il.BaseTypes.Domain.AbstractClasses.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses').[BaseEnumenation&lt;TValue&gt;](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.md 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>')

## BaseEnumenation<TValue>.CompareTo(object) Method

Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.

```csharp
public int CompareTo(object obj);
```
#### Parameters

<a name='Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.CompareTo(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

An object to compare with this instance.

Implements [CompareTo(object)](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable.CompareTo#System_IComparable_CompareTo_System_Object_ 'System.IComparable.CompareTo(System.Object)')

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A value that indicates the relative order of the objects being compared. The return value has these meanings:    
  Value    
  
  Meaning    
  
  Less than zero    
  
  This instance precedes [obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.CompareTo(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.CompareTo(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.CompareTo(object).obj') in the sort order.    
  
  Zero    
  
  This instance occurs in the same position in the sort order as [obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.CompareTo(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.CompareTo(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.CompareTo(object).obj').    
  
  Greater than zero    
  
  This instance follows [obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.CompareTo(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.CompareTo(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.CompareTo(object).obj') in the sort order.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[obj](Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.CompareTo(object).md#Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation_TValue_.CompareTo(object).obj 'Ilya02Il.BaseTypes.Domain.AbstractClasses.BaseEnumenation<TValue>.CompareTo(object).obj') is not the same type as this instance.