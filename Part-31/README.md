# Class (Object-Oriented Programming) in C#

Object-oriented programming (OOP) is a programming paradigm based on the concept of "objects," which can contain data (attributes) and code (methods). In C#, classes serve as blueprints for creating objects, enabling the encapsulation, inheritance, and polymorphism principles of OOP.

## Example:

```csharp
using System;

// Define a class named Person
class Person
{
    // Declare attributes (fields) of the class
    public string Name;
    public int Age;

    // Define a method within the class
    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance (object) of the Person class
        Person person1 = new Person();

        // Set the values of the object's attributes
        person1.Name = "John";
        person1.Age = 30;

        // Call the method of the object
        person1.SayHello();
    }
}
