# Static Modifier in C#

In C#, the `static` modifier is used to declare members (fields, methods, properties, constructors, and nested types) that belong to the type itself rather than to instances of the type. This means that static members are shared across all instances of the type and can be accessed directly through the type name.

## Syntax:

### Static Fields and Methods:

```csharp
class ClassName
{
    // Static field
    public static int StaticField;

    // Static method
    public static void StaticMethod()
    {
        // Method body
    }
}
