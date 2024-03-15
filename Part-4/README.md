# Type Casting in C#

Type casting is the process of converting a value from one data type to another in C#. This is often necessary when you want to perform operations on data of different types or when assigning values between variables of different types. C# supports both implicit and explicit type casting.

## Implicit Type Casting:

Implicit type casting, also known as widening conversion, occurs when the target data type can represent all possible values of the source data type without loss of information. C# automatically performs implicit type casting in certain scenarios, such as:

```csharp
int numInt = 10;
double numDouble = numInt; // Implicit casting from int to double
