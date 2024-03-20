# Constructors in C#

Constructors in C# are special methods within a class that are automatically called when an instance of the class is created. They are used to initialize the object's state, typically by assigning values to its fields or properties.

## Syntax:

```csharp
class ClassName
{
    // Default constructor (parameterless)
    public ClassName()
    {
        // Initialization logic
    }

    // Parameterized constructor
    public ClassName(parameter1Type parameter1, parameter2Type parameter2, ...)
    {
        // Initialization logic using parameters
    }
}
