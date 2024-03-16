# Switch Statement in C#

The switch statement in C# provides a way to execute different blocks of code based on the value of an expression. It's commonly used when you have multiple cases to handle and want to avoid writing multiple if-else statements.

## Syntax:

```csharp
switch (expression)
{
    case value1:
        // Code block to execute if expression equals value1
        break;
    case value2:
        // Code block to execute if expression equals value2
        break;
    // Add more case statements as needed
    default:
        // Code block to execute if expression does not match any case
        break;
}
