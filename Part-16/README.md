# Nested Loops in C#

Nested loops in C# refer to the situation where one loop is placed inside another loop. This allows you to create complex iteration patterns, iterate over multi-dimensional data structures, or perform repetitive tasks with multiple levels of iteration.

## Syntax:

```csharp
for (initialization1; condition1; iteration1)
{
    // Code block for outer loop
    for (initialization2; condition2; iteration2)
    {
        // Code block for inner loop
    }
}
