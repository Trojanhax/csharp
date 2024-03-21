# Overloaded Constructors in C#

In C#, overloaded constructors allow a class to have multiple constructors with different parameter lists. This enables flexibility in object creation by providing various ways to initialize object state based on different input parameters.

## Syntax:

```csharp
class ClassName
{
    // Default constructor (parameterless)
    public ClassName()
    {
        // Initialization logic
    }

    // Overloaded constructor with parameters
    public ClassName(parameter1Type parameter1, parameter2Type parameter2, ...)
    {
        // Initialization logic using parameters
    }
}
