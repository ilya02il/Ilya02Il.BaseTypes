### [Ilya02Il.BaseTypes.Extensions](Ilya02Il.BaseTypes.Extensions.md 'Ilya02Il.BaseTypes.Extensions').[EnumerableExtensions](Ilya02Il.BaseTypes.Extensions.EnumerableExtensions.md 'Ilya02Il.BaseTypes.Extensions.EnumerableExtensions')

## EnumerableExtensions.Join(this IEnumerable<string>, string) Method

Concatenates the members of a constructed [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') collection of type [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String'), using the specified separator between each member.

```csharp
public static string Join(this System.Collections.Generic.IEnumerable<string> sequence, string separator="");
```
#### Parameters

<a name='Ilya02Il.BaseTypes.Extensions.EnumerableExtensions.Join(thisSystem.Collections.Generic.IEnumerable_string_,string).sequence'></a>

`sequence` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='Ilya02Il.BaseTypes.Extensions.EnumerableExtensions.Join(thisSystem.Collections.Generic.IEnumerable_string_,string).separator'></a>

`separator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string to use as a separator.[separator](Ilya02Il.BaseTypes.Extensions.EnumerableExtensions.Join(thisSystem.Collections.Generic.IEnumerable_string_,string).md#Ilya02Il.BaseTypes.Extensions.EnumerableExtensions.Join(thisSystem.Collections.Generic.IEnumerable_string_,string).separator 'Ilya02Il.BaseTypes.Extensions.EnumerableExtensions.Join(this System.Collections.Generic.IEnumerable<string>, string).separator') is included in the returned string only if values has more than one element.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string that consists of the members of values delimited by the [separator](Ilya02Il.BaseTypes.Extensions.EnumerableExtensions.Join(thisSystem.Collections.Generic.IEnumerable_string_,string).md#Ilya02Il.BaseTypes.Extensions.EnumerableExtensions.Join(thisSystem.Collections.Generic.IEnumerable_string_,string).separator 'Ilya02Il.BaseTypes.Extensions.EnumerableExtensions.Join(this System.Collections.Generic.IEnumerable<string>, string).separator') string. If values has no members, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
values is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').